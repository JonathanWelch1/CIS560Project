﻿using System;
using System.Collections.Generic;
using FoodData.Model;

namespace FoodData
{
    public interface INutrientsRepository
    {

        IReadOnlyList<Nutrients> RetrieveNutrients();

        Nutrients FetchNutrients(int nutrientID);

        Nutrients GetNutrients(string nutrientName);

        Nutrients CreateNutrient(int measurementID, int foodID, int nutrientID, string nutrientName);
    }
}
