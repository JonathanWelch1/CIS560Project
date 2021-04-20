using System;
using System.Collections.Generic;
using System.Text;
using FoodData.Model;
using FoodData.DataDelegates;

namespace FoodData
{
    public class SqlFoodRepository : IFoodRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlFoodRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Food CreateFood(int CategoryId, string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Name));

            var d = new CreateFoodDataDelegate(Name);
            return executor.ExecuteNonQuery(d);
        }

        public Food FetchFood(int foodId)
        {
            var d = new FetchFoodDataDelegate(foodId);
            return executor.ExecuteReader(d);
        }

        public Food GetFood(string Name)
        {
            var d = new GetFoodDataDelegate(Name);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Food> RetrieveFoods()
        {
            return executor.ExecuteReader(new RetrieveFoodsDataDelegate());
        }
    }
}
