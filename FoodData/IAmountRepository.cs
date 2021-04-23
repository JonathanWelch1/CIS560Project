using System;
using System.Collections.Generic;
using FoodData.Model;

namespace FoodData
{
    public interface IAmountRepository
    {
        IReadOnlyList<Amount> RetrieveAmount();


        Amount CreateAmount(int measurementID, int nutrientID, int foodID, int amountNum);
    }
}
