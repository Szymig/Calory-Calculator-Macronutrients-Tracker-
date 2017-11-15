using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryCalculatorLibrary.Models
{
    public class IngredientModel
    {
        #region Main Properties

        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product on with the Ingredient is based
        /// </summary>
        public ProductModel Product { get; set; }

        /// <summary>
        /// Mass of the product 
        /// </summary>
        public float Mass { get; set; }

        /// <summary>
        /// Quantity of the product (-1 if cann't be or isn't determined)
        /// </summary>
        public int Units { get; set; }

        #endregion


        #region Helper Properties

        /// <summary>
        /// Name, mass and quantity (if is greater than 0) of the product
        /// </summary>
        public string NameAndMass{
            get
            {
                string output = Product.Name + "  -  " + Mass + "g ";
                if (Units > 0)
                {
                    output += "(" + Units + " units)";
                }
                return  output;
            }
        }

        #endregion
    }
}
