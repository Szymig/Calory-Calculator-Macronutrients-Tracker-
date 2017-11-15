using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryCalculatorLibrary.Models
{
    public class DailyEntryModel
    {
        #region Main Properties

        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Consumed Meal (this or Product)
        /// </summary>
        public MealModel Meal { get; set; }

        /// <summary>
        /// Consumed Product (this or Meal)
        /// </summary>
        public ProductModel Product { get; set; }
        /// <summary>
        /// Mass of product ( -1 If Product is not specified and Meal is)
        /// </summary>
        public float Mass { get; set; }
        /// <summary>
        /// Quantity of product ( -1 If Product is not specified and Meal is)
        /// </summary>
        public int Units { get; set; }

        #endregion

        #region Macronutrients Properties

        /// <summary>
        /// Amount of Calories consumed in this entry
        /// </summary>
        public float Calories { get; set; }
        /// <summary>
        /// Amount of Protein consumed in this entry
        /// </summary>
        public float Protein { get; set; }
        /// <summary>
        /// Amount of Carbohydrates consumed in this entry
        /// </summary>
        public float Carbohydrates { get; set; }
        /// <summary>
        /// Amount of Fat consumed in this entry
        /// </summary>
        public float Fat { get; set; }
        /// <summary>
        /// Amount of Fiber consumed in this entry
        /// </summary>
        public float Fiber { get; set; }
        /// <summary>
        /// Amount of Suger consumed in this entry
        /// </summary>
        public float IncludingSugars { get; set; }

        #endregion


        #region Helper Properties

        /// <summary>
        /// Simple string representing the products name, mass and quantity if is not equal to 0
        /// </summary>
        public string InfoProduct
        {
            get
            {
                string output = Product.Name + " - " + Mass + "g ";
                if (Units > 0)
                {
                    output += "(" + Units + " units)";
                }
                return output;
            }
        }

        /// <summary>
        /// Name to display based on the meal or product specified in DailyEntryModel
        /// </summary>
        public string DisplayedName
        {
            get
            {
                if (Meal == null && Product != null)
                {
                    return Product.Name;
                }
                else if (Meal != null)
                {
                    return Meal.Name;
                }
                else
                {
                    return "Error";
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates Macronutrients base on the meal, or the product's mass
        /// </summary>
        public void CalculateMacronutrients()
        {
            // If the product is specified and the meal is not
            // Calulates macronutriens based on product and it's mass
            // If the meal is specified uses it
            if(Product != null && Meal == null)
            {
                Calories = Product.Calories * Mass / 100;
                Carbohydrates= Product.Carbohydrates * Mass / 100;
                IncludingSugars = Product.IncludingSugars * Mass / 100;
                Protein = Product.Protein * Mass / 100;
                Fat = Product.Fat * Mass / 100;
                Fiber = Product.Fiber * Mass / 100;
            }
            else if(Meal != null)
            {
                Calories = Meal.Calories;
                Carbohydrates = Meal.Carbohydrates;
                IncludingSugars = Meal.IncludingSugars;
                Protein = Meal.Protein;
                Fat = Meal.Fat;
                Fiber = Meal.Fiber;
            }
        }

        #endregion
    }
}
