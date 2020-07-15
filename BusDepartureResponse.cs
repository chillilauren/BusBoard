using System;
using System.Collections.Generic;
using RestSharp;

namespace Bus_Board
{

    // Set up class for JSON object
    public class BusDepartureResponse
    {
        public string Name { get; set; }
        public Departures Departures { get; set; }
    }

    // Create class for departures part of JSON
    public class Departures
    {
        // Create lists for both bus numbers
        public  List<DepartureInfo> All { get; set; }

    }

    public class DepartureInfo
    {
        public string Line { get; set; }
        public string Direction { get; set; }
        public string BestDepartureEstimate { get; set; } // may change this to actually take in a time


    }
}