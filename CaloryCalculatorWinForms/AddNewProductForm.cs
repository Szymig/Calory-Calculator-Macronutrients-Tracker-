using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaloryCalculatorLibrary.Models;
using CaloryCalculatorLibrary;

namespace CaloryCalculatorWinForms
{
    public partial class AddNewProductForm : Form
    {
        IProductRequester callingForm;
        IFormRefresher callingFormToRefresh;

        private List<Category> categories = new List<Category>();
        private List<ProductModel> products = GlobalConfig.Connection.GetAllProducts();

        ProductModel productToEdit;

        public AddNewProductForm()
        {
            InitializeComponent();
            PopulateCategoryComboBox();
        }

        public AddNewProductForm(IFormRefresher caller, ProductModel productToEdit)
        {
            InitializeComponent();
            PopulateCategoryComboBox();
            callingFormToRefresh = caller;
            this.productToEdit = productToEdit;
            this.Text = "Edit Product";
            createProductButton.Text = "Edit Product";
            headerLabel.Text = "Edit Product";
            PopulateFieldsToEdit();
        }

        public AddNewProductForm(IProductRequester caller)
        {
            InitializeComponent();
            PopulateCategoryComboBox();

            callingForm = caller;
        }

        private void PopulateCategoryComboBox()
        {
            for(int i = 0; i<(int)ProductCategory.Count; i++)
            {
                categories.Add(new Category((ProductCategory) i));
            }

            categoryValue.DataSource = categories;
            categoryValue.DisplayMember = "Name";
        }

        private void PopulateFieldsToEdit()
        {
            productNameValue.Text = productToEdit.Name;
            categoryValue.SelectedIndex = (int) productToEdit.Category;
            caloriesValue.Text = productToEdit.Calories.ToString();
            carbohydratesValue.Text = productToEdit.Carbohydrates.ToString();
            includingSugarsValue.Text = productToEdit.IncludingSugars.ToString();
            proteinsValue.Text = productToEdit.Protein.ToString();
            fatValue.Text = productToEdit.Fat.ToString();
            fiberValue.Text = productToEdit.Fiber.ToString();
            unitMassValue.Text = productToEdit.OneUnitMass.ToString();
        }


        private bool ValidateForm()
        {
            string errorMessage = "";

            bool output = true;
            float outFloat;

            //Checking Name TextBox
            if(productNameValue.Text.Length == 0)
            {
                errorMessage += "Invalid product name! \n";
                output = false;
            }
            else if(productNameValue.Text.Length > 50)
            {
                errorMessage += "Too long product name!\n";
                output = false;
            }
            else
            {
                foreach (ProductModel p in products)
                {
                    if(productNameValue.Text == p.Name)
                    {
                        if(productToEdit != null)
                        {
                            if(productToEdit.Id != p.Id)
                            {
                                errorMessage += "Prodduct with given name already exists!\n";
                                output = false;
                                break;
                            }
                        }
                        else
                        {
                            errorMessage += "Prodduct with given name already exists!\n";
                            output = false;
                            break;
                        }
                    }
                }
            }

            //Checking Calories TextBox
            if(!float.TryParse(caloriesValue.Text, out outFloat))
            {
                errorMessage += "Invalid calories amount! \n";
                output = false;
            }
            else if (outFloat < 0)
            {
                output = false;
                errorMessage += "Invalid calories amount! \n";
            }

            //Checking Carbo TextBox
            if (!float.TryParse(carbohydratesValue.Text, out outFloat))
            {
                output = false;
                errorMessage += "Invalid carbohydrates amount! \n";
            }
            else if (outFloat < 0)
            {
                output = false;
                errorMessage += "Invalid carbohydrates amount! \n";
            }

            //Checking Sugars TextBox
            if (!float.TryParse(includingSugarsValue.Text, out outFloat))
            {
                output = false;
                errorMessage += "Invalid includingSugars amount! \n";
            }
            else if (outFloat < 0)
            {
                output = false;
                errorMessage += "Invalid includingSugars amount! \n";
            }

            //Checking Proteins TextBox
            if (!float.TryParse(proteinsValue.Text, out outFloat))
            {
                output = false;
                errorMessage += "Invalid proteins amount! \n";
            }
            else if (outFloat < 0)
            {
                output = false;
                errorMessage += "Invalid proteins amount! \n";
            }

            //Checking Fat TextBox
            if (!float.TryParse(fatValue.Text, out outFloat))
            {
                output = false;
                errorMessage += "Invalid fat amount! \n";
            }
            else if (outFloat < 0)
            {
                output = false;
                errorMessage += "Invalid fat amount! \n";
            }

            //Checking Fiber TextBox
            if (!float.TryParse(fiberValue.Text, out outFloat))
            {
                output = false;
                errorMessage += "Invalid fiber amount! \n";
            }
            else if (outFloat < 0)
            {
                output = false;
                errorMessage += "Invalid fiber amount! \n";
            }

            if(unitMassValue.Text.Length > 0)
            {
                if (!int.TryParse(unitMassValue.Text, out int units))
                {
                    errorMessage += "Invalid unit mass value!";
                    output = false;
                }
                else if(units < 0)
                {
                    errorMessage += "Invalid unit mass value!";
                    output = false;
                }

            }

            if(output == false)
            {
                MessageBox.Show(errorMessage, "Invalid input data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return output;
        }


        private void createProductButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ProductModel model = new ProductModel();

                if (productToEdit != null)
                {
                    model = productToEdit;
                }
                model.Name = productNameValue.Text;
                model.Category = (ProductCategory) ((Category)categoryValue.SelectedItem).ProdCategory;
                model.Calories = float.Parse(caloriesValue.Text);
                model.Carbohydrates = float.Parse(carbohydratesValue.Text);
                model.IncludingSugars = float.Parse(includingSugarsValue.Text);
                model.Protein = float.Parse(proteinsValue.Text);
                model.Fat = float.Parse(fatValue.Text);
                model.Fiber = float.Parse(fiberValue.Text);

                if (unitMassValue.Text.Length > 0)
                {
                    int unitMass;
                    if (int.TryParse(unitMassValue.Text, out unitMass))
                    {
                        if(unitMass > 0)
                        {
                            model.OneUnitMass = unitMass;
                        }
                    }
                }

                if(productToEdit== null)
                {
                    GlobalConfig.Connection.CreateProduct(model);
                }
                else if(productToEdit != null)
                {
                    GlobalConfig.Connection.EditProduct(model);
                    //List<MealModel> meals = GlobalConfig.Connection.GetAllMeals();


                    //foreach (MealModel m in meals)
                    //{
                    //    foreach (IngredientModel ing in m.Ingredients)
                    //    {
                    //        if (ing.Product.Id == model.Id)
                    //        {
                    //            m.CalculateNutriens();
                    //            GlobalConfig.Connection.EditMeal(m);
                    //            break;
                    //        }
                    //    }
                    //}

                    callingFormToRefresh.RefreshForm();
                }

                if (callingForm != null)
                {
                    callingForm.CreatedProduct(model);
                }

                this.Close();
            }

        }

    }
}
