using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryCalculatorLibrary.Models
{
    public class DayModel
    {
        #region Main Properties

        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date of the day
        /// </summary>
        public DateTime Date { get; set; }

        #endregion

        #region Macronutrients Properties

        /// <summary>
        /// Amount of Calories consumed on this day
        /// </summary>
        public float Calories { get; set; }
        /// <summary>
        /// Amount of Protein consumed on this day
        /// </summary>
        public float Protein { get; set; }
        /// <summary>
        /// Amount of Carbohydrates consumed on this day
        /// </summary>
        public float Carbohydrates { get; set; }
        /// <summary>
        /// Amount of Fat consumed on this day
        /// </summary>
        public float Fat { get; set; }
        /// <summary>
        /// Amount of Fiber consumed on this day
        /// </summary>
        public float Fiber { get; set; }
        /// <summary>
        /// Amount of Suger consumed on this day
        /// </summary>
        public float IncludingSugars { get; set; }

        #endregion


        #region Helper Properties

        /// <summary>
        /// String containing full date and it's day of a week
        /// </summary>
        public string Displayer
        {
            get
            {
                string output = "";

                if (Date.Day < 10)
                {
                    output += "0";
                }
                output += Date.Day + ".";

                if (Date.Month < 10)
                {
                    output += "0";
                }
                output += Date.Month + "." + Date.Year;

                output += "     " + Date.DayOfWeek.ToString();

                return output;
            }
        }

        #endregion 

        #region Methods

        /// <summary>
        /// Compares the Date'a year, month and day with listed values of another date 
        /// </summary>
        /// <param name="date2">A DateTime oject to compare with</param>
        /// <returns>True when year, month and day are all matching</returns>
        public bool CompareDates(DateTime date2)
        {
            if(Date.Day == date2.Day && Date.Month == date2.Month && Date.Year == date2.Year)
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}
