using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.Model;
using FoodData.DataDelegates;

namespace FoodData
{
    public class SqlFoodCategoryRepository : IFoodCategoryLRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlFoodCategoryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public void CreateFoodCategory(int CategoryId, int FoodId)
        {
            var d = new CreateFoodCategoryDataDelegate(CategoryId, FoodId);
            return executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<FoodCategoryL> RetreiveFoodCategories(int FoodId)
        {
            return executor.ExecuteReader(new RetrieveFoodCategoriesDataDelegate(FoodId));
        }
    }
}
