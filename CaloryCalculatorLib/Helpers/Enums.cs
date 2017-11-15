using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryCalculatorLibrary
{
    /// <summary>
    /// Available product categories
    /// </summary>
    public enum ProductCategory
    {
        Drink, Dairy, Meat, Vegetable, Fruit, Grain, Baking, Sweets, Other, Seeds, Nuts, Oils, Count
    }

    /// <summary>
    /// Available Database Types
    /// </summary>
    public enum DatabaseType
    {
        SQLite, SQLServer
    }

}
