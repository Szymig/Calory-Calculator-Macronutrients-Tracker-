namespace CaloryCalculatorWinForms
{
    partial class AddNewProductForm
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productNameValue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.carbohydratesLabel = new System.Windows.Forms.Label();
            this.fiberLabel = new System.Windows.Forms.Label();
            this.proteinsLabel = new System.Windows.Forms.Label();
            this.includingSugarsLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.caloriesValue = new System.Windows.Forms.TextBox();
            this.carbohydratesValue = new System.Windows.Forms.TextBox();
            this.includingSugarsValue = new System.Windows.Forms.TextBox();
            this.proteinsValue = new System.Windows.Forms.TextBox();
            this.fatValue = new System.Windows.Forms.TextBox();
            this.fiberValue = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryValue = new System.Windows.Forms.ComboBox();
            this.macronutriensLabel = new System.Windows.Forms.Label();
            this.unitMassValue = new System.Windows.Forms.TextBox();
            this.unitMassLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createProductButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.Location = new System.Drawing.Point(202, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(369, 60);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Add New Product";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(12, 90);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(187, 37);
            this.productNameLabel.TabIndex = 2;
            this.productNameLabel.Text = "Product Name";
            // 
            // productNameValue
            // 
            this.productNameValue.BackColor = System.Drawing.SystemColors.Window;
            this.productNameValue.Location = new System.Drawing.Point(205, 87);
            this.productNameValue.Name = "productNameValue";
            this.productNameValue.Size = new System.Drawing.Size(190, 42);
            this.productNameValue.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.carbohydratesLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fiberLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.proteinsLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.includingSugarsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.fatLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.caloriesLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.caloriesValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.carbohydratesValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.includingSugarsValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.proteinsValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.fatValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.fiberValue, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 252);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 268);
            this.tableLayoutPanel1.TabIndex = 10;
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
            this.fiberLabel.Location = new System.Drawing.Point(4, 223);
            this.fiberLabel.Name = "fiberLabel";
            this.fiberLabel.Size = new System.Drawing.Size(115, 37);
            this.fiberLabel.TabIndex = 6;
            this.fiberLabel.Text = "Fiber [g]";
            // 
            // proteinsLabel
            // 
            this.proteinsLabel.AutoSize = true;
            this.proteinsLabel.Location = new System.Drawing.Point(4, 135);
            this.proteinsLabel.Name = "proteinsLabel";
            this.proteinsLabel.Size = new System.Drawing.Size(152, 37);
            this.proteinsLabel.TabIndex = 6;
            this.proteinsLabel.Text = "Proteins [g]";
            // 
            // includingSugarsLabel
            // 
            this.includingSugarsLabel.AutoSize = true;
            this.includingSugarsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.includingSugarsLabel.Location = new System.Drawing.Point(4, 98);
            this.includingSugarsLabel.Name = "includingSugarsLabel";
            this.includingSugarsLabel.Size = new System.Drawing.Size(234, 36);
            this.includingSugarsLabel.TabIndex = 6;
            this.includingSugarsLabel.Text = "   - Including sugars [g]";
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
            // caloriesValue
            // 
            this.caloriesValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.caloriesValue.Location = new System.Drawing.Point(245, 4);
            this.caloriesValue.Name = "caloriesValue";
            this.caloriesValue.Size = new System.Drawing.Size(98, 52);
            this.caloriesValue.TabIndex = 7;
            this.caloriesValue.Text = "0";
            // 
            // carbohydratesValue
            // 
            this.carbohydratesValue.Location = new System.Drawing.Point(245, 57);
            this.carbohydratesValue.Name = "carbohydratesValue";
            this.carbohydratesValue.Size = new System.Drawing.Size(98, 42);
            this.carbohydratesValue.TabIndex = 8;
            this.carbohydratesValue.Text = "0";
            // 
            // includingSugarsValue
            // 
            this.includingSugarsValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.includingSugarsValue.Location = new System.Drawing.Point(245, 101);
            this.includingSugarsValue.Name = "includingSugarsValue";
            this.includingSugarsValue.Size = new System.Drawing.Size(98, 39);
            this.includingSugarsValue.TabIndex = 9;
            this.includingSugarsValue.Text = "0";
            // 
            // proteinsValue
            // 
            this.proteinsValue.Location = new System.Drawing.Point(245, 138);
            this.proteinsValue.Name = "proteinsValue";
            this.proteinsValue.Size = new System.Drawing.Size(98, 42);
            this.proteinsValue.TabIndex = 10;
            this.proteinsValue.Text = "0";
            // 
            // fatValue
            // 
            this.fatValue.Location = new System.Drawing.Point(245, 182);
            this.fatValue.Name = "fatValue";
            this.fatValue.Size = new System.Drawing.Size(98, 42);
            this.fatValue.TabIndex = 11;
            this.fatValue.Text = "0";
            // 
            // fiberValue
            // 
            this.fiberValue.Location = new System.Drawing.Point(245, 226);
            this.fiberValue.Name = "fiberValue";
            this.fiberValue.Size = new System.Drawing.Size(98, 42);
            this.fiberValue.TabIndex = 12;
            this.fiberValue.Text = "0";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(12, 135);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(125, 37);
            this.categoryLabel.TabIndex = 11;
            this.categoryLabel.Text = "Category";
            // 
            // categoryValue
            // 
            this.categoryValue.FormattingEnabled = true;
            this.categoryValue.Location = new System.Drawing.Point(205, 135);
            this.categoryValue.Name = "categoryValue";
            this.categoryValue.Size = new System.Drawing.Size(190, 44);
            this.categoryValue.TabIndex = 12;
            // 
            // macronutriensLabel
            // 
            this.macronutriensLabel.AutoSize = true;
            this.macronutriensLabel.Location = new System.Drawing.Point(21, 212);
            this.macronutriensLabel.Name = "macronutriensLabel";
            this.macronutriensLabel.Size = new System.Drawing.Size(307, 37);
            this.macronutriensLabel.TabIndex = 13;
            this.macronutriensLabel.Text = "Macronutriens (in 100 g)";
            // 
            // unitMassValue
            // 
            this.unitMassValue.Location = new System.Drawing.Point(643, 135);
            this.unitMassValue.Name = "unitMassValue";
            this.unitMassValue.Size = new System.Drawing.Size(95, 42);
            this.unitMassValue.TabIndex = 15;
            // 
            // unitMassLabel
            // 
            this.unitMassLabel.AutoSize = true;
            this.unitMassLabel.Location = new System.Drawing.Point(408, 135);
            this.unitMassLabel.Name = "unitMassLabel";
            this.unitMassLabel.Size = new System.Drawing.Size(229, 37);
            this.unitMassLabel.TabIndex = 14;
            this.unitMassLabel.Text = "One Unit Mass (g)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "(optional)";
            // 
            // createProductButton
            // 
            this.createProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.createProductButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.createProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.createProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProductButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createProductButton.ForeColor = System.Drawing.Color.White;
            this.createProductButton.Location = new System.Drawing.Point(468, 302);
            this.createProductButton.Name = "createProductButton";
            this.createProductButton.Size = new System.Drawing.Size(203, 133);
            this.createProductButton.TabIndex = 17;
            this.createProductButton.Text = "Add Product";
            this.createProductButton.UseVisualStyleBackColor = false;
            this.createProductButton.Click += new System.EventHandler(this.createProductButton_Click);
            // 
            // AddNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(759, 536);
            this.Controls.Add(this.createProductButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unitMassValue);
            this.Controls.Add(this.unitMassLabel);
            this.Controls.Add(this.macronutriensLabel);
            this.Controls.Add(this.categoryValue);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.productNameValue);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AddNewProductForm";
            this.Text = "Create Product";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productNameValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label carbohydratesLabel;
        private System.Windows.Forms.Label fiberLabel;
        private System.Windows.Forms.Label proteinsLabel;
        private System.Windows.Forms.Label includingSugarsLabel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label caloriesLabel;
        private System.Windows.Forms.TextBox caloriesValue;
        private System.Windows.Forms.TextBox carbohydratesValue;
        private System.Windows.Forms.TextBox includingSugarsValue;
        private System.Windows.Forms.TextBox proteinsValue;
        private System.Windows.Forms.TextBox fatValue;
        private System.Windows.Forms.TextBox fiberValue;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryValue;
        private System.Windows.Forms.Label macronutriensLabel;
        private System.Windows.Forms.TextBox unitMassValue;
        private System.Windows.Forms.Label unitMassLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createProductButton;
    }
}