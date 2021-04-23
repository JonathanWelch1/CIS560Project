using System;
using System.Collections.Generic;
using System.Text;
using FoodData.Model;
using DataAccess;
using System.Data.SqlClient;
using System.Data; 

namespace FoodData.DataDelegates
{
    internal class CreateCategoryDataDelegate : NonQueryDataDelegate<Category>
    {
        private readonly int CategoryId;
        private readonly string CategoryName;

        public CreateCategoryDataDelegate(int CategoryId, string CategoryName)
            : base("Category.CreateCategory")
        {
            this.CategoryId = CategoryId;
            this.CategoryName = CategoryName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CategoryName", SqlDbType.NVarChar);
            p.Value = CategoryName;

            p = command.Parameters.Add("CategoryId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Category Translate(SqlCommand command)
        {
            return new Category((int)command.Parameters["CategoryId"].Value, CategoryName);
        }
    }
}
