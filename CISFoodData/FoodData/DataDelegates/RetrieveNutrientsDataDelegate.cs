using System;
using System.Collections.Generic;
using System.Text;
using FoodData.DataAccess;
using FoodData.Model;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class RetrieveNutrientsDataDelegate : DataReaderDelegate<IReadOnlyList<Nutrients>>
    {
        public RetrieveNutrientsDataDelegate()
         : base("Nutrients.RetrieveNutrients")
        {
        }

        public override IReadOnlyList<Nutrients> Translate(SqlCommand command, IDataRowReader reader)
        {
            var nutrients = new List<Nutrients>();

            while (reader.Read())
            {
                nutrients.Add(new Nutrients(
                   reader.GetInt32("MeasurementId"),
                   reader.GetInt32("FoodId"),
                   reader.GetInt32("NutrientId"),
                   reader.GetString("NutrientName")));
            }

            return nutrients;
        }
    }
}
