using System;
using System.Collections.Generic;
using System.Text;

namespace FoodData.Model
{
    public class FoodCategoryL
    {
        /// <summary>
        /// getter
        /// </summary>
        public int CategoryID { get; }
        /// <summary>
        /// getter
        /// </summary>
        public int FoodID { get; }
        /// <summary>
        /// Constructor that sets the values
        /// </summary>
        /// <param name="categoryID"></param>
        /// <param name="foodID"></param>
        public FoodCategoryL(int categoryID, int foodID)
        {
            CategoryID = categoryID;
            FoodID = foodID;
        }
    }
}
