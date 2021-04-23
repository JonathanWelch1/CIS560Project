using System;
using System.Collections.Generic;
using FoodData.Model;

namespace FoodData
{
    public interface IMeasurementRepository
    {
        IReadOnlyList<Measurement> RetrieveMeasurement();

        Measurement FetchMeasurement(int measurementID, int NutrientId, int FoodId);

        Measurement GetMeasurement(string unitMeasurement);

        Measurement CreateMeasurement(int nutrientID, int foodID, int measurementID, string unitMeasurement);
    }

}
