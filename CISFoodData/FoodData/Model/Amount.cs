using System;
using System.Collections.Generic;
using System.Text;

namespace FoodData.Model
{
    public class Amount
    {
        /// <summary>
        /// getter
        /// </summary>
        public int MeasurementID { get; }
        /// <summary>
        /// getter
        /// </summary>
        public int NutrientID { get; }
        /// <summary>
        /// getter
        /// </summary>
        public int FoodID { get; }
        /// <summary>
        /// getter
        /// </summary>
        public int AmountNum { get; }
        /// <summary>
        /// Contructor that sets the values
        /// </summary>
        /// <param name="measurementID"></param>
        /// <param name="nutrientID"></param>
        /// <param name="foodID"></param>
        /// <param name="amountNum"></param>
        public Amount(int measurementID, int nutrientID, int foodID, int amountNum)
        {
            MeasurementID = measurementID;
            NutrientID = nutrientID;
            FoodID = foodID;
            AmountNum = amountNum;
        }
    }
}
