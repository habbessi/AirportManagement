using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public decimal Price { get; set; }
        public string? Seat { get; set; }
        public string? VIP { get; set; }
        public virtual Passenger? Passenger { get; set; }
        public virtual Flight? Flight { get; set; }

        public int PassengerId { get; set; }
        public int FlightId { get; set; }
        public override string ToString()
        {
            return $"Reservation - Price: {Price}, Seat: {Seat}, VIP: {VIP}, PassengerId: {PassengerId}, FlightId: {FlightId}";
        }
    }
}
