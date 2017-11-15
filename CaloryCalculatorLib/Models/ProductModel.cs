using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryCalculatorLibrary.Models
{
    public class ProductModel
    {
        #region Main Properties

        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// One of hardcoded categories (see Enums.cs)
        /// </summary>
        public ProductCategory Category { get; set; }

        /// <summary>
        /// Average mass of one unit of the product
        /// equals -1 if can not be tell
        /// </summary>
        public int OneUnitMass { get; set; }

        #endregion

        #region Macronutrients Properties

        /// <summary>
        /// Amount of Calories in this product
        /// </summary>
        public float Calories { get; set; }
        /// <summary>
        /// Amount of Protein in this product
        /// </summary>
        public float Protein { get; set; }
        /// <summary>
        /// Amount of Carbohydrates in this product
        /// </summary>
        public float Carbohydrates { get; set; }
        /// <summary>
        /// Amount of Fat in this product
        /// </summary>
        public float Fat { get; set; }
        /// <summary>
        /// Amount of Fiber in this product
        /// </summary>
        public float Fiber { get; set; }
        /// <summary>
        /// Amount of Suger in this product
        /// </summary>
        public float IncludingSugars { get; set; }

        #endregion
    }
}
