using System.Collections.Generic;
using System.Web.Http;
using PlayByPlay.Model;

namespace PlayByPlay.Controllers
{
    public class FlightsController : ApiController
    {
        public IEnumerable<Flight> GetAllFlights()
        {
            var flights = new List<Flight> {new Flight()};
            return flights;
        }
    }
}