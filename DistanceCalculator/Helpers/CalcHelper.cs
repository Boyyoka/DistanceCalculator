using GeoCoordinatePortable;
using System;

namespace DistanceCalculator.Helpers
{
    // Helper class to calculate distance in miles
    public class CalcHelper
    {
        public static int CalculateDistanceInMiles(double lat1, double lat2, double lon1, double lon2)
        {
            var coord1 = new GeoCoordinate(lat1, lon1);
            var coord2 = new GeoCoordinate(lat2, lon2);

            int distance = Convert.ToInt32(coord1.GetDistanceTo(coord2) * 0.000621); // Geocoordinate returns meters, so we convert the meters into miles

            return distance;
        }
    }
}
