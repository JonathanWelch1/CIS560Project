﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodData.Model
{
    public class Category
    {
        /// <summary>
        /// getter
        /// </summary>
        public int CategoryID { get; }

        /// <summary>
        /// Constructor that sets the values
        /// </summary>
        /// <param name="categoryID"></param>
        public Category(int categoryID)
        {
            CategoryID = categoryID;
        }

    }
}