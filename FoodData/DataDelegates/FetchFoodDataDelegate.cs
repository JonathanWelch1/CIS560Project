using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class FetchFoodDataDelegate : DataReaderDelegate<Food>
    {
        private readonly int FoodId;

        public FetchFoodDataDelegate(int FoodId)
            :base("Food.FetchFood")
        {
            this.FoodId = FoodId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("FoodId", SqlDbType.Int);
            p.Value = FoodId;
        }

        public override Food Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(FoodId.ToString());

            return new Food(FoodId,
               reader.GetString("Name");
        }
    }
}
