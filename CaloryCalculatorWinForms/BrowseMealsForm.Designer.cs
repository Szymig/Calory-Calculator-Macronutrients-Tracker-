namespace CaloryCalculatorWinForms
{
    partial class BrowseMealsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseMealsForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.mealNameValue = new System.Windows.Forms.TextBox();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.mealsListBox = new System.Windows.Forms.ListBox();
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.ingredientsLabel = new System.Windows.Forms.Label();
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
            this.deleteMealButton = new System.Windows.Forms.Button();
            this.editMealButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addedToConsumptionLabel = new System.Windows.Forms.Label();
            this.consumeButton = new System.Windows.Forms.Button();
            this.selectedMealNameLabel = new System.Windows.Forms.Label();
            this.consumptionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.Location = new System.Drawing.Point(227, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(292, 60);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Browse Meals";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(287, 114);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(39, 36);
            this.searchButton.TabIndex = 22;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mealNameValue
            // 
            this.mealNameValue.Location = new System.Drawing.Point(12, 111);
            this.mealNameValue.Name = "mealNameValue";
            this.mealNameValue.Size = new System.Drawing.Size(269, 42);
            this.mealNameValue.TabIndex = 21;
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Location = new System.Drawing.Point(12, 71);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(154, 37);
            this.mealNameLabel.TabIndex = 23;
            this.mealNameLabel.Text = "Meal Name";
            // 
            // mealsListBox
            // 
            this.mealsListBox.FormattingEnabled = true;
            this.mealsListBox.ItemHeight = 36;
            this.mealsListBox.Location = new System.Drawing.Point(12, 175);
            this.mealsListBox.Name = "mealsListBox";
            this.mealsListBox.Size = new System.Drawing.Size(314, 256);
            this.mealsListBox.TabIndex = 24;
            this.mealsListBox.SelectedIndexChanged += new System.EventHandler(this.mealsListBox_SelectedIndexChanged);
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.ItemHeight = 36;
            this.ingredientsListBox.Location = new System.Drawing.Point(12, 515);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(314, 184);
            this.ingredientsListBox.TabIndex = 25;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Location = new System.Drawing.Point(12, 472);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(150, 37);
            this.ingredientsLabel.TabIndex = 26;
            this.ingredientsLabel.Text = "Ingredients";
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(348, 242);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(356, 267);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // caloriesValueLabel
            // 
            this.caloriesValueLabel.AutoSize = true;
            this.caloriesValueLabel.Location = new System.Drawing.Point(252, 1);
            this.caloriesValueLabel.Name = "caloriesValueLabel";
            this.caloriesValueLabel.Size = new System.Drawing.Size(32, 37);
            this.caloriesValueLabel.TabIndex = 3;
            this.caloriesValueLabel.Text = "0";
            // 
            // carbohydratesLabel
            // 
            this.carbohydratesLabel.AutoSize = true;
            this.carbohydratesLabel.Location = new System.Drawing.Point(4, 54);
            this.carbohydratesLabel.Name = "carbohydratesLabel";
            this.carbohydratesLabel.Size = new System.Drawing.Size(229, 37);
            this.carbohydratesLabel.TabIndex = 6;
            this.carbohydratesLabel.Text = "Carbohydrates [g]";
            // 
            // fiberLabel
            // 
            this.fiberLabel.AutoSize = true;
            this.fiberLabel.Location = new System.Drawing.Point(4, 221);
            this.fiberLabel.Name = "fiberLabel";
            this.fiberLabel.Size = new System.Drawing.Size(115, 37);
            this.fiberLabel.TabIndex = 6;
            this.fiberLabel.Text = "Fiber [g]";
            // 
            // fiberValueLabel
            // 
            this.fiberValueLabel.AutoSize = true;
            this.fiberValueLabel.Location = new System.Drawing.Point(252, 221);
            this.fiberValueLabel.Name = "fiberValueLabel";
            this.fiberValueLabel.Size = new System.Drawing.Size(32, 37);
            this.fiberValueLabel.TabIndex = 5;
            this.fiberValueLabel.Text = "0";
            // 
            // carbohydratesValueLabel
            // 
            this.carbohydratesValueLabel.AutoSize = true;
            this.carbohydratesValueLabel.Location = new System.Drawing.Point(252, 54);
            this.carbohydratesValueLabel.Name = "carbohydratesValueLabel";
            this.carbohydratesValueLabel.Size = new System.Drawing.Size(32, 37);
            this.carbohydratesValueLabel.TabIndex = 5;
            this.carbohydratesValueLabel.Text = "0";
            // 
            // proteinsLabel
            // 
            this.proteinsLabel.AutoSize = true;
            this.proteinsLabel.Location = new System.Drawing.Point(4, 131);
            this.proteinsLabel.Name = "proteinsLabel";
            this.proteinsLabel.Size = new System.Drawing.Size(152, 37);
            this.proteinsLabel.TabIndex = 6;
            this.proteinsLabel.Text = "Proteins [g]";
            // 
            // fatValueLabel
            // 
            this.fatValueLabel.AutoSize = true;
            this.fatValueLabel.Location = new System.Drawing.Point(252, 176);
            this.fatValueLabel.Name = "fatValueLabel";
            this.fatValueLabel.Size = new System.Drawing.Size(32, 37);
            this.fatValueLabel.TabIndex = 5;
            this.fatValueLabel.Text = "0";
            // 
            // includingSugarsLabel
            // 
            this.includingSugarsLabel.AutoSize = true;
            this.includingSugarsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.includingSugarsLabel.Location = new System.Drawing.Point(4, 99);
            this.includingSugarsLabel.Name = "includingSugarsLabel";
            this.includingSugarsLabel.Size = new System.Drawing.Size(234, 31);
            this.includingSugarsLabel.TabIndex = 6;
            this.includingSugarsLabel.Text = "   - Including sugars [g]";
            // 
            // includingSugarsValueLabel
            // 
            this.includingSugarsValueLabel.AutoSize = true;
            this.includingSugarsValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.includingSugarsValueLabel.Location = new System.Drawing.Point(252, 99);
            this.includingSugarsValueLabel.Name = "includingSugarsValueLabel";
            this.includingSugarsValueLabel.Size = new System.Drawing.Size(28, 31);
            this.includingSugarsValueLabel.TabIndex = 5;
            this.includingSugarsValueLabel.Text = "0";
            // 
            // proteinsValueLabel
            // 
            this.proteinsValueLabel.AutoSize = true;
            this.proteinsValueLabel.Location = new System.Drawing.Point(252, 131);
            this.proteinsValueLabel.Name = "proteinsValueLabel";
            this.proteinsValueLabel.Size = new System.Drawing.Size(32, 37);
            this.proteinsValueLabel.TabIndex = 5;
            this.proteinsValueLabel.Text = "0";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(4, 176);
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
            // deleteMealButton
            // 
            this.deleteMealButton.BackColor = System.Drawing.Color.Red;
            this.deleteMealButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteMealButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteMealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMealButton.ForeColor = System.Drawing.Color.White;
            this.deleteMealButton.Location = new System.Drawing.Point(348, 175);
            this.deleteMealButton.Name = "deleteMealButton";
            this.deleteMealButton.Size = new System.Drawing.Size(356, 49);
            this.deleteMealButton.TabIndex = 29;
            this.deleteMealButton.Text = "Delete Meal";
            this.deleteMealButton.UseVisualStyleBackColor = false;
            this.deleteMealButton.Click += new System.EventHandler(this.deleteMealButton_Click);
            // 
            // editMealButton
            // 
            this.editMealButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.editMealButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.editMealButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.editMealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMealButton.ForeColor = System.Drawing.Color.White;
            this.editMealButton.Location = new System.Drawing.Point(348, 104);
            this.editMealButton.Name = "editMealButton";
            this.editMealButton.Size = new System.Drawing.Size(356, 49);
            this.editMealButton.TabIndex = 28;
            this.editMealButton.Text = "Edit Meal";
            this.editMealButton.UseVisualStyleBackColor = false;
            this.editMealButton.Click += new System.EventHandler(this.editMealButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addedToConsumptionLabel);
            this.panel1.Controls.Add(this.consumeButton);
            this.panel1.Controls.Add(this.selectedMealNameLabel);
            this.panel1.Controls.Add(this.consumptionLabel);
            this.panel1.Location = new System.Drawing.Point(348, 515);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 184);
            this.panel1.TabIndex = 31;
            // 
            // addedToConsumptionLabel
            // 
            this.addedToConsumptionLabel.AutoSize = true;
            this.addedToConsumptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addedToConsumptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.addedToConsumptionLabel.Location = new System.Drawing.Point(20, 149);
            this.addedToConsumptionLabel.Name = "addedToConsumptionLabel";
            this.addedToConsumptionLabel.Size = new System.Drawing.Size(332, 28);
            this.addedToConsumptionLabel.TabIndex = 38;
            this.addedToConsumptionLabel.Text = "Meal Added to Daily Consumption!";
            this.addedToConsumptionLabel.Visible = false;
            // 
            // consumeButton
            // 
            this.consumeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.consumeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.consumeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.consumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consumeButton.ForeColor = System.Drawing.Color.White;
            this.consumeButton.Location = new System.Drawing.Point(13, 98);
            this.consumeButton.Name = "consumeButton";
            this.consumeButton.Size = new System.Drawing.Size(284, 48);
            this.consumeButton.TabIndex = 31;
            this.consumeButton.Text = "Consume!";
            this.consumeButton.UseVisualStyleBackColor = false;
            this.consumeButton.Click += new System.EventHandler(this.consumeButton_Click);
            // 
            // selectedMealNameLabel
            // 
            this.selectedMealNameLabel.AutoSize = true;
            this.selectedMealNameLabel.Location = new System.Drawing.Point(7, 56);
            this.selectedMealNameLabel.Name = "selectedMealNameLabel";
            this.selectedMealNameLabel.Size = new System.Drawing.Size(183, 37);
            this.selectedMealNameLabel.TabIndex = 37;
            this.selectedMealNameLabel.Text = "Example Meal";
            // 
            // consumptionLabel
            // 
            this.consumptionLabel.AutoSize = true;
            this.consumptionLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.consumptionLabel.Location = new System.Drawing.Point(7, 11);
            this.consumptionLabel.Name = "consumptionLabel";
            this.consumptionLabel.Size = new System.Drawing.Size(332, 37);
            this.consumptionLabel.TabIndex = 31;
            this.consumptionLabel.Text = "Add to Daily Consumption";
            // 
            // BrowseMealsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(722, 725);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteMealButton);
            this.Controls.Add(this.editMealButton);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ingredientsLabel);
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.mealsListBox);
            this.Controls.Add(this.mealNameLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.mealNameValue);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BrowseMealsForm";
            this.Text = "Browse Meals";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox mealNameValue;
        private System.Windows.Forms.Label mealNameLabel;
        private System.Windows.Forms.ListBox mealsListBox;
        private System.Windows.Forms.ListBox ingredientsListBox;
        private System.Windows.Forms.Label ingredientsLabel;
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
        private System.Windows.Forms.Button deleteMealButton;
        private System.Windows.Forms.Button editMealButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addedToConsumptionLabel;
        private System.Windows.Forms.Button consumeButton;
        private System.Windows.Forms.Label selectedMealNameLabel;
        private System.Windows.Forms.Label consumptionLabel;
    }
}