using System;
using System.Collections.Generic;
using System.Text;
using FoundationStandard.ObjectHydrator;
using FoundationStandard.ObjectHydrator.Interfaces;

namespace ObjectHydratorSimpleConsole
{
    public class LocationGenerator : IGenerator<Location>
    {

        private double LatMin = -90d;
        private double LatMax = 90d;
        private double LongMin = -180d;
        private double LongMax = 180d;
        Random random;

        public LocationGenerator()
        {
            random= RandomSingleton.Instance.Random;
        }
        public Location Generate()
        {

            var next = random.NextDouble();
            double Lat= LatMin + (next * (LatMax - LatMin));
            next = random.NextDouble();
            double Long = LongMin + (next * (LongMax - LongMin));
            return new Location {Lat = Lat, Long = Long};
        }
    }
}
