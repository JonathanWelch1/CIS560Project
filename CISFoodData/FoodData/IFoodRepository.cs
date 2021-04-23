using System;
using System.Collections.Generic;
using FoodData.Model;

namespace FoodData
{
    public interface IFoodRepository
    {
        IReadOnlyList<Food> RetrieveFoods();

        Food FetchFood(int foodID);

        Food GetFood(string name);

        Food CreateFood(int categoryID, int foodID, string name);
    }
}
