namespace CaloryCalculatorWinForms
{
    partial class HistoryForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dayCaloriesValueLabel = new System.Windows.Forms.Label();
            this.dayCarbohydratesLabel = new System.Windows.Forms.Label();
            this.dayFiberLabel = new System.Windows.Forms.Label();
            this.dayFibreValueLabel = new System.Windows.Forms.Label();
            this.dayCarbohydratesValueLabel = new System.Windows.Forms.Label();
            this.dayProteinsLabel = new System.Windows.Forms.Label();
            this.dayFatValueLabel = new System.Windows.Forms.Label();
            this.dayIncludingSugarsLabel = new System.Windows.Forms.Label();
            this.dayIncludingSugarsValueLabel = new System.Windows.Forms.Label();
            this.dayProteinsValueLabel = new System.Windows.Forms.Label();
            this.dayFatLabel = new System.Windows.Forms.Label();
            this.dayCaloriesLabel = new System.Windows.Forms.Label();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.deleteDayButton = new System.Windows.Forms.Button();
            this.historyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.notFoundLabel = new System.Windows.Forms.Label();
            this.pickDateLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.dayValue = new System.Windows.Forms.TextBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.monthValue = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.resetFilterButton = new System.Windows.Forms.Button();
            this.yearValue = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(285, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(174, 62);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "History";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.dayCaloriesValueLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dayCarbohydratesLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dayFiberLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dayFibreValueLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dayCarbohydratesValueLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dayProteinsLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dayFatValueLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dayIncludingSugarsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dayIncludingSugarsValueLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dayProteinsValueLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dayFatLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dayCaloriesLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(445, 122);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 272);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // dayCaloriesValueLabel
            // 
            this.dayCaloriesValueLabel.AutoSize = true;
            this.dayCaloriesValueLabel.Location = new System.Drawing.Point(247, 1);
            this.dayCaloriesValueLabel.Name = "dayCaloriesValueLabel";
            this.dayCaloriesValueLabel.Size = new System.Drawing.Size(32, 37);
            this.dayCaloriesValueLabel.TabIndex = 3;
            this.dayCaloriesValueLabel.Text = "0";
            // 
            // dayCarbohydratesLabel
            // 
            this.dayCarbohydratesLabel.AutoSize = true;
            this.dayCarbohydratesLabel.Location = new System.Drawing.Point(4, 55);
            this.dayCarbohydratesLabel.Name = "dayCarbohydratesLabel";
            this.dayCarbohydratesLabel.Size = new System.Drawing.Size(229, 37);
            this.dayCarbohydratesLabel.TabIndex = 6;
            this.dayCarbohydratesLabel.Text = "Carbohydrates [g]";
            // 
            // dayFiberLabel
            // 
            this.dayFiberLabel.AutoSize = true;
            this.dayFiberLabel.Location = new System.Drawing.Point(4, 225);
            this.dayFiberLabel.Name = "dayFiberLabel";
            this.dayFiberLabel.Size = new System.Drawing.Size(115, 37);
            this.dayFiberLabel.TabIndex = 6;
            this.dayFiberLabel.Text = "Fiber [g]";
            // 
            // dayFibreValueLabel
            // 
            this.dayFibreValueLabel.AutoSize = true;
            this.dayFibreValueLabel.Location = new System.Drawing.Point(247, 225);
            this.dayFibreValueLabel.Name = "dayFibreValueLabel";
            this.dayFibreValueLabel.Size = new System.Drawing.Size(32, 37);
            this.dayFibreValueLabel.TabIndex = 5;
            this.dayFibreValueLabel.Text = "0";
            // 
            // dayCarbohydratesValueLabel
            // 
            this.dayCarbohydratesValueLabel.AutoSize = true;
            this.dayCarbohydratesValueLabel.Location = new System.Drawing.Point(247, 55);
            this.dayCarbohydratesValueLabel.Name = "dayCarbohydratesValueLabel";
            this.dayCarbohydratesValueLabel.Size = new System.Drawing.Size(32, 37);
            this.dayCarbohydratesValueLabel.TabIndex = 5;
            this.dayCarbohydratesValueLabel.Text = "0";
            // 
            // dayProteinsLabel
            // 
            this.dayProteinsLabel.AutoSize = true;
            this.dayProteinsLabel.Location = new System.Drawing.Point(4, 133);
            this.dayProteinsLabel.Name = "dayProteinsLabel";
            this.dayProteinsLabel.Size = new System.Drawing.Size(152, 37);
            this.dayProteinsLabel.TabIndex = 6;
            this.dayProteinsLabel.Text = "Proteins [g]";
            // 
            // dayFatValueLabel
            // 
            this.dayFatValueLabel.AutoSize = true;
            this.dayFatValueLabel.Location = new System.Drawing.Point(247, 179);
            this.dayFatValueLabel.Name = "dayFatValueLabel";
            this.dayFatValueLabel.Size = new System.Drawing.Size(32, 37);
            this.dayFatValueLabel.TabIndex = 5;
            this.dayFatValueLabel.Text = "0";
            // 
            // dayIncludingSugarsLabel
            // 
            this.dayIncludingSugarsLabel.AutoSize = true;
            this.dayIncludingSugarsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dayIncludingSugarsLabel.Location = new System.Drawing.Point(4, 101);
            this.dayIncludingSugarsLabel.Name = "dayIncludingSugarsLabel";
            this.dayIncludingSugarsLabel.Size = new System.Drawing.Size(234, 31);
            this.dayIncludingSugarsLabel.TabIndex = 6;
            this.dayIncludingSugarsLabel.Text = "   - Including sugars [g]";
            // 
            // dayIncludingSugarsValueLabel
            // 
            this.dayIncludingSugarsValueLabel.AutoSize = true;
            this.dayIncludingSugarsValueLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dayIncludingSugarsValueLabel.Location = new System.Drawing.Point(247, 101);
            this.dayIncludingSugarsValueLabel.Name = "dayIncludingSugarsValueLabel";
            this.dayIncludingSugarsValueLabel.Size = new System.Drawing.Size(28, 31);
            this.dayIncludingSugarsValueLabel.TabIndex = 5;
            this.dayIncludingSugarsValueLabel.Text = "0";
            // 
            // dayProteinsValueLabel
            // 
            this.dayProteinsValueLabel.AutoSize = true;
            this.dayProteinsValueLabel.Location = new System.Drawing.Point(247, 133);
            this.dayProteinsValueLabel.Name = "dayProteinsValueLabel";
            this.dayProteinsValueLabel.Size = new System.Drawing.Size(32, 37);
            this.dayProteinsValueLabel.TabIndex = 5;
            this.dayProteinsValueLabel.Text = "0";
            // 
            // dayFatLabel
            // 
            this.dayFatLabel.AutoSize = true;
            this.dayFatLabel.Location = new System.Drawing.Point(4, 179);
            this.dayFatLabel.Name = "dayFatLabel";
            this.dayFatLabel.Size = new System.Drawing.Size(91, 37);
            this.dayFatLabel.TabIndex = 6;
            this.dayFatLabel.Text = "Fat [g]";
            // 
            // dayCaloriesLabel
            // 
            this.dayCaloriesLabel.AutoSize = true;
            this.dayCaloriesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dayCaloriesLabel.Location = new System.Drawing.Point(4, 1);
            this.dayCaloriesLabel.Name = "dayCaloriesLabel";
            this.dayCaloriesLabel.Size = new System.Drawing.Size(225, 46);
            this.dayCaloriesLabel.TabIndex = 4;
            this.dayCaloriesLabel.Text = "Calories [kcal]";
            // 
            // historyListBox
            // 
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 36;
            this.historyListBox.Location = new System.Drawing.Point(12, 350);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(395, 292);
            this.historyListBox.TabIndex = 11;
            this.historyListBox.SelectedIndexChanged += new System.EventHandler(this.historyListBox_SelectedIndexChanged);
            // 
            // deleteDayButton
            // 
            this.deleteDayButton.BackColor = System.Drawing.Color.Red;
            this.deleteDayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteDayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDayButton.ForeColor = System.Drawing.Color.White;
            this.deleteDayButton.Location = new System.Drawing.Point(445, 416);
            this.deleteDayButton.Name = "deleteDayButton";
            this.deleteDayButton.Size = new System.Drawing.Size(349, 54);
            this.deleteDayButton.TabIndex = 30;
            this.deleteDayButton.Text = "Delete From History";
            this.deleteDayButton.UseVisualStyleBackColor = false;
            this.deleteDayButton.Click += new System.EventHandler(this.deleteDayButton_Click);
            // 
            // historyDatePicker
            // 
            this.historyDatePicker.Location = new System.Drawing.Point(12, 122);
            this.historyDatePicker.Name = "historyDatePicker";
            this.historyDatePicker.Size = new System.Drawing.Size(398, 42);
            this.historyDatePicker.TabIndex = 31;
            this.historyDatePicker.ValueChanged += new System.EventHandler(this.historyDatePicker_ValueChanged);
            // 
            // notFoundLabel
            // 
            this.notFoundLabel.AutoSize = true;
            this.notFoundLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.notFoundLabel.ForeColor = System.Drawing.Color.Red;
            this.notFoundLabel.Location = new System.Drawing.Point(12, 167);
            this.notFoundLabel.Name = "notFoundLabel";
            this.notFoundLabel.Size = new System.Drawing.Size(398, 32);
            this.notFoundLabel.TabIndex = 32;
            this.notFoundLabel.Text = "Selected day is not saved in history!";
            this.notFoundLabel.Visible = false;
            // 
            // pickDateLabel
            // 
            this.pickDateLabel.AutoSize = true;
            this.pickDateLabel.Location = new System.Drawing.Point(12, 79);
            this.pickDateLabel.Name = "pickDateLabel";
            this.pickDateLabel.Size = new System.Drawing.Size(127, 37);
            this.pickDateLabel.TabIndex = 33;
            this.pickDateLabel.Text = "Pick Date";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(12, 210);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(63, 37);
            this.dayLabel.TabIndex = 34;
            this.dayLabel.Text = "Day";
            // 
            // dayValue
            // 
            this.dayValue.Location = new System.Drawing.Point(67, 207);
            this.dayValue.Name = "dayValue";
            this.dayValue.Size = new System.Drawing.Size(40, 42);
            this.dayValue.TabIndex = 35;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(113, 210);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(96, 37);
            this.monthLabel.TabIndex = 36;
            this.monthLabel.Text = "Month";
            // 
            // monthValue
            // 
            this.monthValue.Location = new System.Drawing.Point(215, 207);
            this.monthValue.Name = "monthValue";
            this.monthValue.Size = new System.Drawing.Size(50, 42);
            this.monthValue.TabIndex = 37;
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.filterButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.filterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.filterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.ForeColor = System.Drawing.Color.White;
            this.filterButton.Location = new System.Drawing.Point(12, 265);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(197, 54);
            this.filterButton.TabIndex = 38;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // resetFilterButton
            // 
            this.resetFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.resetFilterButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.resetFilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.resetFilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.resetFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetFilterButton.ForeColor = System.Drawing.Color.White;
            this.resetFilterButton.Location = new System.Drawing.Point(215, 265);
            this.resetFilterButton.Name = "resetFilterButton";
            this.resetFilterButton.Size = new System.Drawing.Size(192, 54);
            this.resetFilterButton.TabIndex = 39;
            this.resetFilterButton.Text = "Reset Filter";
            this.resetFilterButton.UseVisualStyleBackColor = false;
            this.resetFilterButton.Click += new System.EventHandler(this.resetFilterButton_Click);
            // 
            // yearValue
            // 
            this.yearValue.Location = new System.Drawing.Point(344, 207);
            this.yearValue.Name = "yearValue";
            this.yearValue.Size = new System.Drawing.Size(66, 42);
            this.yearValue.TabIndex = 41;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(271, 210);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(67, 37);
            this.yearLabel.TabIndex = 40;
            this.yearLabel.Text = "Year";
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.BackColor = System.Drawing.Color.Black;
            this.clearHistoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.clearHistoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clearHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearHistoryButton.ForeColor = System.Drawing.Color.White;
            this.clearHistoryButton.Location = new System.Drawing.Point(640, 593);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(154, 49);
            this.clearHistoryButton.TabIndex = 42;
            this.clearHistoryButton.Text = "Clear History";
            this.clearHistoryButton.UseVisualStyleBackColor = false;
            this.clearHistoryButton.Click += new System.EventHandler(this.clearHistoryButton_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(820, 658);
            this.Controls.Add(this.clearHistoryButton);
            this.Controls.Add(this.yearValue);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.resetFilterButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.monthValue);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dayValue);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.pickDateLabel);
            this.Controls.Add(this.notFoundLabel);
            this.Controls.Add(this.historyDatePicker);
            this.Controls.Add(this.deleteDayButton);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "HistoryForm";
            this.Text = "History";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label dayCaloriesValueLabel;
        private System.Windows.Forms.Label dayCarbohydratesLabel;
        private System.Windows.Forms.Label dayFiberLabel;
        private System.Windows.Forms.Label dayFibreValueLabel;
        private System.Windows.Forms.Label dayCarbohydratesValueLabel;
        private System.Windows.Forms.Label dayProteinsLabel;
        private System.Windows.Forms.Label dayFatValueLabel;
        private System.Windows.Forms.Label dayIncludingSugarsLabel;
        private System.Windows.Forms.Label dayIncludingSugarsValueLabel;
        private System.Windows.Forms.Label dayProteinsValueLabel;
        private System.Windows.Forms.Label dayFatLabel;
        private System.Windows.Forms.Label dayCaloriesLabel;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Button deleteDayButton;
        private System.Windows.Forms.DateTimePicker historyDatePicker;
        private System.Windows.Forms.Label notFoundLabel;
        private System.Windows.Forms.Label pickDateLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.TextBox dayValue;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.TextBox monthValue;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button resetFilterButton;
        private System.Windows.Forms.TextBox yearValue;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button clearHistoryButton;
    }
}