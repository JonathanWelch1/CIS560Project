using System;
using System.Collections.Generic;
using System.Text;
using FoodData.Model;
using FoodData.DataDelegates;
using DataAccess;

namespace FoodData
{
    class SqlNutrientsRepository : INutrientsRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlNutrientsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Nutrients CreateNutrient(int measurementID, int foodID, int nutrientID, string nutrientName)
        {
            if (string.IsNullOrWhiteSpace(nutrientName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(nutrientName));

            var d = new CreateNutrientDataDelegate(foodID, measurementID, nutrientName);
            return executor.ExecuteNonQuery(d);
        }

        public Nutrients FetchNutrients(int NutrientId)
        {
            var d = new FetchNutrientsDataDelegate(NutrientId);
            return executor.ExecuteReader(d);
        }

        public Nutrients GetNutrients(string NutrientName)
        {
            var d = new GetNutrientsDataDelegate(NutrientName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Nutrients> RetrieveNutrients()
        {
            return executor.ExecuteReader(new RetrieveNutrientsDataDelegate());
        }
    }
}
