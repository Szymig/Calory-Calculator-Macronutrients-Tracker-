namespace CaloryCalculatorWinForms
{
    partial class DailyOverviewForm
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
            this.entriesListbox = new System.Windows.Forms.ListBox();
            this.entriesLabel = new System.Windows.Forms.Label();
            this.additionalInfoListBox = new System.Windows.Forms.ListBox();
            this.macronutrientsLabel = new System.Windows.Forms.Label();
            this.additionalInfoLabel = new System.Windows.Forms.Label();
            this.deleteEntryButton = new System.Windows.Forms.Button();
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
            this.resetDayButton = new System.Windows.Forms.Button();
            this.saveDatePicker = new System.Windows.Forms.DateTimePicker();
            this.newDayButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(226, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(334, 62);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Daily Overview";
            // 
            // entriesListbox
            // 
            this.entriesListbox.FormattingEnabled = true;
            this.entriesListbox.ItemHeight = 36;
            this.entriesListbox.Location = new System.Drawing.Point(424, 116);
            this.entriesListbox.Name = "entriesListbox";
            this.entriesListbox.Size = new System.Drawing.Size(306, 256);
            this.entriesListbox.TabIndex = 30;
            this.entriesListbox.SelectedIndexChanged += new System.EventHandler(this.entriesListbox_SelectedIndexChanged);
            // 
            // entriesLabel
            // 
            this.entriesLabel.AutoSize = true;
            this.entriesLabel.Location = new System.Drawing.Point(419, 76);
            this.entriesLabel.Name = "entriesLabel";
            this.entriesLabel.Size = new System.Drawing.Size(96, 37);
            this.entriesLabel.TabIndex = 31;
            this.entriesLabel.Text = "Entries";
            // 
            // additionalInfoListBox
            // 
            this.additionalInfoListBox.FormattingEnabled = true;
            this.additionalInfoListBox.ItemHeight = 36;
            this.additionalInfoListBox.Location = new System.Drawing.Point(12, 448);
            this.additionalInfoListBox.Name = "additionalInfoListBox";
            this.additionalInfoListBox.Size = new System.Drawing.Size(324, 184);
            this.additionalInfoListBox.TabIndex = 32;
            // 
            // macronutrientsLabel
            // 
            this.macronutrientsLabel.AutoSize = true;
            this.macronutrientsLabel.Location = new System.Drawing.Point(7, 76);
            this.macronutrientsLabel.Name = "macronutrientsLabel";
            this.macronutrientsLabel.Size = new System.Drawing.Size(196, 37);
            this.macronutrientsLabel.TabIndex = 33;
            this.macronutrientsLabel.Text = "Macronutrients";
            // 
            // additionalInfoLabel
            // 
            this.additionalInfoLabel.AutoSize = true;
            this.additionalInfoLabel.Location = new System.Drawing.Point(7, 407);
            this.additionalInfoLabel.Name = "additionalInfoLabel";
            this.additionalInfoLabel.Size = new System.Drawing.Size(194, 37);
            this.additionalInfoLabel.TabIndex = 34;
            this.additionalInfoLabel.Text = "Additional Info";
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.BackColor = System.Drawing.Color.Red;
            this.deleteEntryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteEntryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteEntryButton.ForeColor = System.Drawing.Color.White;
            this.deleteEntryButton.Location = new System.Drawing.Point(424, 407);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(306, 52);
            this.deleteEntryButton.TabIndex = 36;
            this.deleteEntryButton.Text = "Delete Entry";
            this.deleteEntryButton.UseVisualStyleBackColor = false;
            this.deleteEntryButton.Click += new System.EventHandler(this.deleteEntryButton_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 273);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // dayCaloriesValueLabel
            // 
            this.dayCaloriesValueLabel.AutoSize = true;
            this.dayCaloriesValueLabel.Location = new System.Drawing.Point(252, 1);
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
            this.dayFibreValueLabel.Location = new System.Drawing.Point(252, 225);
            this.dayFibreValueLabel.Name = "dayFibreValueLabel";
            this.dayFibreValueLabel.Size = new System.Drawing.Size(32, 37);
            this.dayFibreValueLabel.TabIndex = 5;
            this.dayFibreValueLabel.Text = "0";
            // 
            // dayCarbohydratesValueLabel
            // 
            this.dayCarbohydratesValueLabel.AutoSize = true;
            this.dayCarbohydratesValueLabel.Location = new System.Drawing.Point(252, 55);
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
            this.dayFatValueLabel.Location = new System.Drawing.Point(252, 179);
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
            this.dayIncludingSugarsValueLabel.Location = new System.Drawing.Point(252, 101);
            this.dayIncludingSugarsValueLabel.Name = "dayIncludingSugarsValueLabel";
            this.dayIncludingSugarsValueLabel.Size = new System.Drawing.Size(28, 31);
            this.dayIncludingSugarsValueLabel.TabIndex = 5;
            this.dayIncludingSugarsValueLabel.Text = "0";
            // 
            // dayProteinsValueLabel
            // 
            this.dayProteinsValueLabel.AutoSize = true;
            this.dayProteinsValueLabel.Location = new System.Drawing.Point(252, 133);
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
            // resetDayButton
            // 
            this.resetDayButton.BackColor = System.Drawing.Color.Red;
            this.resetDayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetDayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetDayButton.ForeColor = System.Drawing.Color.White;
            this.resetDayButton.Location = new System.Drawing.Point(424, 580);
            this.resetDayButton.Name = "resetDayButton";
            this.resetDayButton.Size = new System.Drawing.Size(306, 52);
            this.resetDayButton.TabIndex = 38;
            this.resetDayButton.Text = "Reset Day";
            this.resetDayButton.UseVisualStyleBackColor = false;
            this.resetDayButton.Click += new System.EventHandler(this.resetDayButton_Click);
            // 
            // saveDatePicker
            // 
            this.saveDatePicker.Location = new System.Drawing.Point(424, 465);
            this.saveDatePicker.Name = "saveDatePicker";
            this.saveDatePicker.Size = new System.Drawing.Size(306, 42);
            this.saveDatePicker.TabIndex = 40;
            // 
            // newDayButton
            // 
            this.newDayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.newDayButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newDayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.newDayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.newDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newDayButton.ForeColor = System.Drawing.Color.White;
            this.newDayButton.Location = new System.Drawing.Point(424, 513);
            this.newDayButton.Name = "newDayButton";
            this.newDayButton.Size = new System.Drawing.Size(306, 61);
            this.newDayButton.TabIndex = 39;
            this.newDayButton.Text = "Save Day!";
            this.newDayButton.UseVisualStyleBackColor = false;
            this.newDayButton.Click += new System.EventHandler(this.newDayButton_Click);
            // 
            // DailyOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(768, 644);
            this.Controls.Add(this.saveDatePicker);
            this.Controls.Add(this.newDayButton);
            this.Controls.Add(this.resetDayButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.deleteEntryButton);
            this.Controls.Add(this.additionalInfoLabel);
            this.Controls.Add(this.macronutrientsLabel);
            this.Controls.Add(this.additionalInfoListBox);
            this.Controls.Add(this.entriesLabel);
            this.Controls.Add(this.entriesListbox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "DailyOverviewForm";
            this.Text = "Daily Overview";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox entriesListbox;
        private System.Windows.Forms.Label entriesLabel;
        private System.Windows.Forms.ListBox additionalInfoListBox;
        private System.Windows.Forms.Label macronutrientsLabel;
        private System.Windows.Forms.Label additionalInfoLabel;
        private System.Windows.Forms.Button deleteEntryButton;
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
        private System.Windows.Forms.Button resetDayButton;
        private System.Windows.Forms.DateTimePicker saveDatePicker;
        private System.Windows.Forms.Button newDayButton;
    }
}