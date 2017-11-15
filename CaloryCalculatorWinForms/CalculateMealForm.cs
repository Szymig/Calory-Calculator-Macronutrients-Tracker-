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
    public partial class CalculateMealForm : Form, IProductRequester
    {
        List<ProductModel> avaliableProducts = GlobalConfig.Connection.GetAllProducts();
        List<ProductModel> displayedProducts;
        List<IngredientModel> selectedIngredients = new List<IngredientModel>();
        List<Category> categories = new List<Category>();
        List<MealModel> meals = GlobalConfig.Connection.GetAllMeals();

        Macronutrients makro = new Macronutrients();

        IFormRefresher callingForm;
        MealModel mealToEdit;

        public CalculateMealForm(IFormRefresher caller)
        {
            InitializeComponent();
            callingForm = caller;
            displayedProducts = avaliableProducts;
            PopulateCategoryComboBox();
            WireUpLists();
        }

        public CalculateMealForm(IFormRefresher caller, MealModel mealToEdit)
        {
            InitializeComponent();
            callingForm = caller;
            this.mealToEdit = mealToEdit;
            displayedProducts = avaliableProducts;
            PopulateCategoryComboBox();
            if (mealToEdit != null)
            {
                headerLabel.Text = "Edit Meal";
                saveMealButton.Text = "Edit Meal";
                consumeMealButton.Text = "Edit and Consume!";
                this.Text = "Edit Meal";
                PopulateFieldsToEdit();
            }
            else
            {
                MessageBox.Show("An error occured, try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            WireUpLists();
        }

        private void WireUpLists()
        {
            chooseProductValue.DataSource = null;
            chooseProductValue.DataSource = displayedProducts;
            chooseProductValue.DisplayMember = "Name";

            selectedIngredientsListBox.DataSource = null;
            selectedIngredientsListBox.DataSource = selectedIngredients;
            selectedIngredientsListBox.DisplayMember = "NameAndMass";
        }

        private void PopulateCategoryComboBox()
        {
            for (int i = 0; i < (int)ProductCategory.Count; i++)
            {
                categories.Add(new Category((ProductCategory)i));
            }

            categories.Insert(0, new Category(ProductCategory.Count));

            categories = categories.OrderBy(x => x.Name).ToList();

            selectCategoryValue.DataSource = categories;
            selectCategoryValue.DisplayMember = "Name";

            selectCategoryValue.SelectedItem = categories[0];
        }

        private void PopulateFieldsToEdit()
        {
            selectedIngredients = mealToEdit.Ingredients;
            mealNameValue.Text = mealToEdit.Name;

            caloriesValue.Text = mealToEdit.Calories.ToString();
            carbohydratesValue.Text = mealToEdit.Carbohydrates.ToString();
            includingSugarsValue.Text = mealToEdit.IncludingSugars.ToString();
            proteinsValue.Text = mealToEdit.Protein.ToString();
            fatValue.Text = mealToEdit.Fat.ToString();
            fiberValue.Text = mealToEdit.Fiber.ToString();
        }


        private void createNewProductButton_Click(object sender, EventArgs e)
        {
            AddNewProductForm form = new AddNewProductForm(this);
            form.Show();
        }

        private bool ValidateAddIngredient()
        {
            bool output = true;

            string errorMessage = "";
            float mass = 0;
            int units = 0;

            if(!float.TryParse(weightTextBox.Text, out mass) && weightTextBox.Text.Length >0)
            {
                errorMessage += "Incorrect Mass!\n";
                output = false;
            }

            if(!int.TryParse(unitsTextBox.Text, out units) && unitsTextBox.Text.Length >0)
            {
                errorMessage += "Incorrect Units!\n";
                output = false;
            }

            if((weightTextBox.Text.Length == 0 && unitsTextBox.Text.Length == 0) || (mass == 0 && units == 0))
            {
                errorMessage += "Please specify product mass or quantity";
                output = false;
            }

            if (!output)
            {
                MessageBox.Show(errorMessage, "Inalid input data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return output;
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            ProductModel product = (ProductModel) chooseProductValue.SelectedItem;

            if(product != null)
            {
                if (ValidateAddIngredient())
                {
                    IngredientModel ingredient = new IngredientModel();
                    ingredient.Product = product;
                    float mass = 0;
                    int units = 0;

                    if(weightTextBox.Text.Length > 0)
                    {
                        mass = float.Parse(weightTextBox.Text);
                    }
                    if (unitsTextBox.Text.Length > 0)
                    {
                        units = int.Parse(unitsTextBox.Text);
                    }

                    if (mass > 0)
                    {
                        ingredient.Mass = mass;
                        ingredient.Units = 0;
                    }
                    else if (units >0 && product.OneUnitMass > 0)
                    {
                        ingredient.Units = int.Parse(unitsTextBox.Text);
                        ingredient.Mass = product.OneUnitMass * ingredient.Units;
                    }
                    else if (units > 0 && product.OneUnitMass <= 0)
                    {
                        MessageBox.Show("Selected product does not have one unit mass specified.\nPlease enter mass. ", "Inalid input data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    AddToSelectedIngredients(ingredient);

                    weightTextBox.Text = "";
                    unitsTextBox.Text = "";
                }
                
            }

            WireUpLists();

            ResetInfoLabels();

            CalculateNutriens();
            UpdateNutriensLabels();
        }

        private void AddToSelectedIngredients(IngredientModel ingredient)
        {
            foreach (IngredientModel m in selectedIngredients)
            {
                if(m.Product.Id == ingredient.Product.Id)
                {
                    if(m.Units > 0 && ingredient.Units > 0)
                    {
                        m.Units += ingredient.Units;
                        m.Mass = m.Units * m.Product.OneUnitMass;
                        return;
                    }
                    else if(m.Units <= 0 && ingredient.Units <= 0)
                    {
                        m.Mass += ingredient.Mass;
                        return;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            selectedIngredients.Add(ingredient);
        }

        private void CalculateNutriens()
        {
            makro.Reset();
            foreach (IngredientModel mod in selectedIngredients)
            {
                makro.Calories += mod.Product.Calories / 100 * mod.Mass;
                makro.Carbohydrates += mod.Product.Carbohydrates / 100 * mod.Mass;
                makro.IncludingSugars += mod.Product.IncludingSugars / 100 * mod.Mass;
                makro.Protein += mod.Product.Protein / 100 * mod.Mass;
                makro.Fat += mod.Product.Fat / 100 * mod.Mass;
                makro.Fiber += mod.Product.Fiber / 100 * mod.Mass;
            }
        }

        private void UpdateNutriensLabels()
        {
            caloriesValue.Text = makro.Calories.ToString();
            carbohydratesValue.Text = makro.Carbohydrates.ToString();
            includingSugarsValue.Text = makro.IncludingSugars.ToString();
            proteinsValue.Text = makro.Protein.ToString();
            fatValue.Text = makro.Fat.ToString();
            fiberValue.Text = makro.Fiber.ToString();
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            IngredientModel ing = (IngredientModel) selectedIngredientsListBox.SelectedItem;

            if(ing != null)
            {
                //displayedProducts.Add(ing.Product);
                selectedIngredients.Remove(ing);

                WireUpLists();
            }

            CalculateNutriens();
            UpdateNutriensLabels();
        }

        private bool ValidateSaveMeal()
        {
            bool output = true;
            string errorMessage = "";

            ResetInfoLabels();

            if (!(selectedIngredients.Count>0))
            {
                output = false;
                errorMessage = errorMessage + "No ingredients selected!\n";
            }
            if(selectedIngredients.Count == 1)
            {
                output = false;
                errorMessage += "You need to add more than one ingredient\n";
            }

            if(! (mealNameValue.Text.Length > 0))
            {
                output = false;
                errorMessage = errorMessage + "No Meal Name specified!\n";
            }
            else if(mealNameValue.Text.Length > 100)
            {
                output = false;
                errorMessage = errorMessage + "Meal name is to long! (max 100 characters)\n";
            }
            else
            {
                foreach (var m in meals)
                {
                    if(mealNameValue.Text == m.Name)
                    {
                        if(mealToEdit != null)
                        {
                            if(mealToEdit.Id != m.Id)
                            {
                                output = false;
                                errorMessage = errorMessage + "Meal with given name already exists!\n";
                                break;
                            }
                        }
                        else
                        {
                            output = false;
                            errorMessage = errorMessage + "Meal with given name already exists!\n";
                            break;
                        }
                    }
                }
            }

            if(output == false)
            {
                errorMessage = errorMessage + "\nPlease enter valid data.";
                MessageBox.Show(errorMessage, "Invalid input data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return output;
        }

        private void ResetInfoLabels()
        {
            mealSavedLabel.Hide();
        }

        private MealModel SaveMeal()
        {
            ResetInfoLabels();

            MealModel meal = new MealModel();

            if(mealToEdit != null)
            {
                meal = mealToEdit;
            }

            meal.Name = mealNameValue.Text;
            meal.Calories = float.Parse(caloriesValue.Text);
            meal.Carbohydrates = float.Parse(carbohydratesValue.Text);
            meal.IncludingSugars = float.Parse(includingSugarsValue.Text);
            meal.Protein = float.Parse(proteinsValue.Text);
            meal.Fat = float.Parse(fatValue.Text);
            meal.Fiber = float.Parse(fiberValue.Text);

            meal.Ingredients = selectedIngredients;

            if(mealToEdit != null)
            {
                GlobalConfig.Connection.EditMeal(meal);
            }
            else
            {
                GlobalConfig.Connection.CreateMeal(meal);
                mealSavedLabel.Show();
            }

            return meal;
        } 

        private void saveMealButton_Click(object sender, EventArgs e)
        {
            if (ValidateSaveMeal())
            {
                SaveMeal();
                if(mealToEdit != null)
                {
                    callingForm.RefreshForm();
                    this.Close();
                }

                mealNameValue.Text = "";
            }
        }



        public void CreatedProduct(ProductModel model)
        {
            displayedProducts.Add(model);
            WireUpLists();

            chooseProductValue.SelectedItem = model;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searching = searchTextBox.Text;
            displayedProducts = new List<ProductModel>();
            List<ProductModel> foundProducts = new List<ProductModel>();
            Category selectedCategory = (Category)selectCategoryValue.SelectedItem;


            // To not check category im every iteretion if it is not needed
            if (selectedCategory.ProdCategory == ProductCategory.Count)
            {
                foreach (ProductModel p in avaliableProducts)
                {
                    if (p.Name.IndexOf(searching, StringComparison.InvariantCultureIgnoreCase) != -1)
                    {
                        displayedProducts.Add(p);
                    }
                }
            }
            else
            {
                foreach (ProductModel p in avaliableProducts)
                {
                    if (p.Name.IndexOf(searching, StringComparison.InvariantCultureIgnoreCase) != -1)
                    {
                        if (selectedCategory.ProdCategory == p.Category)
                        {
                            displayedProducts.Add(p);
                        }
                    }
                }
            }


            WireUpLists();
        }

        private void consumeMealButton_Click(object sender, EventArgs e)
        {
            DailyEntryModel dailyEntry = new DailyEntryModel();

            if(selectedIngredients.Count == 1)
            {
                dailyEntry.Product = selectedIngredients[0].Product;
                dailyEntry.Mass = selectedIngredients[0].Mass;
                dailyEntry.Units = selectedIngredients[0].Units;

                dailyEntry.CalculateMacronutrients();
            }
            else if(ValidateSaveMeal())
            {
                dailyEntry.Meal = SaveMeal();
            }
            else
            {
                return;
            }

            GlobalConfig.Connection.CreateDailyEntry(dailyEntry);
            if(callingForm != null)
            {
                callingForm.RefreshForm();
            }
            this.Close();
        }

        private void selectCategoryValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayedProducts = new List<ProductModel>();
            List<ProductModel> foundProducts = new List<ProductModel>();
            Category selectedCategory = (Category)selectCategoryValue.SelectedItem;

            if (selectedCategory.ProdCategory == ProductCategory.Count)
            {
                displayedProducts = avaliableProducts;
            }
            else
            {
                foreach (ProductModel p in avaliableProducts)
                {
                    if (selectedCategory.ProdCategory == p.Category)
                    {
                        displayedProducts.Add(p);
                    }
                }
            }


            WireUpLists();
        }

    }
}
