using System;
using System.Collections.Generic;
using System.Web.Http;
using PlayByPlay.Model;

namespace PlayByPlay.Controllers
{
    public class FlightsController : ApiController
    {
        public IHttpActionResult GetAllFlights()
        {
            var model = new List<Flight>
            {
                new Flight
                {
                    Airline = "United",
                    Approved = false,
                    Cities = new[]{"LAX","SAF"},
                    Date = new DateTime(2014, 4, 1),
                    EndTime = new DateTime(2014, 4, 1),
                    StartTime = new DateTime(2014, 4, 1),
                    FlightNumber = "207",
                    Id = 1,
                    Price = 500,
                    TotalDuration = 2
                },
                new Flight
                {
                    Airline = "Delta",
                    Approved = false,
                    Cities = new[]{"LAX","SAF"},
                    Date = new DateTime(2014, 4, 1),
                    EndTime = new DateTime(2014, 4, 1),
                    StartTime = new DateTime(2014, 4, 1),
                    FlightNumber = "207",
                    Id = 2,
                    Price = 500,
                    TotalDuration = 2
                }
            };
            return Ok(model);
        }
    }
}