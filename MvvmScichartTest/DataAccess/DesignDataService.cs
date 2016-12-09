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

            for (var i = 0; i < 200; i++)
            {
                var weightRecord = new WeightRecord
                {
                    Date = start.AddDays(i),
                    Weight = random.NextDouble() * 20 + 180
                };
                data.Add(weightRecord);
            }

            return data;
        }
    }
}