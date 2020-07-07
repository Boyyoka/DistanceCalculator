using DistanceCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistanceCalculator.Services
{
    public interface ICTeleportServices
    {
        Task<Airport> GetAirportData(string IATA);
    }
}
