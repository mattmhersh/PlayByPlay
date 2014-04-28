using System;
using System.Collections.Generic;

namespace PlayByPlay.Model
{
                //airline: "American Airlines",
                //flightNumber: 207,
                //startTime: "13:00",
                //endTime: "15:00",
                //totalDuration: 2,
                //price: 500,
                //date: "12/1/2014",
                //cities: ["SFO", "LAS"],
                //approved: false

    public class Flight
    {
        public int Id { get; set; }
        public string Airline { get; set; }
        public string FlightNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int TotalDuration { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string[] Cities { get; set; }
        public bool Approved { get; set; }

    }
}