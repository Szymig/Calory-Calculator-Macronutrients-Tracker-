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
    public partial class DailyOverviewForm : Form
    {
        List<DailyEntryModel> consumedToday = GlobalConfig.Connection.GetAllDailyEntries();
        DailyEntryModel activeEntry = new DailyEntryModel();

        IFormRefresher callingForm;

        public DailyOverviewForm(IFormRefresher caller)
        {
            InitializeComponent();
            callingForm = caller;
            DisplayMacronutrients();
            WireUpEntriesListBox();
        }

        private void DisplayMacronutrients()
        {
            float calories = 0;
            float carbohydrates = 0;
            float includingSugars = 0;
            float protein = 0;
            float fat = 0;
            float fiber = 0;


            foreach (DailyEntryModel d in consumedToday)
            {
                d.CalculateMacronutrients();

                calories += d.Calories;
                carbohydrates += d.Carbohydrates;
                includingSugars += d.IncludingSugars;
                protein += d.Protein;
                fat += d.Fat;
                fiber += d.Fiber;
            }

            dayCaloriesValueLabel.Text = calories.ToString();
            dayCarbohydratesValueLabel.Text = carbohydrates.ToString();
            dayIncludingSugarsValueLabel.Text = includingSugars.ToString();
            dayProteinsValueLabel.Text = protein.ToString();
            dayFatValueLabel.Text = fat.ToString();
            dayFibreValueLabel.Text = fiber.ToString();
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

        private void WireUpEntriesListBox()
        {
            entriesListbox.DataSource = null;
            entriesListbox.DataSource = consumedToday;
            entriesListbox.DisplayMember = "DisplayedName";
        }


        private void entriesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeEntry = (DailyEntryModel) entriesListbox.SelectedItem;

            if(activeEntry != null)
            {
                if (activeEntry.Meal == null && activeEntry.Product != null)
                {
                    List<DailyEntryModel> display = new List<DailyEntryModel>();
                    display.Add(activeEntry);
                    additionalInfoListBox.DataSource = null;
                    additionalInfoListBox.DataSource = display;
                    additionalInfoListBox.DisplayMember = "InfoProduct";
                }
                else if (activeEntry.Meal != null)
                {
                    additionalInfoListBox.DataSource = null;
                    additionalInfoListBox.DataSource = activeEntry.Meal.Ingredients;
                    additionalInfoListBox.DisplayMember = "NameAndMass";
                }
            }
            else
            {
                additionalInfoListBox.DataSource = null;
            }

        }

        private void resetDayButton_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Are you sure you want to reset day?", "Reset day.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmDelete == DialogResult.Yes)
            {
                GlobalConfig.Connection.DeleteAllDailyEntries();
                activeEntry = null;
                consumedToday = new List<DailyEntryModel>();
                ResetDisplayedMacro();
                WireUpEntriesListBox();
                callingForm.RefreshForm();
            }
            else if(confirmDelete == DialogResult.No)
            {
                return;
            }

        }

        private void deleteEntryButton_Click(object sender, EventArgs e)
        {
            if(activeEntry != null)
            {
                var confirmDelete = MessageBox.Show("Are you sure you want to delete selected entry?", "Delete entry.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(confirmDelete == DialogResult.Yes)
                {
                    GlobalConfig.Connection.DeleteDailyEntry(activeEntry);
                    consumedToday.Remove(activeEntry);
                    WireUpEntriesListBox();
                    DisplayMacronutrients();
                    callingForm.RefreshForm();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No enty selected!", "Error deleting entry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newDayButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = saveDatePicker.Value;
            List<DayModel> days = GlobalConfig.Connection.GetAllDays();
            bool overWritting = false;
            int overWritedDayId = -1;

            foreach (DayModel day in days)
            {
                if (day.CompareDates(selectedDate))
                {
                    var wantToOverWrite = MessageBox.Show("Selected date already exists in database!\nDo you want to overwrite it?\nPrevious data will be lost.", 
                                                          "Selected date already exist.", 
                                                          MessageBoxButtons.YesNo, 
                                                          MessageBoxIcon.Warning);

                    if (wantToOverWrite == DialogResult.Yes)
                    {
                        overWritting = true;
                        overWritedDayId = day.Id;
                        break;
                    }
                    else if (wantToOverWrite == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            float calories = float.Parse(dayCaloriesValueLabel.Text);
            float carbs = float.Parse(dayCarbohydratesValueLabel.Text);
            float sugar = float.Parse(dayIncludingSugarsValueLabel.Text);
            float protein = float.Parse(dayProteinsValueLabel.Text);
            float fat = float.Parse(dayFatValueLabel.Text);
            float fiber = float.Parse(dayFibreValueLabel.Text);

            if (calories == 0 && carbs == 0 && sugar == 0 && protein == 0 && fat == 0 && fiber == 0)
            {
                MessageBox.Show("You have not consumed any macronutrients today!", "No macronutrients consumed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool confirmed = false; ;

                if (!overWritting)
                {
                    var saveDayConfirmation = MessageBox.Show("Are you sure you want to save the day?", "Save day confirmation.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(saveDayConfirmation == DialogResult.Yes)
                    {
                        confirmed = true;
                    }
                }

                if (confirmed || overWritting)
                {
                    DayModel model = new DayModel();
                    model.Date = selectedDate;
                    model.Calories = calories;
                    model.Carbohydrates = carbs;
                    model.IncludingSugars = sugar;
                    model.Protein = protein;
                    model.Fat = fat;
                    model.Fiber = fiber;

                    if (!overWritting)
                    {
                        GlobalConfig.Connection.AddDayToHistory(model);
                    }
                    else
                    {
                        if (overWritedDayId == -1)
                        {
                            MessageBox.Show("An error occured while editing a day!\nPlease try again or delete day from history.",
                                            "Error editing day!",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            return;
                        }

                        model.Id = overWritedDayId;
                        GlobalConfig.Connection.OverwriteDay(model);
                    }

                    GlobalConfig.Connection.DeleteAllDailyEntries();
                    consumedToday = new List<DailyEntryModel>();
                    MessageBox.Show("Day Saved successfully!", "Day saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    callingForm.RefreshForm();
                    this.Close();
                }
                else
                {
                    return;
                }
            }

        }


    }
}
