using System;
using System.Collections.Generic;
using System.Text;
using FoodData.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class CreateNutrientDataDelegate : NonQueryDataDelegate<Nutrients>
    {
        private readonly int FoodId;
        private readonly int MeasurementId;
        private readonly string NutrientName;

        public CreateNutrientDataDelegate(int foodID, int measurementID, string nutrientName)
        : base("Nutrient.CreateNutrient")
        {
            FoodId = foodID;
            MeasurementId = measurementID;
            NutrientName = nutrientName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("FoodId", SqlDbType.Int);
            p.Value = FoodId;

            p = command.Parameters.Add("MeasurementId", SqlDbType.Int);
            p.Value = MeasurementId;

            p = command.Parameters.Add("NutrientName", SqlDbType.NVarChar);
            p.Value = NutrientName;

            p.Direction = ParameterDirection.Output;
        }

        public override Nutrients Translate(SqlCommand command)
        {
            return new Nutrients((int)command.Parameters["MeasurementId"].Value, (int)command.Parameters["FoodId"].Value, (int)command.Parameters["NutrientId"].Value, NutrientName);
        }
    }
}
