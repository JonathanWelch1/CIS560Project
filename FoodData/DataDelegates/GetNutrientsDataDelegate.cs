using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using FoodData.Model;
using System.Data.SqlClient;

namespace FoodData.DataDelegates
{
    internal class GetNutrientsDataDelegate :DataReaderDelegate<Nutrients>
    {
        private readonly string nutrientName;

        public GetNutrientsDataDelegate(string nutrientName)
         : base("Person.GetPerson")
        {
            this.nutrientName = nutrientName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("nutrientName", nutrientName);
        }

        public override Nutrients Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Nutrients(
               reader.GetInt32("MeasurementId"),
               reader.GetInt32("FoodId"),
               reader.GetInt32("NutrientId"),
               nutrientName);
        }
    }
}
