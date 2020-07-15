using System;
using System.Linq;
using RestSharp;

namespace Bus_Board
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for bus stop code
            // Console.WriteLine("Please give me the bus stop code: ");
            string stopCode = "490008660N";
            // string stopCode = Console.ReadLine();

            // Make sure input is uppercase
            stopCode = stopCode.ToUpper();

            // define transportApiClient as new instance of TransportApiClient() method
            var transportApiClient = new TransportApiClient();

            // define departures as result of running GetBusDeparturesForStop(stopCode)
            // stopCode is the parameter
            var departures = transportApiClient.GetBusDeparturesForStop(stopCode);

            PrintNextBuses(departures);
        }

        private static void PrintNextBuses(BusDepartureResponse departures)
        {
            Console.WriteLine($"\n\nNext buses at {departures.Name}: \n");

            // Use just first 5 lines (departures) in 
            foreach (var departure in departures.Departures.All.Take(5))
            {
                Console.WriteLine($"Line {departure.Line} heading to {departure.Direction}. Arriving at {departure.BestDepartureEstimate}.");
            }
        }
    }
}
