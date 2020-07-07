using DistanceCalculator.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace DistanceCalculator.Services
{
    public class CTeleportServices : ICTeleportServices
    {
        public async Task<Airport> GetAirportData(string IATA) 
        {
            var client = new RestClient($"https://places-dev.cteleport.com/airports/{IATA}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);

                //Get the lon and lat values
                var latitude = content["location"]["lat"].Value<double>();
                var longitude = content["location"]["lon"].Value<double>();

                // Return model to caller
                return new Airport
                {
                    Longitude = longitude,
                    Latitude = latitude
                };

            }

            return null;
        }
    }
}
