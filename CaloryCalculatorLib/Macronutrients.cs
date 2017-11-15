using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaloryCalculatorLibrary.Models;

namespace CaloryCalculatorLibrary
{
    public class Macronutrients
    {
        /// <summary>
        /// Amount of Calories
        /// </summary>
        public float Calories { get; set; }
        /// <summary>
        /// Amount of Protein
        /// </summary>
        public float Protein { get; set; }
        /// <summary>
        /// Amount of Carbohydrates
        /// </summary>
        public float Carbohydrates { get ; set ; }
        /// <summary>
        /// Amount of Sugars
        /// </summary>
        public float IncludingSugars { get ; set ; }
        /// <summary>
        /// Amount of Fat
        /// </summary>
        public float Fat { get ; set ; }
        /// <summary>
        /// Amount of Fiber
        /// </summary>
        public float Fiber { get ; set ; }

        /// <summary>
        /// Sets all micronutrients to 0
        /// </summary>
        public void Reset()
        {
            Calories = 0;
            Protein = 0;
            Carbohydrates = 0;
            IncludingSugars = 0;
            Fat = 0;
            Fiber = 0;
        }
    }
}
