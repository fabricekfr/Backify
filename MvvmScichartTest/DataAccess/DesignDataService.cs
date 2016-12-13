using System;
using System.Collections.Generic;
using ClientModel;
using Domain;

namespace DataAccess
{
    public class DesignDataService : IDataService
    {
        public IEnumerable<IWeightRecord> GetData(object argument)
        {
            return new IWeightRecord[50];
        }

        public IEnumerable<IWeightRecord> GetData()
        {
            var data = new List<IWeightRecord>();
            var start = new DateTime(2014, 1, 1);
            var random = new Random();

            for (var i = 0; i < 30; i++)
            {
                var weightRecord = new WeightRecord
                {
                    Date = start.AddDays(i),
                    Weight = random.NextDouble() * 20 + 100,
                    BodyFat = random.NextDouble() * 10 + 20,
                    Bmi = random.NextDouble() * 3 + 22
                };
                data.Add(weightRecord);
            }

            return data;
        }
    }
}