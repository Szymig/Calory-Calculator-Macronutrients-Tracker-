using CaloryCalculatorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryCalculatorWinForms
{
    public interface IProductRequester
    {
        void CreatedProduct(ProductModel model);
    }
}
