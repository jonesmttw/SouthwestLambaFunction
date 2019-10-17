using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SouthwestLambda
{
    public class SouthwestRequest
    {
        [JsonProperty("adultPassengersCount")]
        public int AdultPassengersCount { get; set; }
        [JsonProperty("departureDate")]
        public DateTime DepartureDate { get; set; }
        [JsonProperty("destinationAirportCode")]
        public string DestinationAirportCode { get; set; }
        [JsonProperty("fareType")]
        public string FareType { get; set; }
        [JsonProperty("originationAirportCode")]
        public string OriginationAirportCode { get; set; }
        [JsonProperty("passengerType")]
        public string PassengerType { get; set; }
        [JsonProperty("returnDate")]
        public DateTime ReturnDate { get; set; }
        [JsonProperty("seniorPassengersCount")]
        public int SeniorPassengersCount { get; set; }
        [JsonProperty("tripType")]
        public string TripType { get; set; }
        [JsonProperty("departureTimeOfDay")]
        public string DepartureTypeOfDate { get; set; }
        [JsonProperty("reset")]
        public bool Reset { get; set; }
        [JsonProperty("returnTimeOfDay")]
        public string ReturnTimeOfDay { get; set; }
    }
}
