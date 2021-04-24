using System;
using System.Collections.Generic;
using FoodData.Model;

namespace FoodData
{
    public interface IFoodCategoryLRepository
    {
        IReadOnlyList<FoodCategoryL> RetreiveFoodCategories(int FoodID);


        FoodCategoryL CreateFoodCategory(int categoryID, int foodID);
    }
}
