using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodData.Model;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class CreateFoodCategoryDataDelegate : NonQueryDataDelegate<FoodCategoryL>
    {
        private readonly int CategoryId;
        private readonly int FoodId;

        public CreateFoodCategoryDataDelegate(int CategoryId, int FoodId)
            : base("FoodCategory.CreateFoodCategory")
        {
            this.CategoryId = CategoryId;
            this.FoodId = FoodId;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CategoryId", SqlDbType.Int);
            p.Value = CategoryId;

            p = command.Parameters.Add("FoodId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override FoodCategoryL Translate(SqlCommand command)
        {
            return new FoodCategoryL((int)command.Parameters["CategoryId"].Value, (int)command.Parameters["FoodId"].Value);
        }
    }
}
