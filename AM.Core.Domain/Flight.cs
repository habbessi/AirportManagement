using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimationDuration { get; set; }
        [ForeignKey("PlaneId")]
        public virtual Plane? MyPlane { get; set; }
        //ou bien//[ForeignKey("MyPlane")]
        public int? PlaneId { get; set; }
        public virtual IList<Passenger> Passengers { get; set; }
        public string Comment { get; set; }
        public string Comment2 { get; set; }
        public override string ToString()
        {
            return "Destination:" + Destination
                + "Departure:" + Departure
                + "FlightDate:" + FlightDate
                + "FlightId:" + FlightId
                + "EffectiveArrival:" + EffectiveArrival
                + "EstimationDuration:" + EstimationDuration
                + "Comment:" + Comment
                + "MyPlane:" + MyPlane.ToString();
                 
        }
    } 
    
}
