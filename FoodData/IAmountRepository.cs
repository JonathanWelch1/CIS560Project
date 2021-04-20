using System;
using System.Collections.Generic;
using FoodData.Model;

namespace FoodData
{
    public interface IAmountRepository
    {
        IReadOnlyList<Amount> RetrieveAmount(int nutrientID);


        void CreateAmount(int measurementID, int nutrientID, int foodID, int amountNum);
    }
}
