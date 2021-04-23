using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.Model;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class RetrieveCategoryDataDelegate : DataReaderDelegate<IReadOnlyList<Category>>
    {
        public RetrieveCategoryDataDelegate()
         : base("Category.RetrieveCategory")
        {
        }

        public override IReadOnlyList<Category> Translate(SqlCommand command, IDataRowReader reader)
        {
            var categories = new List<Category>();

            while (reader.Read())
            {
                categories.Add(new Category(
                   reader.GetInt32("CategoryId"),
                   reader.GetString("CategoryName")));
            }

            return categories;
        }
    }
}
