using System;
using System.Collections.Generic;
using FoodData.Model;

namespace FoodData
{
    public interface INutrientsRepository
    {

        Nutrients CreateNutrient(int measurementID, int foodID, int nutrientID, string nutrientName);
    }
}
