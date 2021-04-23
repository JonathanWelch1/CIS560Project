using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.DataDelegates;
using FoodData.Model;

namespace FoodData
{
    public class SqlAmountRepository : IAmountRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlAmountRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Amount CreateAmount(int MeasurementId, int NutrientId, int FoodId, int amountNum)
        {
            var d = new CreateAmountDataDelegate(MeasurementId, NutrientId, FoodId, amountNum);
            return executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<Amount> RetrieveAmount()
        {
            return executor.ExecuteReader(new RetrieveAmountDataDelegate());
        }


    }
}
