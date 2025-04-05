using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AM.Core.Domain;

namespace AM.Core.Services
{
    public class FlightService : IFlightServices
    {
        public IList<Flight> Flights { get; set; }

        public IList<DateTime> GetFlightDates(string destination)
        {
            var listdate=new List<DateTime>();
            foreach (var flight in Flights) {
                if (flight.Destination == destination)
                {
                    listdate.Add(flight.FlightDate);
                }
            }
            return listdate;

        }
        public IList<DateTime> GetFlightDatesLINQIntegre(string destination)
        {
            return
            (from f in Flights
            where f.Destination == destination
            select f.FlightDate).ToList();
        }
        public IList<DateTime> GetFlightDatesLINQMethodesAvancees(string destination)
        {
            return Flights.Where(f => f.Destination == destination)
            .Select(f => f.FlightDate)
            .ToList();

        }
    }
}
