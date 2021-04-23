﻿using System;
using System.Collections.Generic;
using System.Text;
using FoodData.Model;
using FoodData.DataDelegates;
using DataAccess;

namespace FoodData
{
    public class SqlMeasurementRepository : IMeasurementRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlMeasurementRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Measurement CreateMeasurement(int nutrientID, int foodID, int measurementID, string unitMeasurement)
        {
            if (string.IsNullOrWhiteSpace(unitMeasurement))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(unitMeasurement));

            var d = new CreateMeasurementDataDelegate(foodID, nutrientID, unitMeasurement);//check translate table
            return executor.ExecuteNonQuery(d);
        }

        public Measurement FetchMeasurement(int MeasurementId, int NutrientId, int FoodId)
        {
            var d = new FetchMeasurementDataDelegate(NutrientId, FoodId, MeasurementId);//delegate done
            return executor.ExecuteReader(d);
        }

        public Measurement GetMeasurement(string UnitMeasurement)
        {
            var d = new GetMeasurementDataDelegate(UnitMeasurement);//delegate done
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Measurement> RetrieveMeasurement()
        {
            return executor.ExecuteReader(new RetrieveMeasurementDataDelegate());//delegate done
        }
    }
}