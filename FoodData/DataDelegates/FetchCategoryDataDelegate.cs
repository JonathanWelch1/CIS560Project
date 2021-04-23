using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.Model;
using System.Data.SqlClient;
using System.Data;

namespace FoodData.DataDelegates
{
    internal class FetchCategoryDataDelegate : DataReaderDelegate<Category>
    {
        private readonly int CategoryId;
        private readonly string CategoryName;
        public FetchCategoryDataDelegate(int CategoryId, string categoryName)
         : base("Person.FetchPerson")
        {
            this.CategoryId = CategoryId;
            this.CategoryName = categoryName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CategoryId", SqlDbType.Int);
            p.Value = CategoryId;
        }

        public override Category Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(CategoryId.ToString());

            return new Category(CategoryId,
               reader.GetString("CategoryName"));
        }
    }
}
