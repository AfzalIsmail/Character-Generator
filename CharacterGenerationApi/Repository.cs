using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CharacterGenerationApi
{
    public class Repository
    {
        [JsonPropertyName("results")]
        public ResultList[] Results { get; set; }

    }

    public class ResultList
    {
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("name")]
        public NameDetails Name { get; set; }

        [JsonPropertyName("location")]
        public LocationDetails Location { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("login")]
        public LoginDetails Login { get; set; }

        [JsonPropertyName("dob")]
        public DobDetails Dob { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

    }

    public class NameDetails
    {
        [JsonPropertyName("first")]
        public string First { get; set; }

        [JsonPropertyName("last")]
        public string Last { get; set; }
    }

    public class LocationDetails
    {
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }
    }

    public class LoginDetails
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

    }

    public class DobDetails
    {
        [JsonPropertyName("age")]
        public int Age { get; set; }

    }



}
