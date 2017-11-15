using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryCalculatorLibrary
{
    public class Category
    {
        #region Main Properties

        /// <summary>
        /// ProductCategory enum value
        /// </summary>
        public ProductCategory ProdCategory { get; set; }
        
        /// <summary>
        /// Name of the category
        /// </summary>
        public string Name { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constuctor
        /// </summary>
        /// <param name="category"></param>
        public Category(ProductCategory category)
        {
            ProdCategory = category;
            Name = category.ToString();
            if (Name.Equals("Count"))
            {
                Name = "<All Categories>";
            }
        }

        #endregion
    }
}
