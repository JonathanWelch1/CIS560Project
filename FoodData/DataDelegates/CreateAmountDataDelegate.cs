using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Data.SqlClient;
using FoodData.Model;
using System.Data;

namespace FoodData.DataDelegates
{
    internal class CreateAmountDataDelegate : NonQueryDataDelegate<Amount>
    {
        private readonly int MeasurementId;
        private readonly int NutrientId;
        private readonly int FoodId;
        private readonly int AmountNum;

        public CreateAmountDataDelegate(int MeasurementId, int NutrientId, int FoodId, int amountNum)
            :base("Amount.CreateAmount")
        {
            this.MeasurementId = MeasurementId;
            this.NutrientId = NutrientId;
            this.FoodId = FoodId;
            this.AmountNum = amountNum;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("MeasurementId", SqlDbType.Int);
            p.Value = MeasurementId;

            p = command.Parameters.Add("NutrientId", SqlDbType.Int);
            p.Value = NutrientId;

            p = command.Parameters.Add("FoodId", SqlDbType.Int);
            p.Value = FoodId;

            p = command.Parameters.Add("AmountNum", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Amount Translate(SqlCommand command)
        {
            return new Amount((int)command.Parameters["MeasurementId"].Value, (int)command.Parameters["NutrientId"].Value, (int)command.Parameters["FoodId"].Value, (int)command.Parameters["AmountNum"].Value);
        }
    }
}
