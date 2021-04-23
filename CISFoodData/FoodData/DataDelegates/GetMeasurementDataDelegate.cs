using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.Model;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class GetMeasurementDataDelegate : DataReaderDelegate<Measurement>
    {
        private readonly string unitMeasurement;

        public GetMeasurementDataDelegate(string unitMeasurement)
            :base("Measurement.GetMeasurement")
        {
            this.unitMeasurement = unitMeasurement;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("unitMeasurement", unitMeasurement);
        }

        public override Measurement Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Measurement(
               reader.GetInt32("NutrientId"),
               reader.GetInt32("FoodId"),
               reader.GetInt32("MeasurementId"),
               unitMeasurement);
        }
    }
}
