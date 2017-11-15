using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaloryCalculatorLibrary.Models;
using System.Data;
using Dapper;

namespace CaloryCalculatorLibrary
{
    class SQLConnection : IDataConnection
    {
        //Conection string name
        private static string dbName = "CaloryCalculatorLocal";

        /// <summary>
        /// Adds new product to database
        /// </summary>
        /// <param name="model">New product to be added</param>
        /// <returns></returns>
        public ProductModel CreateProduct(ProductModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Categoty", (int)model.Category);
                p.Add("@Name", model.Name);
                p.Add("@Calories", model.Calories);
                p.Add("@Carbohydrates", model.Carbohydrates);
                p.Add("@IncludingSugars", model.IncludingSugars);
                p.Add("Proteins", model.Protein);
                p.Add("@Fat", model.Fat);
                p.Add("@Fiber", model.Fiber);
                p.Add("@OneUnitMass", model.OneUnitMass);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spProducts_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }

            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> output = new List<ProductModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                output = connection.Query<ProductModel>("dbo.spProducts_GetAll").ToList();
            }

            return output;
        }

        public ProductModel EditProduct(ProductModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@id", model.Id);
                p.Add("@Categoty", (int)model.Category);
                p.Add("@Name", model.Name);
                p.Add("@Calories", model.Calories);
                p.Add("@Carbohydrates", model.Carbohydrates);
                p.Add("@IncludingSugars", model.IncludingSugars);
                p.Add("Proteins", model.Protein);
                p.Add("@Fat", model.Fat);
                p.Add("@Fiber", model.Fiber);
                p.Add("@OneUnitMass", model.OneUnitMass);

                connection.Execute("dbo.spProducts_UpdateById", p, commandType: CommandType.StoredProcedure);
            }

            return model;
        }

        public void DeleteProduct(ProductModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@id", model.Id);

                connection.Execute("dbo.spProducts_DeleteById", p, commandType: CommandType.StoredProcedure);
            }
        }




        public MealModel CreateMeal(MealModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@Name", model.Name);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spMeals_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                foreach (IngredientModel ing in model.Ingredients)
                {
                    DynamicParameters s = new DynamicParameters();

                    s.Add("@ProductId", ing.Product.Id);
                    s.Add("@MealId", model.Id);
                    s.Add("@Mass", ing.Mass);
                    s.Add("@Units", ing.Units);
                    s.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spIngredients_Insert", s, commandType: CommandType.StoredProcedure);

                    ing.Id = s.Get<int>("@id");
                }
            }

            return model;

        }

        public List<MealModel> GetAllMeals()
        {
            List<MealModel> output = new List<MealModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                output = connection.Query<MealModel>("dbo.spMeals_GetAll").ToList();

                foreach (MealModel m in output)
                {
                    DynamicParameters p = new DynamicParameters();

                    p.Add("@MealId", m.Id);

                    //IMPORTANT
                    m.Ingredients = connection.Query<IngredientModel, ProductModel, IngredientModel>
                        ("dbo.spIngredients_GetByMeal", (ingredient, product) => 
                        { ingredient.Product = product; return ingredient; } ,
                        p, commandType: CommandType.StoredProcedure).ToList();

                    m.CalculateMacronutrients();
                }
            }

            return output;
        }

        public MealModel EditMeal(MealModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@id", model.Id);
                p.Add("@Name", model.Name);
                
                connection.Execute("dbo.spMeals_UpdateById", p, commandType: CommandType.StoredProcedure);

                p = new DynamicParameters();
                p.Add("@MealId", model.Id);

                connection.Execute("dbo.spIngredients_DeleteByMealId", p, commandType: CommandType.StoredProcedure);

                foreach (IngredientModel ing in model.Ingredients)
                {
                    DynamicParameters s = new DynamicParameters();

                    s.Add("@ProductId", ing.Product.Id);
                    s.Add("@MealId", model.Id);
                    s.Add("@Mass", ing.Mass);
                    s.Add("@Units", ing.Units);
                    s.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spIngredients_Insert", s, commandType: CommandType.StoredProcedure);

                    ing.Id = s.Get<int>("@id");
                }

            }

            return model;
        }

        public void DeleteMeal(MealModel model)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@MealId", model.Id);

                connection.Execute("dbo.spIngredients_DeleteByMealId", p, commandType: CommandType.StoredProcedure);

                p = new DynamicParameters();
                p.Add("@id", model.Id);

                connection.Execute("dbo.spMeals_DeleteById", p, commandType: CommandType.StoredProcedure);
            }
        }





        public DailyEntryModel CreateDailyEntry(DailyEntryModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                DynamicParameters p = new DynamicParameters();

                if(model.Meal == null)
                {
                    p.Add("@MealId", null);
                    p.Add("@ProductId", model.Product.Id);
                    p.Add("@Mass", model.Mass);
                    p.Add("@Units", model.Units);
                }
                else
                {
                    p.Add("@MealId", model.Meal.Id);
                    p.Add("@ProductId", null);
                    p.Add("@Mass", null);
                    p.Add("@Units", null);
                }

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDailyConsumption_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");                
            }

            return model;
        }

        public List<DailyEntryModel> GetAllDailyEntries()
        {
            List<DailyEntryModel> output = new List<DailyEntryModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {

                output = connection.Query<DailyEntryModel, ProductModel, MealModel, DailyEntryModel>("dbo.spDailyConsumption_GetAll",
                    (dailyEntry, product, meal) => { dailyEntry.Product = product; dailyEntry.Meal = meal; return dailyEntry; }, commandType: CommandType.StoredProcedure).ToList();

                foreach (DailyEntryModel de in output)
                {
                    if(de.Meal != null)
                    {
                        DynamicParameters p = new DynamicParameters();

                        p.Add("@MealId", de.Meal.Id);

                        //IMPORTANT
                        de.Meal.Ingredients = connection.Query<IngredientModel, ProductModel, IngredientModel>
                            ("dbo.spIngredients_GetByMeal", (ingredient, product) =>
                            { ingredient.Product = product; return ingredient; },
                            p, commandType: CommandType.StoredProcedure).ToList();
                        de.Meal.CalculateMacronutrients();
                    }
                }
            }

            return output;
        }

        public void DeleteDailyEntry(DailyEntryModel model)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@id", model.Id);

                connection.Execute("dbo.spDailyConsumption_DeleteById", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteAllDailyEntries()
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                connection.Execute("dbo.spDailyConsumption_DeleteAll", commandType: CommandType.StoredProcedure);
            }
        }




        

        public DayModel AddDayToHistory(DayModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                DynamicParameters p = new DynamicParameters();
                p.Add("@Date", model.Date);
                p.Add("@Calories", model.Calories);
                p.Add("@Carbohydrates", model.Carbohydrates);
                p.Add("@IncludingSugars", model.IncludingSugars);
                p.Add("Proteins", model.Protein);
                p.Add("@Fat", model.Fat);
                p.Add("@Fiber", model.Fiber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDays_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }

            return model;
        }
        
        public List<DayModel> GetAllDays()
        {
            List<DayModel> output = new List<DayModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                output = connection.Query<DayModel>("dbo.spDays_GetAll").ToList();
            }

            return output;
        }

        public void OverwriteDay(DayModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@id", model.Id);
                p.Add("@Date", model.Date);
                p.Add("@Calories", model.Calories);
                p.Add("@Carbohydrates", model.Carbohydrates);
                p.Add("@IncludingSugars", model.IncludingSugars);
                p.Add("Proteins", model.Protein);
                p.Add("@Fat", model.Fat);
                p.Add("@Fiber", model.Fiber);

                connection.Execute("dbo.spDays_UpdateById", p, commandType: CommandType.StoredProcedure);
            }

        }

        public void DeleteDay(DayModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                DynamicParameters p = new DynamicParameters();

                p.Add("@id", model.Id);

                connection.Execute("dbo.spDays_DeleteById", p, commandType: CommandType.StoredProcedure);
            }
        }
        
        public void ClearHistory()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(dbName)))
            {
                connection.Execute("dbo.spDays_DeleteAll", commandType: CommandType.StoredProcedure);
            }
        }
    }
}

