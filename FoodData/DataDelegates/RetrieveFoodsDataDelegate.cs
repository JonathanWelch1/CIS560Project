using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class RetrieveFoodsDataDelegate : DataReaderDelegate<IReadOnlyList<Food>>
    {
        public RetrieveFoodsDataDelegate()
         : base("Food.RetrieveFoods")
        {
        }

        public override IReadOnlyList<Food> Translate(SqlCommand command, IDataRowReader reader)
        {
            var foods = new List<Food>();

            while (reader.Read())
            {
                foods.Add(new Food(
                   reader.GetInt32("FoodId"),
                   reader.GetString("Name")));
            }

            return foods;
        }
    }
}
