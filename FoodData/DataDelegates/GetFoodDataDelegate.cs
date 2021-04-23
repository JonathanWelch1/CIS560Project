using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DataAccess;
using FoodData.Model;

namespace FoodData.DataDelegates
{
    internal class GetFoodDataDelegate : DataReaderDelegate<Food>
    {
        private readonly string Name;

        public GetFoodDataDelegate(string Name)
            :base("Food.GetFood")
        {
            this.Name = Name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", Name);
        }

        public override Food Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Food(
               reader.GetInt32("CategoryID"),
               reader.GetInt32("FoodId"),
               reader.GetString("Name"));
        }
    }
}
