namespace CaloryCalculatorWinForms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.currentDayLabel = new System.Windows.Forms.Label();
            this.dayCaloriesValueLabel = new System.Windows.Forms.Label();
            this.dayCaloriesLabel = new System.Windows.Forms.Label();
            this.dayFiberLabel = new System.Windows.Forms.Label();
            this.dayFibreValueLabel = new System.Windows.Forms.Label();
            this.dayFatLabel = new System.Windows.Forms.Label();
            this.dayFatValueLabel = new System.Windows.Forms.Label();
            this.dayProteinsLabel = new System.Windows.Forms.Label();
            this.dayProteinsValueLabel = new System.Windows.Forms.Label();
            this.dayIncludingSugarsLabel = new System.Windows.Forms.Label();
            this.dayIncludingSugarsValueLabel = new System.Windows.Forms.Label();
            this.dayCarbohydratesLabel = new System.Windows.Forms.Label();
            this.dayCarbohydratesValueLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.calculateMealButton = new System.Windows.Forms.Button();
            this.browserProductsButton = new System.Windows.Forms.Button();
            this.browserMealsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.consumedTodayButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.resetDailyButton = new System.Windows.Forms.Button();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.newDayButton = new System.Windows.Forms.Button();
            this.helpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpLabel = new System.Windows.Forms.Label();
            this.saveDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(219, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(379, 62);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Calory Calculator";
            // 
            // currentDayLabel
            // 
            this.currentDayLabel.AutoSize = true;
            this.currentDayLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentDayLabel.Location = new System.Drawing.Point(339, 133);
            this.currentDayLabel.Name = "currentDayLabel";
            this.currentDayLabel.Size = new System.Drawing.Size(327, 54);
            this.currentDayLabel.TabIndex = 2;
            this.currentDayLabel.Text = "Consumed Today";
            // 
            // dayCaloriesValueLabel
            // 
            this.dayCaloriesValueLabel.AutoSize = true;
            this.dayCaloriesValueLabel.Location = new System.Drawing.Point(245, 1);
            this.dayCaloriesValueLabel.Name = "dayCaloriesValueLabel";
            this.dayCaloriesValueLabel.Size = new System.Drawing.Size(32, 37);
            this.dayCaloriesValueLabel.TabIndex = 3;
            this.dayCaloriesValueLabel.Text = "0";
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
            this.dayFibreValueLabel.Location = new System.Drawing.Point(245, 225);
            this.dayFibreValueLabel.Name = "dayFibreValueLabel";
            this.dayFibreValueLabel.Size = new System.Drawing.Size(32, 37);
            this.dayFibreValueLabel.TabIndex = 5;
            this.dayFibreValueLabel.Text = "0";
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
            // dayFatValueLabel
            // 
            this.dayFatValueLabel.AutoSize = true;
            this.dayFatValueLabel.Location = new System.Drawing.Point(245, 179);
            this.dayFatValueLabel.Name = "dayFatValueLabel";
            this.dayFatValueLabel.Size = new System.Drawing.Size(32, 37);
            this.dayFatValueLabel.TabIndex = 5;
            this.dayFatValueLabel.Text = "0";
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
            // dayProteinsValueLabel
            // 
            this.dayProteinsValueLabel.AutoSize = true;
            this.dayProteinsValueLabel.Location = new System.Drawing.Point(245, 133);
            this.dayProteinsValueLabel.Name = "dayProteinsValueLabel";
            this.dayProteinsValueLabel.Size = new System.Drawing.Size(32, 37);
            this.dayProteinsValueLabel.TabIndex = 5;
            this.dayProteinsValueLabel.Text = "0";
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
            this.dayIncludingSugarsValueLabel.Location = new System.Drawing.Point(245, 101);
            this.dayIncludingSugarsValueLabel.Name = "dayIncludingSugarsValueLabel";
            this.dayIncludingSugarsValueLabel.Size = new System.Drawing.Size(28, 31);
            this.dayIncludingSugarsValueLabel.TabIndex = 5;
            this.dayIncludingSugarsValueLabel.Text = "0";
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
            // dayCarbohydratesValueLabel
            // 
            this.dayCarbohydratesValueLabel.AutoSize = true;
            this.dayCarbohydratesValueLabel.Location = new System.Drawing.Point(245, 55);
            this.dayCarbohydratesValueLabel.Name = "dayCarbohydratesValueLabel";
            this.dayCarbohydratesValueLabel.Size = new System.Drawing.Size(32, 37);
            this.dayCarbohydratesValueLabel.TabIndex = 5;
            this.dayCarbohydratesValueLabel.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.helpButton);
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 55);
            this.panel1.TabIndex = 8;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(630, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(54, 48);
            this.exitButton.TabIndex = 18;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.helpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpButton.BackgroundImage")));
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(3, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(54, 48);
            this.helpButton.TabIndex = 17;
            this.helpToolTip.SetToolTip(this.helpButton, "To create or consume new meal go to Calculate Meal.\r\nTo consume existing meal go " +
        "to Browser Meals.\r\nTo consume existing product go to Browser Products.\r\n");
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // calculateMealButton
            // 
            this.calculateMealButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.calculateMealButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calculateMealButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.calculateMealButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.calculateMealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateMealButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calculateMealButton.ForeColor = System.Drawing.Color.White;
            this.calculateMealButton.Location = new System.Drawing.Point(15, 145);
            this.calculateMealButton.Name = "calculateMealButton";
            this.calculateMealButton.Size = new System.Drawing.Size(255, 87);
            this.calculateMealButton.TabIndex = 1;
            this.calculateMealButton.Text = "Calculate Meal";
            this.calculateMealButton.UseVisualStyleBackColor = false;
            this.calculateMealButton.Click += new System.EventHandler(this.calculateMealButton_Click);
            // 
            // browserProductsButton
            // 
            this.browserProductsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.browserProductsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.browserProductsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.browserProductsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.browserProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browserProductsButton.ForeColor = System.Drawing.Color.White;
            this.browserProductsButton.Location = new System.Drawing.Point(40, 238);
            this.browserProductsButton.Name = "browserProductsButton";
            this.browserProductsButton.Size = new System.Drawing.Size(209, 52);
            this.browserProductsButton.TabIndex = 6;
            this.browserProductsButton.Text = "Browse Products";
            this.browserProductsButton.UseVisualStyleBackColor = false;
            this.browserProductsButton.Click += new System.EventHandler(this.browserProductsButton_Click);
            // 
            // browserMealsButton
            // 
            this.browserMealsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.browserMealsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.browserMealsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.browserMealsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.browserMealsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browserMealsButton.ForeColor = System.Drawing.Color.White;
            this.browserMealsButton.Location = new System.Drawing.Point(40, 295);
            this.browserMealsButton.Name = "browserMealsButton";
            this.browserMealsButton.Size = new System.Drawing.Size(209, 52);
            this.browserMealsButton.TabIndex = 7;
            this.browserMealsButton.Text = "Browse Meals";
            this.browserMealsButton.UseVisualStyleBackColor = false;
            this.browserMealsButton.Click += new System.EventHandler(this.browserMealsButton_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(338, 184);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 272);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // consumedTodayButton
            // 
            this.consumedTodayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.consumedTodayButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.consumedTodayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.consumedTodayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.consumedTodayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consumedTodayButton.ForeColor = System.Drawing.Color.White;
            this.consumedTodayButton.Location = new System.Drawing.Point(338, 472);
            this.consumedTodayButton.Name = "consumedTodayButton";
            this.consumedTodayButton.Size = new System.Drawing.Size(197, 53);
            this.consumedTodayButton.TabIndex = 10;
            this.consumedTodayButton.Text = "Daily Overview";
            this.consumedTodayButton.UseVisualStyleBackColor = false;
            this.consumedTodayButton.Click += new System.EventHandler(this.consumedTodayButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.refreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.refreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(631, 130);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(54, 48);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // resetDailyButton
            // 
            this.resetDailyButton.BackColor = System.Drawing.Color.Red;
            this.resetDailyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.resetDailyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetDailyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetDailyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetDailyButton.ForeColor = System.Drawing.Color.White;
            this.resetDailyButton.Location = new System.Drawing.Point(588, 472);
            this.resetDailyButton.Name = "resetDailyButton";
            this.resetDailyButton.Size = new System.Drawing.Size(97, 52);
            this.resetDailyButton.TabIndex = 13;
            this.resetDailyButton.Text = "Reset";
            this.resetDailyButton.UseVisualStyleBackColor = false;
            this.resetDailyButton.Click += new System.EventHandler(this.resetDailyButton_Click);
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.addNewProductButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addNewProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.addNewProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.addNewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewProductButton.ForeColor = System.Drawing.Color.White;
            this.addNewProductButton.Location = new System.Drawing.Point(40, 351);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(209, 52);
            this.addNewProductButton.TabIndex = 14;
            this.addNewProductButton.Text = "Add New Product";
            this.addNewProductButton.UseVisualStyleBackColor = false;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.historyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.historyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.historyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.ForeColor = System.Drawing.Color.White;
            this.historyButton.Location = new System.Drawing.Point(40, 408);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(209, 53);
            this.historyButton.TabIndex = 15;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // newDayButton
            // 
            this.newDayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.newDayButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newDayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.newDayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.newDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newDayButton.ForeColor = System.Drawing.Color.White;
            this.newDayButton.Location = new System.Drawing.Point(15, 523);
            this.newDayButton.Name = "newDayButton";
            this.newDayButton.Size = new System.Drawing.Size(255, 53);
            this.newDayButton.TabIndex = 16;
            this.newDayButton.Text = "Save Day!";
            this.newDayButton.UseVisualStyleBackColor = false;
            this.newDayButton.Click += new System.EventHandler(this.newDayButton_Click);
            // 
            // helpToolTip
            // 
            this.helpToolTip.ToolTipTitle = "Help";
            // 
            // helpLabel
            // 
            this.helpLabel.AllowDrop = true;
            this.helpLabel.AutoEllipsis = true;
            this.helpLabel.AutoSize = true;
            this.helpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.helpLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpLabel.Location = new System.Drawing.Point(12, 58);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(390, 100);
            this.helpLabel.TabIndex = 0;
            this.helpLabel.Text = resources.GetString("helpLabel.Text");
            this.helpLabel.Visible = false;
            // 
            // saveDatePicker
            // 
            this.saveDatePicker.Location = new System.Drawing.Point(15, 482);
            this.saveDatePicker.Name = "saveDatePicker";
            this.saveDatePicker.Size = new System.Drawing.Size(255, 42);
            this.saveDatePicker.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(229)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(697, 577);
            this.Controls.Add(this.saveDatePicker);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.newDayButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.addNewProductButton);
            this.Controls.Add(this.resetDailyButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.consumedTodayButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.browserMealsButton);
            this.Controls.Add(this.browserProductsButton);
            this.Controls.Add(this.calculateMealButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentDayLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainForm";
            this.Text = "Calory Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label currentDayLabel;
        private System.Windows.Forms.Label dayCaloriesValueLabel;
        private System.Windows.Forms.Label dayCaloriesLabel;
        private System.Windows.Forms.Label dayCarbohydratesLabel;
        private System.Windows.Forms.Label dayCarbohydratesValueLabel;
        private System.Windows.Forms.Label dayProteinsLabel;
        private System.Windows.Forms.Label dayProteinsValueLabel;
        private System.Windows.Forms.Label dayFatLabel;
        private System.Windows.Forms.Label dayFatValueLabel;
        private System.Windows.Forms.Label dayIncludingSugarsLabel;
        private System.Windows.Forms.Label dayIncludingSugarsValueLabel;
        private System.Windows.Forms.Label dayFiberLabel;
        private System.Windows.Forms.Label dayFibreValueLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calculateMealButton;
        private System.Windows.Forms.Button browserProductsButton;
        private System.Windows.Forms.Button browserMealsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button consumedTodayButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button resetDailyButton;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button newDayButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.ToolTip helpToolTip;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.DateTimePicker saveDatePicker;
        private System.Windows.Forms.Button exitButton;
    }
}