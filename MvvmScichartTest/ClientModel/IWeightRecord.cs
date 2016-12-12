using System;

namespace ClientModel
{
    public interface IWeightRecord
    {
        DateTime Date { get; set; }

        /// <summary>
        /// lbs
        /// </summary>
        double Weight { get; set; }

        double Bmi { get; set; }

        /// <summary>
        /// %
        /// </summary>
        double BodyFat { get; set; }
    }
}