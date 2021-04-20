using System;
using System.Collections.Generic;
using System.Text;
using FoodData.Model;
using FoodData.DataDelegates;

namespace FoodData
{
    class SqlNutrientsRepository : INutrientsRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlNutrientsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Nutrients CreatePerson(int FoodId, int MeasurementId, string NutrientName)
        {
            if (string.IsNullOrWhiteSpace(NutrientName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

            var d = new CreateNutrienstDataDelegate(FoodId, MeasurementId, NutrientName);
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

        public IReadOnlyList<Nutrients> RetrieveNutrientss()
        {
            return executor.ExecuteReader(new RetrieveNutrientsDataDelegate());
        }
    }
}
