using System;
using System.Collections.Generic;
using System.Text;

namespace FoodData.Model
{
    public class Measurement
    {

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
        public int MeasurementID { get; }
        /// <summary>
        /// getter
        /// </summary>
        public string UnitMeasurement { get; }
        /// <summary>
        /// Constructor that sets the values
        /// </summary>
        /// <param name="nutrientID"></param>
        /// <param name="foodID"></param>
        /// <param name="measurementID"></param>
        /// <param name="unitMeasurement"></param>
        public Measurement(int nutrientID, int foodID, int measurementID, string unitMeasurement)
        {
            NutrientID = nutrientID;
            FoodID = foodID;
            MeasurementID = measurementID;
            UnitMeasurement = unitMeasurement;
        }
    }
}
