namespace CaloryCalculatorWinForms
{
    partial class CalculateMealForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateMealForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.chooseProductLabel = new System.Windows.Forms.Label();
            this.chooseProductValue = new System.Windows.Forms.ComboBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.unitsTextBox = new System.Windows.Forms.TextBox();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.selectedIngredientsListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.nutrientsLabel = new System.Windows.Forms.Label();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.caloriesValue = new System.Windows.Forms.Label();
            this.carbohydratesLabel = new System.Windows.Forms.Label();
            this.fiberLabel = new System.Windows.Forms.Label();
            this.fiberValue = new System.Windows.Forms.Label();
            this.carbohydratesValue = new System.Windows.Forms.Label();
            this.proteinsLabel = new System.Windows.Forms.Label();
            this.fatValue = new System.Windows.Forms.Label();
            this.includingSugarsLabel = new System.Windows.Forms.Label();
            this.includingSugarsValue = new System.Windows.Forms.Label();
            this.proteinsValue = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.saveMealButton = new System.Windows.Forms.Button();
            this.consumeMealButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createNewProductButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.mealNameValue = new System.Windows.Forms.TextBox();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.mealSavedLabel = new System.Windows.Forms.Label();
            this.selectCategoryValue = new System.Windows.Forms.ComboBox();
            this.errorLogLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.Location = new System.Drawing.Point(241, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(309, 60);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Calculate Meal";
            // 
            // chooseProductLabel
            // 
            this.chooseProductLabel.AutoSize = true;
            this.chooseProductLabel.Location = new System.Drawing.Point(12, 190);
            this.chooseProductLabel.Name = "chooseProductLabel";
            this.chooseProductLabel.Size = new System.Drawing.Size(186, 37);
            this.chooseProductLabel.TabIndex = 1;
            this.chooseProductLabel.Text = "Select Product";
            // 
            // chooseProductValue
            // 
            this.chooseProductValue.FormattingEnabled = true;
            this.chooseProductValue.Location = new System.Drawing.Point(18, 233);
            this.chooseProductValue.Name = "chooseProductValue";
            this.chooseProductValue.Size = new System.Drawing.Size(314, 44);
            this.chooseProductValue.TabIndex = 2;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(19, 283);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(85, 42);
            this.weightTextBox.TabIndex = 3;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(108, 286);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(33, 37);
            this.weightLabel.TabIndex = 4;
            this.weightLabel.Text = "g";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(156, 286);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(42, 37);
            this.orLabel.TabIndex = 5;
            this.orLabel.Text = "or";
            // 
            // unitsTextBox
            // 
            this.unitsTextBox.Location = new System.Drawing.Point(207, 283);
            this.unitsTextBox.Name = "unitsTextBox";
            this.unitsTextBox.Size = new System.Drawing.Size(60, 42);
            this.unitsTextBox.TabIndex = 6;
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Location = new System.Drawing.Point(273, 286);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(74, 37);
            this.unitsLabel.TabIndex = 7;
            this.unitsLabel.Text = "units";
            // 
            // selectedIngredientsListBox
            // 
            this.selectedIngredientsListBox.FormattingEnabled = true;
            this.selectedIngredientsListBox.ItemHeight = 36;
            this.selectedIngredientsListBox.Location = new System.Drawing.Point(389, 91);
            this.selectedIngredientsListBox.Name = "selectedIngredientsListBox";
            this.selectedIngredientsListBox.Size = new System.Drawing.Size(350, 328);
            this.selectedIngredientsListBox.TabIndex = 9;
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeSelectedButton.BackgroundImage")));
            this.removeSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.removeSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.removeSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.removeSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedButton.Location = new System.Drawing.Point(749, 203);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(73, 74);
            this.removeSelectedButton.TabIndex = 10;
            this.removeSelectedButton.UseVisualStyleBackColor = true;
            this.removeSelectedButton.Click += new System.EventHandler(this.removeSelectedButton_Click);
            // 
            // nutrientsLabel
            // 
            this.nutrientsLabel.AutoSize = true;
            this.nutrientsLabel.Location = new System.Drawing.Point(21, 438);
            this.nutrientsLabel.Name = "nutrientsLabel";
            this.nutrientsLabel.Size = new System.Drawing.Size(290, 37);
            this.nutrientsLabel.TabIndex = 12;
            this.nutrientsLabel.Text = "Macronutrients in meal";
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.addIngredientButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addIngredientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.addIngredientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.addIngredientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIngredientButton.ForeColor = System.Drawing.Color.White;
            this.addIngredientButton.Location = new System.Drawing.Point(52, 331);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(215, 47);
            this.addIngredientButton.TabIndex = 13;
            this.addIngredientButton.Text = "Add Ingredient";
            this.addIngredientButton.UseVisualStyleBackColor = false;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.caloriesValue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.carbohydratesLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.fiberLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.fiberValue, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.carbohydratesValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.proteinsLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.fatValue, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.includingSugarsLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.includingSugarsValue, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.proteinsValue, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.fatLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.caloriesLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 478);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(347, 273);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // caloriesValue
            // 
            this.caloriesValue.AutoSize = true;
            this.caloriesValue.Location = new System.Drawing.Point(245, 1);
            this.caloriesValue.Name = "caloriesValue";
            this.caloriesValue.Size = new System.Drawing.Size(32, 37);
            this.caloriesValue.TabIndex = 3;
            this.caloriesValue.Text = "0";
            // 
            // carbohydratesLabel
            // 
            this.carbohydratesLabel.AutoSize = true;
            this.carbohydratesLabel.Location = new System.Drawing.Point(4, 55);
            this.carbohydratesLabel.Name = "carbohydratesLabel";
            this.carbohydratesLabel.Size = new System.Drawing.Size(229, 37);
            this.carbohydratesLabel.TabIndex = 6;
            this.carbohydratesLabel.Text = "Carbohydrates [g]";
            // 
            // fiberLabel
            // 
            this.fiberLabel.AutoSize = true;
            this.fiberLabel.Location = new System.Drawing.Point(4, 225);
            this.fiberLabel.Name = "fiberLabel";
            this.fiberLabel.Size = new System.Drawing.Size(115, 37);
            this.fiberLabel.TabIndex = 6;
            this.fiberLabel.Text = "Fiber [g]";
            // 
            // fiberValue
            // 
            this.fiberValue.AutoSize = true;
            this.fiberValue.Location = new System.Drawing.Point(245, 225);
            this.fiberValue.Name = "fiberValue";
            this.fiberValue.Size = new System.Drawing.Size(32, 37);
            this.fiberValue.TabIndex = 5;
            this.fiberValue.Text = "0";
            // 
            // carbohydratesValue
            // 
            this.carbohydratesValue.AutoSize = true;
            this.carbohydratesValue.Location = new System.Drawing.Point(245, 55);
            this.carbohydratesValue.Name = "carbohydratesValue";
            this.carbohydratesValue.Size = new System.Drawing.Size(32, 37);
            this.carbohydratesValue.TabIndex = 5;
            this.carbohydratesValue.Text = "0";
            // 
            // proteinsLabel
            // 
            this.proteinsLabel.AutoSize = true;
            this.proteinsLabel.Location = new System.Drawing.Point(4, 133);
            this.proteinsLabel.Name = "proteinsLabel";
            this.proteinsLabel.Size = new System.Drawing.Size(152, 37);
            this.proteinsLabel.TabIndex = 6;
            this.proteinsLabel.Text = "Proteins [g]";
            // 
            // fatValue
            // 
            this.fatValue.AutoSize = true;
            this.fatValue.Location = new System.Drawing.Point(245, 179);
            this.fatValue.Name = "fatValue";
            this.fatValue.Size = new System.Drawing.Size(32, 37);
            this.fatValue.TabIndex = 5;
            this.fatValue.Text = "0";
            // 
            // includingSugarsLabel
            // 
            this.includingSugarsLabel.AutoSize = true;
            this.includingSugarsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.includingSugarsLabel.Location = new System.Drawing.Point(4, 101);
            this.includingSugarsLabel.Name = "includingSugarsLabel";
            this.includingSugarsLabel.Size = new System.Drawing.Size(234, 31);
            this.includingSugarsLabel.TabIndex = 6;
            this.includingSugarsLabel.Text = "   - Including sugars [g]";
            // 
            // includingSugarsValue
            // 
            this.includingSugarsValue.AutoSize = true;
            this.includingSugarsValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.includingSugarsValue.Location = new System.Drawing.Point(245, 101);
            this.includingSugarsValue.Name = "includingSugarsValue";
            this.includingSugarsValue.Size = new System.Drawing.Size(28, 31);
            this.includingSugarsValue.TabIndex = 5;
            this.includingSugarsValue.Text = "0";
            // 
            // proteinsValue
            // 
            this.proteinsValue.AutoSize = true;
            this.proteinsValue.Location = new System.Drawing.Point(245, 133);
            this.proteinsValue.Name = "proteinsValue";
            this.proteinsValue.Size = new System.Drawing.Size(32, 37);
            this.proteinsValue.TabIndex = 5;
            this.proteinsValue.Text = "0";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(4, 179);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(91, 37);
            this.fatLabel.TabIndex = 6;
            this.fatLabel.Text = "Fat [g]";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.caloriesLabel.Location = new System.Drawing.Point(4, 1);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(225, 46);
            this.caloriesLabel.TabIndex = 4;
            this.caloriesLabel.Text = "Calories [kcal]";
            // 
            // saveMealButton
            // 
            this.saveMealButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.saveMealButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveMealButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.saveMealButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.saveMealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveMealButton.ForeColor = System.Drawing.Color.White;
            this.saveMealButton.Location = new System.Drawing.Point(19, 108);
            this.saveMealButton.Name = "saveMealButton";
            this.saveMealButton.Size = new System.Drawing.Size(315, 52);
            this.saveMealButton.TabIndex = 15;
            this.saveMealButton.Text = "Save Meal";
            this.saveMealButton.UseVisualStyleBackColor = false;
            this.saveMealButton.Click += new System.EventHandler(this.saveMealButton_Click);
            // 
            // consumeMealButton
            // 
            this.consumeMealButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.consumeMealButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.consumeMealButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.consumeMealButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.consumeMealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consumeMealButton.ForeColor = System.Drawing.Color.White;
            this.consumeMealButton.Location = new System.Drawing.Point(19, 194);
            this.consumeMealButton.Name = "consumeMealButton";
            this.consumeMealButton.Size = new System.Drawing.Size(315, 62);
            this.consumeMealButton.TabIndex = 16;
            this.consumeMealButton.Text = "Save and Consume!";
            this.consumeMealButton.UseVisualStyleBackColor = false;
            this.consumeMealButton.Click += new System.EventHandler(this.consumeMealButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Missing product?";
            // 
            // createNewProductButton
            // 
            this.createNewProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.createNewProductButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createNewProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.createNewProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.createNewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewProductButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewProductButton.ForeColor = System.Drawing.Color.White;
            this.createNewProductButton.Location = new System.Drawing.Point(183, 384);
            this.createNewProductButton.Name = "createNewProductButton";
            this.createNewProductButton.Size = new System.Drawing.Size(103, 43);
            this.createNewProductButton.TabIndex = 18;
            this.createNewProductButton.Text = "Add New";
            this.createNewProductButton.UseVisualStyleBackColor = false;
            this.createNewProductButton.Click += new System.EventHandler(this.createNewProductButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(17, 91);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(269, 42);
            this.searchTextBox.TabIndex = 19;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(292, 91);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(39, 36);
            this.searchButton.TabIndex = 20;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mealNameValue
            // 
            this.mealNameValue.Location = new System.Drawing.Point(19, 60);
            this.mealNameValue.Name = "mealNameValue";
            this.mealNameValue.Size = new System.Drawing.Size(315, 42);
            this.mealNameValue.TabIndex = 22;
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.75F);
            this.mealNameLabel.Location = new System.Drawing.Point(13, 17);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(132, 31);
            this.mealNameLabel.TabIndex = 21;
            this.mealNameLabel.Text = "Meal Name";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mealSavedLabel);
            this.panel1.Controls.Add(this.mealNameValue);
            this.panel1.Controls.Add(this.mealNameLabel);
            this.panel1.Controls.Add(this.saveMealButton);
            this.panel1.Controls.Add(this.consumeMealButton);
            this.panel1.Location = new System.Drawing.Point(389, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 275);
            this.panel1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(141, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "(if more than 1 product)";
            // 
            // mealSavedLabel
            // 
            this.mealSavedLabel.AutoSize = true;
            this.mealSavedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mealSavedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.mealSavedLabel.Location = new System.Drawing.Point(72, 163);
            this.mealSavedLabel.Name = "mealSavedLabel";
            this.mealSavedLabel.Size = new System.Drawing.Size(221, 28);
            this.mealSavedLabel.TabIndex = 23;
            this.mealSavedLabel.Text = "Meal saved successfully!";
            this.mealSavedLabel.Visible = false;
            // 
            // selectCategoryValue
            // 
            this.selectCategoryValue.FormattingEnabled = true;
            this.selectCategoryValue.Location = new System.Drawing.Point(17, 139);
            this.selectCategoryValue.Name = "selectCategoryValue";
            this.selectCategoryValue.Size = new System.Drawing.Size(314, 44);
            this.selectCategoryValue.TabIndex = 24;
            this.selectCategoryValue.SelectedIndexChanged += new System.EventHandler(this.selectCategoryValue_SelectedIndexChanged);
            // 
            // errorLogLabel
            // 
            this.errorLogLabel.AutoSize = true;
            this.errorLogLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorLogLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLogLabel.Location = new System.Drawing.Point(384, 368);
            this.errorLogLabel.Name = "errorLogLabel";
            this.errorLogLabel.Size = new System.Drawing.Size(0, 28);
            this.errorLogLabel.TabIndex = 25;
            // 
            // CalculateMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(834, 763);
            this.Controls.Add(this.errorLogLabel);
            this.Controls.Add(this.selectCategoryValue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.createNewProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.nutrientsLabel);
            this.Controls.Add(this.removeSelectedButton);
            this.Controls.Add(this.selectedIngredientsListBox);
            this.Controls.Add(this.unitsLabel);
            this.Controls.Add(this.unitsTextBox);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.chooseProductValue);
            this.Controls.Add(this.chooseProductLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CalculateMealForm";
            this.Text = "Calculate Meal";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label chooseProductLabel;
        private System.Windows.Forms.ComboBox chooseProductValue;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.TextBox unitsTextBox;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.ListBox selectedIngredientsListBox;
        private System.Windows.Forms.Button removeSelectedButton;
        private System.Windows.Forms.Label nutrientsLabel;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label caloriesValue;
        private System.Windows.Forms.Label carbohydratesLabel;
        private System.Windows.Forms.Label fiberLabel;
        private System.Windows.Forms.Label fiberValue;
        private System.Windows.Forms.Label carbohydratesValue;
        private System.Windows.Forms.Label proteinsLabel;
        private System.Windows.Forms.Label fatValue;
        private System.Windows.Forms.Label includingSugarsLabel;
        private System.Windows.Forms.Label includingSugarsValue;
        private System.Windows.Forms.Label proteinsValue;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Button saveMealButton;
        private System.Windows.Forms.Button consumeMealButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createNewProductButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox mealNameValue;
        private System.Windows.Forms.Label mealNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mealSavedLabel;
        private System.Windows.Forms.ComboBox selectCategoryValue;
        private System.Windows.Forms.Label errorLogLabel;
        private System.Windows.Forms.Label label2;
    }
}