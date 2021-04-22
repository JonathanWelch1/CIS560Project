using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.Model;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    class RetrieveAmountDataDelegate : DataReaderDelegate<IReadOnlyList<Amount>>
    {
        public RetrieveAmountDataDelegate()
         : base("Amount.RetrieveAmount")
        {
        }

        public override IReadOnlyList<Amount> Translate(SqlCommand command, IDataRowReader reader)
        {
            var amounts = new List<Amount>();

            while (reader.Read())
            {
                amounts.Add(new Amount(
                   reader.GetInt32("MeasurementId"),
                   reader.GetInt32("NutrientId"),
                   reader.GetInt32("FoodId"),
                   reader.GetInt32("AmountNum")));
            }

            return amounts;
        }
    }
}
