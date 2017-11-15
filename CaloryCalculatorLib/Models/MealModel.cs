using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryCalculatorLibrary.Models
{
    public class MealModel
    {
        #region Main Properties

        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of this meal
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// List of ingredients included in this meal
        /// </summary>
        public List<IngredientModel> Ingredients { get; set; }

        #endregion

        #region Macronutrients Properties

        /// <summary>
        /// Amount of Calories in this meal
        /// </summary>
        public float Calories { get; set; }
        /// <summary>
        /// Amount of Protein in this meal
        /// </summary>
        public float Protein { get; set; }
        /// <summary>
        /// Amount of Carbohydrates in this meal
        /// </summary>
        public float Carbohydrates { get; set; }
        /// <summary>
        /// Amount of Fat in this meal
        /// </summary>
        public float Fat { get; set; }
        /// <summary>
        /// Amount of Fiber in this meal
        /// </summary>
        public float Fiber { get; set; }
        /// <summary>
        /// Amount of Suger in this meal
        /// </summary>
        public float IncludingSugars { get; set; }

        #endregion


        #region Methods

        /// <summary>
        /// Calculates this meal macronutrients based on ingredient's macronutrients
        /// </summary>
        public void CalculateMacronutrients()
        {
            // Make sure values are equal to 0
            Calories = 0;
            Protein = 0;
            Carbohydrates = 0;
            Fat = 0;
            Fiber = 0;
            IncludingSugars = 0;

            // Foreach Ingredient it this meal
            // Add it's macronutriens to the meal macronutrients
            foreach (IngredientModel mod in Ingredients)
            {
                Calories += mod.Product.Calories / 100 * mod.Mass;
                Carbohydrates += mod.Product.Carbohydrates / 100 * mod.Mass;
                IncludingSugars += mod.Product.IncludingSugars / 100 * mod.Mass;
                Protein += mod.Product.Protein / 100 * mod.Mass;
                Fat += mod.Product.Fat / 100 * mod.Mass;
                Fiber += mod.Product.Fiber / 100 * mod.Mass;
            }
        }

        #endregion

    }
}
