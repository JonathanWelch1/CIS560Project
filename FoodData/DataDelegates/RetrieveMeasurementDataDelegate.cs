using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.Model;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class RetrieveMeasurementDataDelegate : DataReaderDelegate<IReadOnlyList<Measurement>>
    {
        public RetrieveMeasurementDataDelegate()
         : base("Measurement.RetrieveMeasurement")
        {
        }

        public override IReadOnlyList<Measurement> Translate(SqlCommand command, IDataRowReader reader)
        {
            var measurement = new List<Measurement>();

            while (reader.Read())
            {
                measurement.Add(new Measurement(
                   reader.GetInt32("NutrientId"),
                   reader.GetInt32("FoodId"),
                   reader.GetInt32("MeasurementId"),
                   reader.GetString("unitMeasurement")));
            }

            return measurement;
        }
    }
}
