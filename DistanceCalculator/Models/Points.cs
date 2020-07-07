using System.ComponentModel.DataAnnotations;

namespace DistanceCalculator.Models
{
    // Model to hold values to calculate distance between two points. 
    // The two points represent Airports and are based on the 3 letter IATA-code
    public class Points
    {
        [StringLength(3, ErrorMessage = "{0} must represent a 3 letter IATA-code", MinimumLength = 3)]
        public string PointA { get; set; }
        [StringLength(3, ErrorMessage = "{0} must represent a 3 letter IATA-code", MinimumLength = 3)]
        public string PointB { get; set; }
    }
}
