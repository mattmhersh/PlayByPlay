using System.Web.Http;
using PlayByPlay.Model;

namespace PlayByPlay.Controllers
{
    public class FlightsController : ApiController
    {
        public IHttpActionResult GetAllFlights()
        {
            var db = new FlightDB();
            return Ok(db.Flights);
        }
    }
}