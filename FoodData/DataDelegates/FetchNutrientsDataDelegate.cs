using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.Model;
using System.Data;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class FetchNutrientsDataDelegate : DataReaderDelegate<Nutrients>
    {
        private readonly int NutrientId;
        private readonly int FoodId;
        private readonly int MeasurementId;

        public FetchNutrientsDataDelegate(int NutrientId, int FoodId, int MeasurmentId)
         : base("Nutrients.FetchNutrients")
        {
            this.NutrientId = NutrientId;
            this.FoodId = FoodId;
            this.MeasurementId = MeasurmentId;
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

        public override Nutrients Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(NutrientId.ToString());

            return new Nutrients(MeasurementId, FoodId, NutrientId,
               reader.GetString("nutrientName"));
        }
    }
}
