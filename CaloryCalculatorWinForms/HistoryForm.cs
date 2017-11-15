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

    public partial class HistoryForm : Form
    {
        List<DayModel> avaliableDays = GlobalConfig.Connection.GetAllDays().OrderByDescending(x => x.Date).ToList();
        List<DayModel> displayedDays;

        DayModel selectedDay = new DayModel();

        public HistoryForm()
        {
            InitializeComponent();
            displayedDays = avaliableDays;
            WireUpList();
        }


        private void DisplayMacronutrients()
        {
            if(selectedDay != null)
            {
                dayCaloriesValueLabel.Text = selectedDay.Calories.ToString();
                dayCarbohydratesValueLabel.Text = selectedDay.Carbohydrates.ToString();
                dayIncludingSugarsValueLabel.Text = selectedDay.IncludingSugars.ToString();
                dayProteinsValueLabel.Text = selectedDay.Protein.ToString();
                dayFatValueLabel.Text = selectedDay.Fat.ToString();
                dayFibreValueLabel.Text = selectedDay.Fiber.ToString();
            }
            else
            {
                dayCaloriesValueLabel.Text = "0";
                dayCarbohydratesValueLabel.Text = "0";
                dayIncludingSugarsValueLabel.Text = "0";
                dayProteinsValueLabel.Text = "0";
                dayFatValueLabel.Text = "0";
                dayFibreValueLabel.Text = "0";
            }
        }

        private void ResetDisplayedMacro()
        {
            dayCaloriesValueLabel.Text = "0";
            dayCarbohydratesValueLabel.Text = "0";
            dayIncludingSugarsValueLabel.Text = "0";
            dayProteinsValueLabel.Text = "0";
            dayFatValueLabel.Text = "0";
            dayFibreValueLabel.Text = "0";
        }


        private void WireUpList()
        {
            historyListBox.DataSource = null;
            historyListBox.DataSource = displayedDays;
            historyListBox.DisplayMember = "Displayer";
        }

        private void historyDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime searchedDate = historyDatePicker.Value;

            for (int i = 0; i < avaliableDays.Count; i++)
            {
                if(avaliableDays[i].CompareDates(searchedDate))
                {
                    ResetFilter();
                    historyListBox.SelectedIndex = i;
                    notFoundLabel.Hide();
                    return;
                }
            }

            notFoundLabel.Show();
            historyListBox.SelectedIndex = -1;
        }

        private void historyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDay = (DayModel)historyListBox.SelectedItem;
            DisplayMacronutrients();
        }

        private void deleteDayButton_Click(object sender, EventArgs e)
        {
            if(selectedDay != null)
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete selected day form history?", "Delete day.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(confirmDelete == DialogResult.Yes)
                {
                    GlobalConfig.Connection.DeleteDay(selectedDay);
                    avaliableDays.Remove(selectedDay);
                    ResetDisplayedMacro();
                    WireUpList();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select day!", "Day not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            int day;
            int month;
            int year;
            string errorMessage = "";
            bool canFilter = true;

            if((!int.TryParse(dayValue.Text, out day) && dayValue.Text.Length >0 ))
            {
                errorMessage += "Incorrect day value!\n";
                canFilter = false;
            }
            else if((day <= 0 || day > 31) && dayValue.Text.Length > 0)
            {
                errorMessage += "Incorrect day value!\n";
                canFilter = false;
            }

            if ((!int.TryParse(monthValue.Text, out month) && monthValue.Text.Length > 0))
            {
                canFilter = false;
                errorMessage += "Incorrect month value!\n";
            }
            else if((month <= 0 || month > 12) && monthValue.Text.Length > 0)
            {
                canFilter = false;
                errorMessage += "Incorrect month value!\n";
            }

            if ((!int.TryParse(yearValue.Text, out year) && yearValue.Text.Length > 0) )
            {
                canFilter = false;
                errorMessage += "Incorrect year value!";
            }
            else if((year <= 0) && yearValue.Text.Length > 0)
            {
                canFilter = false;
                errorMessage += "Incorrect year value!";
            }

            if(canFilter == false)
            {
                MessageBox.Show(errorMessage, "Invalid input data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            displayedDays = new List<DayModel>();


            foreach (DayModel d in avaliableDays)
            {
                if(dayValue.Text.Length != 0)
                {
                    if(d.Date.Day != day)
                    {
                        continue;
                    }
                }
                if (monthValue.Text.Length != 0)
                {
                    if(d.Date.Month != month)
                    {
                        continue;
                    }
                }
                if (yearValue.Text.Length != 0)
                {
                    if(d.Date.Year != year)
                    {
                        continue;
                    }
                }

                displayedDays.Add(d);
            }

            WireUpList();

        }

        private void ResetFilter()
        {
            dayValue.Text = "";
            monthValue.Text = "";
            yearValue.Text = "";

            displayedDays = avaliableDays;
            WireUpList();
        }

        private void resetFilterButton_Click(object sender, EventArgs e)
        {
            ResetFilter();
        }

        private void clearHistoryButton_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("You are about to clear all history.\nAll data will be lost.\nDo you want to continue?", 
                                                "Clear history.", 
                                                MessageBoxButtons.YesNo, 
                                                MessageBoxIcon.Warning);

            if(confirmDelete == DialogResult.Yes)
            {
                GlobalConfig.Connection.ClearHistory();

                avaliableDays = new List<DayModel>();
                displayedDays = new List<DayModel>();
                WireUpList();
                ResetDisplayedMacro();
                MessageBox.Show("History cleard successfuly!", "History cleard.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }
    }
}
