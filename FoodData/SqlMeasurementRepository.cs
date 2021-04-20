using System;
using System.Collections.Generic;
using System.Text;
using FoodData.Model;
using FoodData.DataDelegates;

namespace FoodData
{
    public class SqlMeasurementRepository : IMeasurementRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlMeasurementRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Measurement CreateMeasurement(int FoodId, int NutrientId, string UnitMeasurement)
        {
            if (string.IsNullOrWhiteSpace(UnitMeasurement))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(UnitMeasurement));

            var d = new CreateMeasurementDataDelegate(FoodId, NutrientId, UnitMeasurement);
            return executor.ExecuteNonQuery(d);
        }

        public Measurement FetchMeasurement(int MeasurementId)
        {
            var d = new FetchMeasurementDataDelegate(MeasurementId);
            return executor.ExecuteReader(d);
        }

        public Measurement GetMeasurement(string UnitMeasurement)
        {
            var d = new GetMeasurementDataDelegate(UnitMeasurement);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Measurement> RetrieveMeasurements()
        {
            return executor.ExecuteReader(new RetrieveMeasurementsDataDelegate());
        }
    }
}
