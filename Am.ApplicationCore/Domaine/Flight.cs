using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Am.ApplicationCore.Domaine
{
    public class Flight
    {
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime EffectiveArrival { get; set; }

        public int EstimatedDuration { get; set; }

        public DateTime FlightDate { get; set; }

        public int FlightId { get; set; }
        [ForeignKey("Plane")]
        public int PlaneFk { get; set; }
        public string Airline { get; set; }
        public Plane Plane { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
        public override string ToString()
        {
            return "Destination : " + Destination + " FlightDate : " + FlightDate+ " EstimatedDuration : " + EstimatedDuration;
        }

    }
}
