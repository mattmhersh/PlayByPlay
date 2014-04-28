using System.Data.Entity;

namespace PlayByPlay.Model
{
    public class FlightDB : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
    }
}