using System;
using ClientModel;

namespace Domain
{
    public class WeightRecord : IWeightRecord
    {
        public DateTime Date { get; set; }
        public double Weight { get; set; }
        public double Bmi { get; set; }
        public double BodyFat { get; set; }
    }
}