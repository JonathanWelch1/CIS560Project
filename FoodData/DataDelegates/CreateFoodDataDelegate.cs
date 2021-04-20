using System.Collections.Generic;
using System.Text;
using FoodData.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class CreateFoodDataDelegate : NonQueryDataDelegate<Food>
    {
        //public readonly int CategoryId;
        //public readonly int FoodId;
        public readonly string Name;

        public CreateFoodDataDelegate(string Name)
            :base("Food.CreateFood")
        {
            //this.CategoryId = CategoryId;
            //this.FoodId = FoodId;
            this.Name = Name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            //var p = command.Parameters.Add("CategoryId", SqlDbType.Int);
            //p.Value = CategoryId;

            //p = command.Parameters.Add("FoodId", SqlDbType.Int);
            //p.Value = FoodId;

            var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
            p.Value = Name;

            p = command.Parameters.Add("FoodId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Food Translate(SqlCommand command)
        {
            return new Food((int)command.Parameters["FoodId"].Value, Name);
        }
    }
}
