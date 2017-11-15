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
    public partial class MainForm : Form, IFormRefresher
    {
        List<DailyEntryModel> consumedToday = GlobalConfig.Connection.GetAllDailyEntries();
        List<DayModel> days = GlobalConfig.Connection.GetAllDays().OrderByDescending(x => x.Date).ToList();


        public MainForm()
        {
            InitializeComponent();
            DisplayMacronutrients();
        }

        private void DisplayMacronutrients()
        {
            float calories = 0;
            float carbohydrates = 0;
            float includingSugars = 0;
            float protein = 0;
            float fat = 0;
            float fiber = 0;


            foreach (DailyEntryModel d in consumedToday)
            {
                d.CalculateMacronutrients();

                calories += d.Calories;
                carbohydrates += d.Carbohydrates;
                includingSugars += d.IncludingSugars;
                protein += d.Protein;
                fat += d.Fat;
                fiber += d.Fiber;
            }

            dayCaloriesValueLabel.Text = calories.ToString();
            dayCarbohydratesValueLabel.Text = carbohydrates.ToString();
            dayIncludingSugarsValueLabel.Text = includingSugars.ToString();
            dayProteinsValueLabel.Text = protein.ToString();
            dayFatValueLabel.Text = fat.ToString();
            dayFibreValueLabel.Text = fiber.ToString();
        }

        private void ResetDisplayedMacro()
        {
            dayCaloriesValueLabel.Text = "0";
            dayCarbohydratesValueLabel.Text = "0";
            dayIncludingSugarsValueLabel.Text = "0";
            dayProteinsValueLabel.Text = "0";
            dayFatValueLabel.Text = "0";
            dayFibreValueLabel.Text = "0";
        }

        private void calculateMealButton_Click(object sender, EventArgs e)
        {
            CalculateMealForm calcForm = new CalculateMealForm(this);
            calcForm.Show();
            helpLabel.Hide();
        }

        private void browserProductsButton_Click(object sender, EventArgs e)
        {
            BrowseProductsForm brForm = new BrowseProductsForm(this);
            brForm.Show();
            helpLabel.Hide();
        }

        private void browserMealsButton_Click(object sender, EventArgs e)
        {
            BrowseMealsForm brMForm = new BrowseMealsForm(this);
            brMForm.Show();
            helpLabel.Hide();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void resetDailyButton_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Are you sure you want to reset day?", "Reset day.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmDelete == DialogResult.Yes)
            {
                GlobalConfig.Connection.DeleteAllDailyEntries();
                consumedToday = new List<DailyEntryModel>();
                ResetDisplayedMacro();
            }
            else if (confirmDelete == DialogResult.No)
            {
                return;
            }
        }

        private void consumedTodayButton_Click(object sender, EventArgs e)
        {
            DailyOverviewForm doForm = new DailyOverviewForm(this);
            doForm.Show();

        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            AddNewProductForm apForm = new AddNewProductForm();
            apForm.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            if (!helpLabel.Visible)
            {
                helpLabel.Show();
            }
            else
            {
                helpLabel.Hide();
            }
        }


        private void newDayButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = saveDatePicker.Value;

            // Ponownie pobierz dni z bazy danych, gdyby dzień został dodany za pomocą daily overview
            days = GlobalConfig.Connection.GetAllDays();

            bool overWritting = false;
            int overWritedDayId = -1;

            foreach (DayModel day in days)
            {
                if (day.CompareDates(selectedDate))
                {
                    var wantToOverWrite = MessageBox.Show("Selected date already exists in database!\nDo you want to overwrite it?\nPrevious data will be lost.",
                                                          "Selected date already exist.",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (wantToOverWrite == DialogResult.Yes)
                    {
                        overWritting = true;
                        overWritedDayId = day.Id;
                        break;
                    }
                    else if (wantToOverWrite == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            float calories = float.Parse(dayCaloriesValueLabel.Text);
            float carbs = float.Parse(dayCarbohydratesValueLabel.Text);
            float sugar = float.Parse(dayIncludingSugarsValueLabel.Text);
            float protein = float.Parse(dayProteinsValueLabel.Text);
            float fat = float.Parse(dayFatValueLabel.Text);
            float fiber = float.Parse(dayFibreValueLabel.Text);

            if (calories == 0 && carbs == 0 && sugar == 0 && protein == 0 && fat == 0 && fiber == 0)
            {
                MessageBox.Show("You have not consumed any macronutrients today!", "No macronutrients consumed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool confirmed = false; ;

                if (!overWritting)
                {
                    var saveDayConfirmation = MessageBox.Show("Are you sure you want to save the day?", "Save day confirmation.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (saveDayConfirmation == DialogResult.Yes)
                    {
                        confirmed = true;
                    }
                }

                if (confirmed || overWritting)
                {
                    DayModel model = new DayModel();
                    model.Date = selectedDate;
                    model.Calories = calories;
                    model.Carbohydrates = carbs;
                    model.IncludingSugars = sugar;
                    model.Protein = protein;
                    model.Fat = fat;
                    model.Fiber = fiber;

                    if (!overWritting)
                    {
                        GlobalConfig.Connection.AddDayToHistory(model);
                    }
                    else
                    {
                        if(overWritedDayId == -1)
                        {
                            MessageBox.Show("An error occured while editing a day!\nPlease try again or delete day from history.", 
                                            "Error editing day!", 
                                            MessageBoxButtons.OK, 
                                            MessageBoxIcon.Error);
                            return;
                        }

                        model.Id = overWritedDayId;
                        GlobalConfig.Connection.OverwriteDay(model);
                    }

                    GlobalConfig.Connection.DeleteAllDailyEntries();
                    consumedToday = new List<DailyEntryModel>();
                    MessageBox.Show("Day Saved successfully!", "Day saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshForm();
                }
                else
                {
                    return;
                }
            }
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            HistoryForm hForm = new HistoryForm();
            hForm.Show();
        }

        public void RefreshForm()
        {
            consumedToday = GlobalConfig.Connection.GetAllDailyEntries();
            DisplayMacronutrients();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
