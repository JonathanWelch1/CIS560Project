using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using FoodData.Model;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class RetrieveFoodCategoriesDataDelegate : DataReaderDelegate<IReadOnlyList<FoodCategoryL>>
    {
        private readonly int FoodId;

        public RetrieveFoodCategoriesDataDelegate(int FoodId)
            : base("FoodCategoryL.RetrieveFoodCategories")
        {
            this.FoodId = FoodId;
        }

        public override IReadOnlyList<FoodCategoryL> Translate(SqlCommand command, IDataRowReader reader)
        {
            var foodCat = new List<FoodCategoryL>();

            while (reader.Read())
            {
                foodCat.Add(new FoodCategoryL(
                   reader.GetInt32("CategoryId"),
                   FoodId));
            }

            return foodCat;
        }
    }
}
