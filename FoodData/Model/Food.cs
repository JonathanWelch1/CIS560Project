using System;
using System.Collections.Generic;
using System.Text;

namespace FoodData.Model
{
    public class Food
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
        /// getter
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Constructor that sets the values
        /// </summary>
        /// <param name="categoryID"></param>
        /// <param name="foodID"></param>
        /// <param name="name"></param>
        public Food(int categoryID, int foodID, string name)
        {
            CategoryID = categoryID;
            FoodID = foodID;
            Name = name;
        }

    }
}
