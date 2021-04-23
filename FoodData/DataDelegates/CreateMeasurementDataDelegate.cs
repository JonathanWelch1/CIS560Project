using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using FoodData.Model;
using DataAccess;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class CreateMeasurementDataDelegate : NonQueryDataDelegate<Measurement>
    {
        public readonly int NutrientId;
        public readonly int FoodId;
        public readonly string unitMeasurement;
        public readonly int MeasurementID;

        public CreateMeasurementDataDelegate(int foodID, int nutrientID, int measurementID,string unitMeasurement)
            : base("Food.CreateFood")
        {
            this.FoodId = foodID;
            this.NutrientId = nutrientID;
            this.unitMeasurement = unitMeasurement;
            this.MeasurementID = measurementID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            SqlParameter p;
            p = command.Parameters.Add("FoodId", SqlDbType.Int);
            p = command.Parameters.Add("NutrientId", SqlDbType.Int);
            p = command.Parameters.Add("unitMeasurement", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Measurement Translate(SqlCommand command)
        {
            return new Measurement((int)command.Parameters["NutrientId"].Value, (int)command.Parameters["NutrientId"].Value, (int)command.Parameters["MeasurementID"].Value,unitMeasurement);
        }
    }
}
