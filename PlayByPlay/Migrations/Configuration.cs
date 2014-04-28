using System.Collections.Generic;
using PlayByPlay.Model;

namespace PlayByPlay.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PlayByPlay.Model.FlightDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PlayByPlay.Model.FlightDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            if (!context.Flights.Any())
            {
                context.Flights.AddRange(
                    new List<Flight>{
                        new Flight
                        {
                            Airline = "United",
                            Approved = false,
                            Cities = new[] { "LAX", "SAF" },
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
                            Cities = new[] { "LAX", "SAF" },
                            Date = new DateTime(2014, 4, 1),
                            EndTime = new DateTime(2014, 4, 1),
                            StartTime = new DateTime(2014, 4, 1),
                            FlightNumber = "207",
                            Id = 2,
                            Price = 500,
                            TotalDuration = 2
                        }});                
            }            
        }
    }
}
