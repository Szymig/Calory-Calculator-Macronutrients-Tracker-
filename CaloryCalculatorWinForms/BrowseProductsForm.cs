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
    public partial class BrowseProductsForm : Form, IFormRefresher
    {
        List<ProductModel> avaliableProducts = GlobalConfig.Connection.GetAllProducts();
        List<ProductModel> displayedProducts = new List<ProductModel>();
        List<Category> categories = new List<Category>();

        ProductModel activeProduct = new ProductModel();
        ProductModel productAfterRefresh = new ProductModel();

        IFormRefresher callingForm;

        public BrowseProductsForm(IFormRefresher caller)
        {
            InitializeComponent();
            callingForm = caller;
            displayedProducts = avaliableProducts;
            WireUpLists();
            PopulateCategoryComboBox();
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

        private void WireUpLists()
        {
            productsListBox.DataSource = null;
            productsListBox.DataSource = displayedProducts;
            productsListBox.DisplayMember = "Name";
        }

        private void ResetDisplayedMacro()
        {
            caloriesValueLabel.Text = "0";
            carbohydratesValueLabel.Text = "0";
            includingSugarsValueLabel.Text = "0";
            proteinsValueLabel.Text = "0";
            fatValueLabel.Text = "0";
            fiberValueLabel.Text = "0";
            oneUnitMassValueLabel.Text = "-";
        }

        private void SearchForProduct()
        {
            string searching = searchTextBox.Text;
            Category selectedCategory = (Category)selectCategoryValue.SelectedItem;
            displayedProducts = new List<ProductModel>();
            List<ProductModel> foundProducts = new List<ProductModel>();

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
                    if (p.Name.IndexOf(searching) != -1)
                    {
                        if (selectedCategory.ProdCategory == p.Category)
                        {
                            displayedProducts.Add(p);
                        }
                    }
                }
            }

            WireUpLists();
            addedToConsumptionLabel.Hide();
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            if(activeProduct != null)
            {
                productAfterRefresh = activeProduct;
                AddNewProductForm editForm = new AddNewProductForm(this, activeProduct);
                editForm.Show();
            }
            else
            {
                MessageBox.Show("No product selected!", "Error editing product.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeProduct = ((ProductModel)productsListBox.SelectedItem);

            if(activeProduct != null)
            {
                selectedProductNameLabel.Text = activeProduct.Name;

                caloriesValueLabel.Text = activeProduct.Calories.ToString();
                carbohydratesValueLabel.Text = activeProduct.Carbohydrates.ToString();
                includingSugarsValueLabel.Text = activeProduct.IncludingSugars.ToString();
                proteinsValueLabel.Text = activeProduct.Protein.ToString();
                fatValueLabel.Text = activeProduct.Fat.ToString();
                fiberValueLabel.Text = activeProduct.Fiber.ToString();

                if (activeProduct.OneUnitMass > 0)
                {
                    oneUnitMassValueLabel.Text = activeProduct.OneUnitMass.ToString();
                }
                else
                {
                    oneUnitMassValueLabel.Text = "-";
                }
            }
            else
            {
                ResetDisplayedMacro();
            }

            addedToConsumptionLabel.Hide();
        }


        private bool ConsumeValidation()
        {
            bool output = true;

            string errorMessage = "";
            float mass = 0;
            int units = 0;

            if (!float.TryParse(weightTextBox.Text, out mass) && weightTextBox.Text.Length > 0)
            {
                errorMessage += "Incorrect Mass!\n";
                output = false;
            }

            if (!int.TryParse(unitsTextBox.Text, out units) && unitsTextBox.Text.Length > 0)
            {
                errorMessage += "Incorrect Units!\n";
                output = false;
            }

            if ((weightTextBox.Text.Length == 0 && unitsTextBox.Text.Length == 0) || (mass == 0 && units == 0))
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

        private void consumeButton_Click(object sender, EventArgs e)
        {
            DailyEntryModel dailyEntry = new DailyEntryModel();
            dailyEntry.Product = activeProduct;

            if(activeProduct != null)
            {
                if (ConsumeValidation())
                {
                    float mass = 0;
                    int units = 0;

                    if (weightTextBox.Text.Length > 0)
                    {
                        mass = float.Parse(weightTextBox.Text);
                    }
                    if (unitsTextBox.Text.Length > 0)
                    {
                        units = int.Parse(unitsTextBox.Text);
                    }

                    if (mass > 0)
                    {
                        dailyEntry.Mass = mass;
                        dailyEntry.Units = 0;
                    }
                    else if (units > 0 && dailyEntry.Product.OneUnitMass > 0)
                    {
                        dailyEntry.Units = int.Parse(unitsTextBox.Text);
                        dailyEntry.Mass = dailyEntry.Product.OneUnitMass * dailyEntry.Units;
                    }
                    else if (units > 0 && dailyEntry.Product.OneUnitMass <= 0)
                    {
                        MessageBox.Show("Selected product does not have one unit mass specified.\nPlease enter mass. ", "Inalid input data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    GlobalConfig.Connection.CreateDailyEntry(dailyEntry);

                    addedToConsumptionLabel.Show();

                    weightTextBox.Text = "";
                    unitsTextBox.Text = "";
                    productsListBox.SelectedItem = null;
                    selectedProductNameLabel.Text = "";

                    callingForm.RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("Please select a product.", "Product not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        bool CheckIfCanDelete()
        {
            bool output = true;
            string errorMessage = "";
            string inMeals = "";

            if (activeProduct == null)
            {
                MessageBox.Show("Please select a product!", "Product not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            List<MealModel> meals = GlobalConfig.Connection.GetAllMeals();
            List<DailyEntryModel> dailyEntries = GlobalConfig.Connection.GetAllDailyEntries();

            foreach (MealModel m in meals)
            {
                foreach (IngredientModel ing in m.Ingredients)
                {
                    if(ing.Product.Id == activeProduct.Id)
                    {
                        inMeals += m.Name + "\n";
                        output = false;
                        break;
                    }
                }
            }

            foreach (DailyEntryModel dE in dailyEntries)
            {
                if(dE.Product != null)
                {
                    if (dE.Product.Id == activeProduct.Id)
                    {
                        errorMessage += "You can not delete product you consumed today!\nEdit your Daily Consumption or move to a new day.";
                        output = false;
                        break;
                    }
                }
            }

            if(inMeals.Length > 0)
            {
                if(errorMessage.Length > 0)
                {
                    errorMessage += "\n\n";
                }

                errorMessage += "Product is an ingredient of following meals:\n";
                errorMessage += inMeals;
                errorMessage += "Please edit or delete above meals to delete the product.";
            }

            if(output == false)
            {
                MessageBox.Show(errorMessage, "Can not delete product.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return output;
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (activeProduct != null)
            {
                if (CheckIfCanDelete())
                {
                    var confirmDelete = MessageBox.Show("Are you sure you want to delete product:\n" + activeProduct.Name + "?", "Delete product.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(confirmDelete == DialogResult.Yes)
                    {
                        GlobalConfig.Connection.DeleteProduct(activeProduct);
                        avaliableProducts.Remove(activeProduct);
                        displayedProducts.Remove(activeProduct);

                        WireUpLists();
                        ResetDisplayedMacro();
                    }
                    else if(confirmDelete == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("No product selected!", "Error deleting product.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshForm()
        {
            displayedProducts = avaliableProducts;
            WireUpLists();

            productsListBox.SelectedIndex = displayedProducts.IndexOf(productAfterRefresh);
        }

        private void selectCategoryValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchForProduct();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchForProduct();
        }

        private void selectCategoryValue_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }
    }
}
