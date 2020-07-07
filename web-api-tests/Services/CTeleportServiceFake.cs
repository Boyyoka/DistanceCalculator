using DistanceCalculator.Models;
using DistanceCalculator.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace web_api_tests.Services
{
    class CTeleportServiceFake : ICTeleportServices
    {
        private readonly Points points1;
        private readonly Points points2;
        private readonly Points points3;
        private readonly Points points4;

        public CTeleportServiceFake()
        {
            points1 = new Points { PointA = "AMS", PointB = "SFO" };
            points2 = new Points { PointA = "ALL", PointB = "LAX" };
            points3 = new Points { PointA = "LAX", PointB = "SFO" };
            points4 = new Points { PointA = "SFO", PointB = "ALL" };
        }

        public Task<Airport> GetAirportData(string IATA)
        {
            throw new NotImplementedException();
        }
    }
}
