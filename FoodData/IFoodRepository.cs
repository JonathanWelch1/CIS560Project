﻿using System;
using System.Collections.Generic;
using FoodData.Model;

namespace FoodData
{
    public interface IFoodRepository
    {

        Food CreateFood(int categoryID, int foodID, string name);
    }
}
