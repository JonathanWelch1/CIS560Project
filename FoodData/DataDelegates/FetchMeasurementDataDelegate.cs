using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.Model;
using System.Data;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class FetchMeasurementDataDelegate : DataReaderDelegate<Measurement>
    {
        private readonly int FoodId;
        private readonly int NutrientId;
        private readonly int MeasurementId;

        public FetchMeasurementDataDelegate(int NutrientId, int FoodId, int MeasurementId)
         : base("Measurement.FetchMeasurement")
        {
            this.NutrientId = NutrientId;
            this.FoodId = FoodId;
            this.MeasurementId = MeasurementId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("NutrientId", SqlDbType.Int);
            p.Value = NutrientId;

            p = command.Parameters.Add("FoodId", SqlDbType.Int);
            p.Value = FoodId;

            p = command.Parameters.Add("MeasurementId", SqlDbType.Int);
            p.Value = MeasurementId;
        }

        public override Measurement Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(MeasurementId.ToString());

            return new Measurement(FoodId, NutrientId, MeasurementId,
               reader.GetString("unitMeasurement"));
        }
}
