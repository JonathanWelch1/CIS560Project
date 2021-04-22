using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.Model;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class GetCategoryDataDelegate : DataReaderDelegate<Category>
    {
        private readonly string CategoryName;

        public GetCategoryDataDelegate(string CategoryName)
         : base("Category.GetCategory")
        {
            this.CategoryName = CategoryName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("CategoryName", CategoryName);
        }

        public override Category Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Category(
               reader.GetInt32("CategoryId"),
               CategoryName);
        }
    }
}
