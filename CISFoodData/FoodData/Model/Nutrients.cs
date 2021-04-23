using System;
using System.Collections.Generic;
using System.Text;

namespace FoodData.Model
{
    public class Nutrients
    {
        /// <summary>
        /// getter
        /// </summary>
        public int MeasurementID { get; }
        /// <summary>
        /// getter
        /// </summary>
        public int FoodID { get; }
        /// <summary>
        /// getter
        /// </summary>
        public int NutrientID { get; }
        /// <summary>
        /// getter
        /// </summary>
        public string NutrientName { get; }
        /// <summary>
        /// Constructor that sets the values
        /// </summary>
        /// <param name="measurementID"></param>
        /// <param name="foodID"></param>
        /// <param name="nutrientID"></param>
        /// <param name="nutrientName"></param>
        public Nutrients(int measurementID, int foodID, int nutrientID, string nutrientName)
        {
            MeasurementID = measurementID;
            FoodID = foodID;
            NutrientID = nutrientID;
            NutrientName = nutrientName;
        }
    }
}
