using System;
using System.Collections.Generic;
using FoodData.Model;

namespace FoodData
{
    public interface IAmountRepository
    {

        Amount CreateAmount(int measurementID, int nutrientID, int foodID, int amountNum);
    }
}
