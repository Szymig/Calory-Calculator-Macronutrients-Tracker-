using CaloryCalculatorLibrary;
using CaloryCalculatorLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloryCalculatorWinForms
{
    public partial class BrowseMealsForm : Form, IFormRefresher
    {
        List<MealModel> displayedMeals = new List<MealModel>();
        List<MealModel> avaliableMeals = GlobalConfig.Connection.GetAllMeals();

        List<IngredientModel> displayedIngredients = new List<IngredientModel>();

        MealModel activeMeal = new MealModel();
        MealModel mealAfterRefresh = new MealModel();

        IFormRefresher callingForm;

        public BrowseMealsForm(IFormRefresher caller)
        {
            InitializeComponent();
            callingForm = caller;
            displayedMeals = avaliableMeals;
            WireUpMealsList();
        }

        private void WireUpMealsList()
        {
            mealsListBox.DataSource = null;
            mealsListBox.DataSource = displayedMeals;
            mealsListBox.DisplayMember = "Name";
        }

        private void WireUpIngredientsLists()
        {
            MealModel meal = (MealModel)mealsListBox.SelectedItem;
            if(meal != null)
            {
                ingredientsListBox.DataSource = null;
                ingredientsListBox.DataSource = meal.Ingredients;
                ingredientsListBox.DisplayMember = "NameAndMass";
            }
            else
            {
                ingredientsListBox.DataSource = null;
            }

        }

        private void SearchForMeal()
        {
            string searching = mealNameValue.Text;
            displayedMeals = new List<MealModel>();
            List<MealModel> foundProducts = new List<MealModel>();

            foreach (MealModel p in avaliableMeals)
            {
                if (p.Name.IndexOf(searching, StringComparison.InvariantCultureIgnoreCase) != -1)
                {
                    displayedMeals.Add(p);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForMeal();
            WireUpMealsList();
            addedToConsumptionLabel.Hide();
        }

        private void mealsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeMeal = (MealModel)mealsListBox.SelectedItem;

            if(activeMeal != null)
            {
                caloriesValueLabel.Text = activeMeal.Calories.ToString();
                carbohydratesValueLabel.Text = activeMeal.Carbohydrates.ToString();
                includingSugarsValueLabel.Text = activeMeal.IncludingSugars.ToString();
                proteinsValueLabel.Text = activeMeal.Protein.ToString();
                fatValueLabel.Text = activeMeal.Fat.ToString();
                fiberValueLabel.Text = activeMeal.Fiber.ToString();

                selectedMealNameLabel.Text = activeMeal.Name;

                addedToConsumptionLabel.Hide();
            }
            else
            {
                selectedMealNameLabel.Text = "";
            }

            WireUpIngredientsLists();
        }

        private void consumeButton_Click(object sender, EventArgs e)
        {
            DailyEntryModel dailyEntry = new DailyEntryModel();

            if(activeMeal != null)
            {
                dailyEntry.Meal = activeMeal;

                GlobalConfig.Connection.CreateDailyEntry(dailyEntry);

                addedToConsumptionLabel.Show();
                MessageBox.Show("Meal successfully added to daily consumption!", "Meal added!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                callingForm.RefreshForm();
            }
        }

        private bool CheckIfCanDelete()
        {
            bool output = true;
            string errorMessage = "";

            List<DailyEntryModel> dailyEntries = GlobalConfig.Connection.GetAllDailyEntries();

            foreach (DailyEntryModel dE in dailyEntries)
            {
                if(dE.Meal != null)
                {
                    if (dE.Meal.Id == activeMeal.Id)
                    {
                        output = false;
                        errorMessage += "You can not delete meal you consumed today!\nEdit your Daily Consumption or move to a new day.";
                        break;
                    }
                }
            }

            if(output == false)
            {
                MessageBox.Show(errorMessage, "Can not delete meal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return output;
        }

        private void deleteMealButton_Click(object sender, EventArgs e)
        {
            if(activeMeal != null)
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete meal " + activeMeal.Name + "?", "Delete meal.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(confirmDelete == DialogResult.Yes)
                {
                    if (CheckIfCanDelete())
                    {
                        GlobalConfig.Connection.DeleteMeal(activeMeal);
                        avaliableMeals.Remove(activeMeal);
                        displayedMeals.Remove(activeMeal);

                        WireUpMealsList();
                    }
                }
                else if(confirmDelete == DialogResult.No)
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("No meal selected!", "Error deleting meal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editMealButton_Click(object sender, EventArgs e)
        {
            if(activeMeal != null)
            {
                mealAfterRefresh = activeMeal;
                //EditMealForm edmForm = new EditMealForm(this, activeMeal);
                //edmForm.Show();
                CalculateMealForm edmForm = new CalculateMealForm(this, activeMeal);
                edmForm.Show();
            }
            else
            {
                MessageBox.Show("No meal selected!", "Error editing meal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshForm()
        {
            List<MealModel> avaliableMeals = GlobalConfig.Connection.GetAllMeals();
            displayedMeals = avaliableMeals;
            WireUpMealsList();

            for(int i=0; i<displayedMeals.Count; i++)
            {
                if(displayedMeals[i].Id == mealAfterRefresh.Id)
                {
                    mealsListBox.SelectedIndex = i;
                    break;
                }
            }

            callingForm.RefreshForm();
        }
    }
}
