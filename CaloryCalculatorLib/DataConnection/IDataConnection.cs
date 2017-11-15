using CaloryCalculatorLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryCalculatorLibrary
{
    public interface IDataConnection
    {
        ProductModel CreateProduct(ProductModel model);
        List<ProductModel> GetAllProducts();
        ProductModel EditProduct(ProductModel model);
        void DeleteProduct(ProductModel model);

        MealModel CreateMeal(MealModel model);
        List<MealModel> GetAllMeals();
        MealModel EditMeal(MealModel model);
        void DeleteMeal(MealModel model);

        DailyEntryModel CreateDailyEntry(DailyEntryModel model);
        List<DailyEntryModel> GetAllDailyEntries();
        void DeleteDailyEntry(DailyEntryModel model);
        void DeleteAllDailyEntries();

        DayModel AddDayToHistory(DayModel model);
        List<DayModel> GetAllDays();
        void OverwriteDay(DayModel model);
        void DeleteDay(DayModel model);
        void ClearHistory();
    }
}
