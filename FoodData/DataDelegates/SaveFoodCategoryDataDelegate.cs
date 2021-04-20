using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace FoodData.DataDelegates
{
    internal class SaveFoodCategoryDataDelegate
    {
        private readonly int categoryId;
        private readonly string name;

        public SaveFoodCategoryDataDelegate(int categoryId, string name)
        {
            this.categoryId = categoryId;
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {

        }
    }
}
