using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.Model;
using System.Data;
using System.Data.SqlClient;


namespace FoodData.DataDelegates
{
    internal class FetchFoodDataDelegate : DataReaderDelegate<Food>
    {
        private readonly int FoodId;
        private readonly int CategoryId;

        public FetchFoodDataDelegate(int FoodId, int CategoryId)
            :base("Food.FetchFood")
        {
            this.FoodId = FoodId;
            this.CategoryId = CategoryId;
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

            return new Food(FoodId, CategoryId,
               reader.GetString("Name"));
        }
    }
}
