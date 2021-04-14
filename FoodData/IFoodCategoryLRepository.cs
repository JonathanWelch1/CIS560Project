using System;
using System.Collections.Generic;
using FoodData.Model;

namespace FoodData
{
    public interface IFoodCategoryLRepository
    {

        FoodCategoryL CreateFoodCategory(int categoryID, int foodID);
    }
}
