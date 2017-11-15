using System.Windows.Forms;

namespace CaloryCalculatorWinForms
{
    partial class BrowseProductsForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.selectCategoryLabel = new System.Windows.Forms.Label();
            this.selectCategoryValue = new System.Windows.Forms.ComboBox();
            this.chooseProductLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.editProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
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
            this.oneUnitMassLabel = new System.Windows.Forms.Label();
            this.oneUnitMassValueLabel = new System.Windows.Forms.Label();
            this.caloriesValueLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addedToConsumptionLabel = new System.Windows.Forms.Label();
            this.consumeButton = new System.Windows.Forms.Button();
            this.selectedProductNameLabel = new System.Windows.Forms.Label();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.unitsTextBox = new System.Windows.Forms.TextBox();
            this.orLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.consumptionLabel = new System.Windows.Forms.Label();
            this.macronutrientsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.Location = new System.Drawing.Point(212, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(348, 60);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Browse Products";
            // 
            // selectCategoryLabel
            // 
            this.selectCategoryLabel.AutoSize = true;
            this.selectCategoryLabel.Location = new System.Drawing.Point(12, 165);
            this.selectCategoryLabel.Name = "selectCategoryLabel";
            this.selectCategoryLabel.Size = new System.Drawing.Size(125, 37);
            this.selectCategoryLabel.TabIndex = 3;
            this.selectCategoryLabel.Text = "Category";
            // 
            // selectCategoryValue
            // 
            this.selectCategoryValue.BackColor = System.Drawing.Color.White;
            this.selectCategoryValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCategoryValue.FormattingEnabled = true;
            this.selectCategoryValue.Location = new System.Drawing.Point(17, 205);
            this.selectCategoryValue.Name = "selectCategoryValue";
            this.selectCategoryValue.Size = new System.Drawing.Size(314, 44);
            this.selectCategoryValue.TabIndex = 4;
            this.selectCategoryValue.SelectedIndexChanged += new System.EventHandler(this.selectCategoryValue_SelectedIndexChanged);
            this.selectCategoryValue.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.selectCategoryValue_MouseWheel);
            // 
            // chooseProductLabel
            // 
            this.chooseProductLabel.AutoSize = true;
            this.chooseProductLabel.Location = new System.Drawing.Point(12, 82);
            this.chooseProductLabel.Name = "chooseProductLabel";
            this.chooseProductLabel.Size = new System.Drawing.Size(187, 37);
            this.chooseProductLabel.TabIndex = 5;
            this.chooseProductLabel.Text = "Product Name";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(17, 120);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(314, 42);
            this.searchTextBox.TabIndex = 22;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 36;
            this.productsListBox.Location = new System.Drawing.Point(17, 272);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(314, 256);
            this.productsListBox.TabIndex = 24;
            this.productsListBox.SelectedIndexChanged += new System.EventHandler(this.productsListBox_SelectedIndexChanged);
            // 
            // editProductButton
            // 
            this.editProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.editProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.editProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.editProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProductButton.ForeColor = System.Drawing.Color.White;
            this.editProductButton.Location = new System.Drawing.Point(17, 534);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(314, 57);
            this.editProductButton.TabIndex = 25;
            this.editProductButton.Text = "Edit Product";
            this.editProductButton.UseVisualStyleBackColor = false;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.Color.Red;
            this.deleteProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductButton.ForeColor = System.Drawing.Color.White;
            this.deleteProductButton.Location = new System.Drawing.Point(17, 605);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(314, 53);
            this.deleteProductButton.TabIndex = 26;
            this.deleteProductButton.Text = "Delete Product";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
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
            this.tableLayoutPanel2.Controls.Add(this.oneUnitMassLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.oneUnitMassValueLabel, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.caloriesValueLabel, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(363, 122);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(356, 277);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // carbohydratesLabel
            // 
            this.carbohydratesLabel.AutoSize = true;
            this.carbohydratesLabel.Location = new System.Drawing.Point(4, 55);
            this.carbohydratesLabel.Name = "carbohydratesLabel";
            this.carbohydratesLabel.Size = new System.Drawing.Size(229, 36);
            this.carbohydratesLabel.TabIndex = 6;
            this.carbohydratesLabel.Text = "Carbohydrates [g]";
            // 
            // fiberLabel
            // 
            this.fiberLabel.AutoSize = true;
            this.fiberLabel.Location = new System.Drawing.Point(4, 200);
            this.fiberLabel.Name = "fiberLabel";
            this.fiberLabel.Size = new System.Drawing.Size(115, 36);
            this.fiberLabel.TabIndex = 6;
            this.fiberLabel.Text = "Fiber [g]";
            // 
            // fiberValueLabel
            // 
            this.fiberValueLabel.AutoSize = true;
            this.fiberValueLabel.Location = new System.Drawing.Point(252, 200);
            this.fiberValueLabel.Name = "fiberValueLabel";
            this.fiberValueLabel.Size = new System.Drawing.Size(32, 36);
            this.fiberValueLabel.TabIndex = 5;
            this.fiberValueLabel.Text = "0";
            // 
            // carbohydratesValueLabel
            // 
            this.carbohydratesValueLabel.AutoSize = true;
            this.carbohydratesValueLabel.Location = new System.Drawing.Point(252, 55);
            this.carbohydratesValueLabel.Name = "carbohydratesValueLabel";
            this.carbohydratesValueLabel.Size = new System.Drawing.Size(32, 36);
            this.carbohydratesValueLabel.TabIndex = 5;
            this.carbohydratesValueLabel.Text = "0";
            // 
            // proteinsLabel
            // 
            this.proteinsLabel.AutoSize = true;
            this.proteinsLabel.Location = new System.Drawing.Point(4, 126);
            this.proteinsLabel.Name = "proteinsLabel";
            this.proteinsLabel.Size = new System.Drawing.Size(152, 36);
            this.proteinsLabel.TabIndex = 6;
            this.proteinsLabel.Text = "Proteins [g]";
            // 
            // fatValueLabel
            // 
            this.fatValueLabel.AutoSize = true;
            this.fatValueLabel.Location = new System.Drawing.Point(252, 163);
            this.fatValueLabel.Name = "fatValueLabel";
            this.fatValueLabel.Size = new System.Drawing.Size(32, 36);
            this.fatValueLabel.TabIndex = 5;
            this.fatValueLabel.Text = "0";
            // 
            // includingSugarsLabel
            // 
            this.includingSugarsLabel.AutoSize = true;
            this.includingSugarsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.includingSugarsLabel.Location = new System.Drawing.Point(4, 92);
            this.includingSugarsLabel.Name = "includingSugarsLabel";
            this.includingSugarsLabel.Size = new System.Drawing.Size(234, 33);
            this.includingSugarsLabel.TabIndex = 6;
            this.includingSugarsLabel.Text = "   - Including sugars [g]";
            // 
            // includingSugarsValueLabel
            // 
            this.includingSugarsValueLabel.AutoSize = true;
            this.includingSugarsValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.includingSugarsValueLabel.Location = new System.Drawing.Point(252, 92);
            this.includingSugarsValueLabel.Name = "includingSugarsValueLabel";
            this.includingSugarsValueLabel.Size = new System.Drawing.Size(28, 32);
            this.includingSugarsValueLabel.TabIndex = 5;
            this.includingSugarsValueLabel.Text = "0";
            // 
            // proteinsValueLabel
            // 
            this.proteinsValueLabel.AutoSize = true;
            this.proteinsValueLabel.Location = new System.Drawing.Point(252, 126);
            this.proteinsValueLabel.Name = "proteinsValueLabel";
            this.proteinsValueLabel.Size = new System.Drawing.Size(32, 36);
            this.proteinsValueLabel.TabIndex = 5;
            this.proteinsValueLabel.Text = "0";
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(4, 163);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(91, 36);
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
            // oneUnitMassLabel
            // 
            this.oneUnitMassLabel.AutoSize = true;
            this.oneUnitMassLabel.Location = new System.Drawing.Point(4, 237);
            this.oneUnitMassLabel.Name = "oneUnitMassLabel";
            this.oneUnitMassLabel.Size = new System.Drawing.Size(185, 37);
            this.oneUnitMassLabel.TabIndex = 7;
            this.oneUnitMassLabel.Text = "One unit mass";
            // 
            // oneUnitMassValueLabel
            // 
            this.oneUnitMassValueLabel.AutoSize = true;
            this.oneUnitMassValueLabel.Location = new System.Drawing.Point(252, 237);
            this.oneUnitMassValueLabel.Name = "oneUnitMassValueLabel";
            this.oneUnitMassValueLabel.Size = new System.Drawing.Size(28, 37);
            this.oneUnitMassValueLabel.TabIndex = 8;
            this.oneUnitMassValueLabel.Text = "-";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addedToConsumptionLabel);
            this.panel1.Controls.Add(this.consumeButton);
            this.panel1.Controls.Add(this.selectedProductNameLabel);
            this.panel1.Controls.Add(this.unitsLabel);
            this.panel1.Controls.Add(this.unitsTextBox);
            this.panel1.Controls.Add(this.orLabel);
            this.panel1.Controls.Add(this.weightLabel);
            this.panel1.Controls.Add(this.weightTextBox);
            this.panel1.Controls.Add(this.consumptionLabel);
            this.panel1.Location = new System.Drawing.Point(363, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 211);
            this.panel1.TabIndex = 30;
            // 
            // addedToConsumptionLabel
            // 
            this.addedToConsumptionLabel.AutoSize = true;
            this.addedToConsumptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addedToConsumptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addedToConsumptionLabel.Location = new System.Drawing.Point(32, 181);
            this.addedToConsumptionLabel.Name = "addedToConsumptionLabel";
            this.addedToConsumptionLabel.Size = new System.Drawing.Size(347, 28);
            this.addedToConsumptionLabel.TabIndex = 38;
            this.addedToConsumptionLabel.Text = "Product Added to Daily Consumption!";
            this.addedToConsumptionLabel.Visible = false;
            // 
            // consumeButton
            // 
            this.consumeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.consumeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.consumeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.consumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consumeButton.ForeColor = System.Drawing.Color.White;
            this.consumeButton.Location = new System.Drawing.Point(12, 130);
            this.consumeButton.Name = "consumeButton";
            this.consumeButton.Size = new System.Drawing.Size(314, 48);
            this.consumeButton.TabIndex = 31;
            this.consumeButton.Text = "Consume!";
            this.consumeButton.UseVisualStyleBackColor = false;
            this.consumeButton.Click += new System.EventHandler(this.consumeButton_Click);
            // 
            // selectedProductNameLabel
            // 
            this.selectedProductNameLabel.AutoSize = true;
            this.selectedProductNameLabel.Location = new System.Drawing.Point(7, 56);
            this.selectedProductNameLabel.Name = "selectedProductNameLabel";
            this.selectedProductNameLabel.Size = new System.Drawing.Size(163, 37);
            this.selectedProductNameLabel.TabIndex = 37;
            this.selectedProductNameLabel.Text = "Chicken Egg";
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Location = new System.Drawing.Point(268, 92);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(74, 37);
            this.unitsLabel.TabIndex = 36;
            this.unitsLabel.Text = "units";
            // 
            // unitsTextBox
            // 
            this.unitsTextBox.Location = new System.Drawing.Point(202, 88);
            this.unitsTextBox.Name = "unitsTextBox";
            this.unitsTextBox.Size = new System.Drawing.Size(60, 42);
            this.unitsTextBox.TabIndex = 35;
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(148, 92);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(42, 37);
            this.orLabel.TabIndex = 34;
            this.orLabel.Text = "or";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(103, 92);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(33, 37);
            this.weightLabel.TabIndex = 33;
            this.weightLabel.Text = "g";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(12, 89);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(85, 42);
            this.weightTextBox.TabIndex = 32;
            // 
            // consumptionLabel
            // 
            this.consumptionLabel.AutoSize = true;
            this.consumptionLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.consumptionLabel.Location = new System.Drawing.Point(9, 15);
            this.consumptionLabel.Name = "consumptionLabel";
            this.consumptionLabel.Size = new System.Drawing.Size(332, 37);
            this.consumptionLabel.TabIndex = 31;
            this.consumptionLabel.Text = "Add to Daily Consumption";
            // 
            // macronutrientsLabel
            // 
            this.macronutrientsLabel.AutoSize = true;
            this.macronutrientsLabel.Location = new System.Drawing.Point(356, 82);
            this.macronutrientsLabel.Name = "macronutrientsLabel";
            this.macronutrientsLabel.Size = new System.Drawing.Size(309, 37);
            this.macronutrientsLabel.TabIndex = 31;
            this.macronutrientsLabel.Text = "Macronutrients (in 100g)";
            // 
            // BrowseProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(752, 670);
            this.Controls.Add(this.macronutrientsLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.chooseProductLabel);
            this.Controls.Add(this.selectCategoryValue);
            this.Controls.Add(this.selectCategoryLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BrowseProductsForm";
            this.Text = "Browse Products";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label selectCategoryLabel;
        private System.Windows.Forms.ComboBox selectCategoryValue;
        private System.Windows.Forms.Label chooseProductLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button deleteProductButton;
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
        private System.Windows.Forms.Label oneUnitMassLabel;
        private System.Windows.Forms.Label oneUnitMassValueLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label consumptionLabel;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.TextBox unitsTextBox;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label selectedProductNameLabel;
        private System.Windows.Forms.Button consumeButton;
        private System.Windows.Forms.Label addedToConsumptionLabel;
        private System.Windows.Forms.Label macronutrientsLabel;
    }
}