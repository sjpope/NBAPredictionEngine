using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Configuration;
using RestSharp;
using 
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Dynamic;

namespace NbaAnalytics
{
    class Program
    {
        // Use ConfigManager here
        private static readonly string RapidApiKey = "NOT_SO_FAST";
        private static readonly string RapidApiHost = "api-nba-v1.p.rapidapi.com";

        void PullData()
        {

            var client = new RestClient("https://api-nba-v1.p.rapidapi.com/players/statistics?game=8133");
            var request = new RestRequest("/players/statistics", Method.Get);
            request.AddHeader("x-rapidapi-key", RapidApiKey);
            request.AddHeader("x-rapidapi-host", RapidApiHost);
            RestResponse response = client.Execute(request);

            // handle response
        }
        static void Main(string[] args)
        {
            // Min Team ID is 22
            // Mavs ID 8

            // Get last 5 games for each
            // API "Games per Team and Season


            // Sort by Date and get the highest 3

            // Then, use Players Statistics per game id
            // OR just use Players Statistics per Team and Season

        }
    }
}