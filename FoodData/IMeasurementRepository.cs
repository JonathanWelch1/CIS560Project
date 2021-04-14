using System;
using System.Collections.Generic;
using FoodData.Model;

namespace FoodData
{
    public interface IMeasurementRepository
    {

        Measurement CreateMeasurement(int nutrientID, int foodID, int measurementID, string unitMeasurement);
    }

}
