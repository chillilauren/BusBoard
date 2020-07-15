using System.Net.Http;
using System;
using RestSharp;

namespace Bus_Board
{
    public class TransportApiClient
    {
        // 
        private RestClient client;

        public TransportApiClient()
        {
            // Importing API GET request
            client = new RestClient("https://transportapi.com/");
        }

        // GET Request URL (from API):

        // https://transportapi.com/v3/uk/bus/stop/490008660N/live.json?app_id=289fbffe
        // &app_key=d6613a8650ed554886ce591a71f5874f&group=route&nextbuses=yes

        // Returns 
        public BusDepartureResponse GetBusDeparturesForStop(string stopCode)
        {
            var request = new RestRequest($"v3/uk/bus/stop/{stopCode}/live.json")
                        .AddQueryParameter("app_id", "289fbffe")
                        .AddQueryParameter("app_key", "d6613a8650ed554886ce591a71f5874f")
                        .AddQueryParameter("group", "no")
                        .AddQueryParameter("nextbuses", "yes");

            var response = client.Get<BusDepartureResponse>(request);
            
            return response.Data;
        }
    }
}