namespace CaloryCalculatorWinForms
{
    partial class EditMealForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMealForm));
            this.selectCategoryValue = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.createNewProductButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.caloriesValueLabel = new System.Windows.Forms.Label();
            this.carbohydratesLabel = new System.Windows.Forms.Label();
            this.fiberLabel = new System.Windows.Forms.Label();
            this.fiberValueLabel = new System.Windows.Forms.Label();
            this.carbohydratesValueLabel = new System.Windows.Forms.Label();
            this.proteinsLabel = new System.Windows.Forms.Label();
            this.fatValueLabel = new System.Windows.Forms.Label();
            this.includingSugarsLabel = new System.Windows.Forms.Label();
            this.includingSugarsValueLabel = new System.Windows.Forms.Label();
            this.proteinsValueLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.nutrientsLabel = new System.Windows.Forms.Label();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.selectedIngredientsListBox = new System.Windows.Forms.ListBox();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.unitsTextBox = new System.Windows.Forms.TextBox();
            this.orLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.chooseProductValue = new System.Windows.Forms.ComboBox();
            this.chooseProductLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.mealNameValue = new System.Windows.Forms.TextBox();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.editMealButton = new System.Windows.Forms.Button();
            this.mealSavedLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectCategoryValue
            // 
            this.selectCategoryValue.FormattingEnabled = true;
            this.selectCategoryValue.Location = new System.Drawing.Point(12, 123);
            this.selectCategoryValue.Name = "selectCategoryValue";
            this.selectCategoryValue.Size = new System.Drawing.Size(314, 44);
            this.selectCategoryValue.TabIndex = 41;
            this.selectCategoryValue.SelectedIndexChanged += new System.EventHandler(this.selectCategoryValue_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(287, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(39, 36);
            this.searchButton.TabIndex = 40;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 82);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(269, 42);
            this.searchTextBox.TabIndex = 39;
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
            this.createNewProductButton.Location = new System.Drawing.Point(176, 371);
            this.createNewProductButton.Name = "createNewProductButton";
            this.createNewProductButton.Size = new System.Drawing.Size(103, 41);
            this.createNewProductButton.TabIndex = 38;
            this.createNewProductButton.Text = "Add New";
            this.createNewProductButton.UseVisualStyleBackColor = false;
            this.createNewProductButton.Click += new System.EventHandler(this.createNewProductButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 37;
            this.label1.Text = "Missing product?";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.caloriesValueLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.carbohydratesLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.fiberLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.fiberValueLabel, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.carbohydratesValueLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.proteinsLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.fatValueLabel, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.includingSugarsLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.includingSugarsValueLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.proteinsValueLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.fatLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.caloriesLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 457);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(363, 287);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // caloriesValueLabel
            // 
            this.caloriesValueLabel.AutoSize = true;
            this.caloriesValueLabel.Location = new System.Drawing.Point(257, 1);
            this.caloriesValueLabel.Name = "caloriesValueLabel";
            this.caloriesValueLabel.Size = new System.Drawing.Size(32, 37);
            this.caloriesValueLabel.TabIndex = 3;
            this.caloriesValueLabel.Text = "0";
            // 
            // carbohydratesLabel
            // 
            this.carbohydratesLabel.AutoSize = true;
            this.carbohydratesLabel.Location = new System.Drawing.Point(4, 58);
            this.carbohydratesLabel.Name = "carbohydratesLabel";
            this.carbohydratesLabel.Size = new System.Drawing.Size(229, 37);
            this.carbohydratesLabel.TabIndex = 6;
            this.carbohydratesLabel.Text = "Carbohydrates [g]";
            // 
            // fiberLabel
            // 
            this.fiberLabel.AutoSize = true;
            this.fiberLabel.Location = new System.Drawing.Point(4, 236);
            this.fiberLabel.Name = "fiberLabel";
            this.fiberLabel.Size = new System.Drawing.Size(115, 37);
            this.fiberLabel.TabIndex = 6;
            this.fiberLabel.Text = "Fiber [g]";
            // 
            // fiberValueLabel
            // 
            this.fiberValueLabel.AutoSize = true;
            this.fiberValueLabel.Location = new System.Drawing.Point(257, 236);
            this.fiberValueLabel.Name = "fiberValueLabel";
            this.fiberValueLabel.Size = new System.Drawing.Size(32, 37);
            this.fiberValueLabel.TabIndex = 5;
            this.fiberValueLabel.Text = "0";
            // 
            // carbohydratesValueLabel
            // 
            this.carbohydratesValueLabel.AutoSize = true;
            this.carbohydratesValueLabel.Location = new System.Drawing.Point(257, 58);
            this.carbohydratesValueLabel.Name = "carbohydratesValueLabel";
            this.carbohydratesValueLabel.Size = new System.Drawing.Size(32, 37);
            this.carbohydratesValueLabel.TabIndex = 5;
            this.carbohydratesValueLabel.Text = "0";
            // 
            // proteinsLabel
            // 
            this.proteinsLabel.AutoSize = true;
            this.proteinsLabel.Location = new System.Drawing.Point(4, 140);
            this.proteinsLabel.Name = "proteinsLabel";
            this.proteinsLabel.Size = new System.Drawing.Size(152, 37);
            this.proteinsLabel.TabIndex = 6;
            this.proteinsLabel.Text = "Proteins [g]";
            // 
            // fatValueLabel
            // 
            this.fatValueLabel.AutoSize = true;
            this.fatValueLabel.Location = new System.Drawing.Point(257, 188);
            this.fatValueLabel.Name = "fatValueLabel";
            this.fatValueLabel.Size = new System.Drawing.Size(32, 37);
            this.fatValueLabel.TabIndex = 5;
            this.fatValueLabel.Text = "0";
            // 
            // includingSugarsLabel
            // 
            this.includingSugarsLabel.AutoSize = true;
            this.includingSugarsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.includingSugarsLabel.Location = new System.Drawing.Point(4, 106);
            this.includingSugarsLabel.Name = "includingSugarsLabel";
            this.includingSugarsLabel.Size = new System.Drawing.Size(234, 33);
            this.includingSugarsLabel.TabIndex = 6;
            this.includingSugarsLabel.Text = "   - Including sugars [g]";
            // 
            // includingSugarsValueLabel
            // 
            this.includingSugarsValueLabel.AutoSize = true;
            this.includingSugarsValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.includingSugarsValueLabel.Location = new System.Drawing.Point(257, 106);
            this.includingSugarsValueLabel.Name = "includingSugarsValueLabel";
            this.includingSugarsValueLabel.Size = new System.Drawing.Size(28, 32);
            this.includingSugarsValueLabel.TabIndex = 5;
            this.includingSugarsValueLabel.Text = "0";
            // 
            // proteinsValueLabel
            // 
            this.proteinsValueLabel.AutoSize = true;
            this.proteinsValueLabel.Location = new System.Drawing.Point(257, 140);
            this.proteinsValueLabel.Name = "proteinsValueLabel";
            this.proteinsValueLabel.Size = new System.Drawing.Size(32, 37);
            this.proteinsValueLabel.TabIndex = 5;
            this.proteinsValueLabel.Text = "0";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(4, 188);
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
            // addIngredientButton
            // 
            this.addIngredientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.addIngredientButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addIngredientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.addIngredientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.addIngredientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIngredientButton.ForeColor = System.Drawing.Color.White;
            this.addIngredientButton.Location = new System.Drawing.Point(47, 310);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(215, 55);
            this.addIngredientButton.TabIndex = 35;
            this.addIngredientButton.Text = "Add Ingredient";
            this.addIngredientButton.UseVisualStyleBackColor = false;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // nutrientsLabel
            // 
            this.nutrientsLabel.AutoSize = true;
            this.nutrientsLabel.Location = new System.Drawing.Point(7, 417);
            this.nutrientsLabel.Name = "nutrientsLabel";
            this.nutrientsLabel.Size = new System.Drawing.Size(126, 37);
            this.nutrientsLabel.TabIndex = 34;
            this.nutrientsLabel.Text = "Nutrients";
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeSelectedButton.BackgroundImage")));
            this.removeSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.removeSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.removeSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.removeSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedButton.Location = new System.Drawing.Point(643, 178);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(73, 74);
            this.removeSelectedButton.TabIndex = 33;
            this.removeSelectedButton.UseVisualStyleBackColor = true;
            this.removeSelectedButton.Click += new System.EventHandler(this.removeSelectedButton_Click);
            // 
            // selectedIngredientsListBox
            // 
            this.selectedIngredientsListBox.FormattingEnabled = true;
            this.selectedIngredientsListBox.ItemHeight = 36;
            this.selectedIngredientsListBox.Location = new System.Drawing.Point(343, 82);
            this.selectedIngredientsListBox.Name = "selectedIngredientsListBox";
            this.selectedIngredientsListBox.Size = new System.Drawing.Size(294, 256);
            this.selectedIngredientsListBox.TabIndex = 32;
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Location = new System.Drawing.Point(268, 244);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(74, 37);
            this.unitsLabel.TabIndex = 31;
            this.unitsLabel.Text = "units";
            // 
            // unitsTextBox
            // 
            this.unitsTextBox.Location = new System.Drawing.Point(202, 240);
            this.unitsTextBox.Name = "unitsTextBox";
            this.unitsTextBox.Size = new System.Drawing.Size(60, 42);
            this.unitsTextBox.TabIndex = 30;
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(165, 244);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(42, 37);
            this.orLabel.TabIndex = 29;
            this.orLabel.Text = "or";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(103, 244);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(74, 37);
            this.weightLabel.TabIndex = 28;
            this.weightLabel.Text = "g/ml";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(12, 241);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(85, 42);
            this.weightTextBox.TabIndex = 27;
            // 
            // chooseProductValue
            // 
            this.chooseProductValue.FormattingEnabled = true;
            this.chooseProductValue.Location = new System.Drawing.Point(12, 197);
            this.chooseProductValue.Name = "chooseProductValue";
            this.chooseProductValue.Size = new System.Drawing.Size(314, 44);
            this.chooseProductValue.TabIndex = 26;
            // 
            // chooseProductLabel
            // 
            this.chooseProductLabel.AutoSize = true;
            this.chooseProductLabel.Location = new System.Drawing.Point(7, 164);
            this.chooseProductLabel.Name = "chooseProductLabel";
            this.chooseProductLabel.Size = new System.Drawing.Size(186, 37);
            this.chooseProductLabel.TabIndex = 25;
            this.chooseProductLabel.Text = "Select Product";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.Location = new System.Drawing.Point(279, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(207, 60);
            this.headerLabel.TabIndex = 42;
            this.headerLabel.Text = "Edit Meal";
            // 
            // mealNameValue
            // 
            this.mealNameValue.Location = new System.Drawing.Point(422, 457);
            this.mealNameValue.Name = "mealNameValue";
            this.mealNameValue.Size = new System.Drawing.Size(294, 42);
            this.mealNameValue.TabIndex = 45;
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Location = new System.Drawing.Point(417, 424);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(154, 37);
            this.mealNameLabel.TabIndex = 44;
            this.mealNameLabel.Text = "Meal Name";
            // 
            // editMealButton
            // 
            this.editMealButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.editMealButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editMealButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.editMealButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.editMealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMealButton.ForeColor = System.Drawing.Color.White;
            this.editMealButton.Location = new System.Drawing.Point(422, 498);
            this.editMealButton.Name = "editMealButton";
            this.editMealButton.Size = new System.Drawing.Size(294, 54);
            this.editMealButton.TabIndex = 43;
            this.editMealButton.Text = "Edit Meal";
            this.editMealButton.UseVisualStyleBackColor = false;
            this.editMealButton.Click += new System.EventHandler(this.editMealButton_Click);
            // 
            // mealSavedLabel
            // 
            this.mealSavedLabel.AutoSize = true;
            this.mealSavedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mealSavedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.mealSavedLabel.Location = new System.Drawing.Point(474, 555);
            this.mealSavedLabel.Name = "mealSavedLabel";
            this.mealSavedLabel.Size = new System.Drawing.Size(221, 28);
            this.mealSavedLabel.TabIndex = 46;
            this.mealSavedLabel.Text = "Meal saved successfully!";
            this.mealSavedLabel.Visible = false;
            // 
            // EditMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(762, 761);
            this.Controls.Add(this.mealSavedLabel);
            this.Controls.Add(this.mealNameValue);
            this.Controls.Add(this.mealNameLabel);
            this.Controls.Add(this.editMealButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.selectCategoryValue);
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
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "EditMealForm";
            this.Text = "EditMealForm";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectCategoryValue;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button createNewProductButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label caloriesValueLabel;
        private System.Windows.Forms.Label carbohydratesLabel;
        private System.Windows.Forms.Label fiberLabel;
        private System.Windows.Forms.Label fiberValueLabel;
        private System.Windows.Forms.Label carbohydratesValueLabel;
        private System.Windows.Forms.Label proteinsLabel;
        private System.Windows.Forms.Label fatValueLabel;
        private System.Windows.Forms.Label includingSugarsLabel;
        private System.Windows.Forms.Label includingSugarsValueLabel;
        private System.Windows.Forms.Label proteinsValueLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.Label nutrientsLabel;
        private System.Windows.Forms.Button removeSelectedButton;
        private System.Windows.Forms.ListBox selectedIngredientsListBox;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.TextBox unitsTextBox;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.ComboBox chooseProductValue;
        private System.Windows.Forms.Label chooseProductLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox mealNameValue;
        private System.Windows.Forms.Label mealNameLabel;
        private System.Windows.Forms.Button editMealButton;
        private System.Windows.Forms.Label mealSavedLabel;
    }
}