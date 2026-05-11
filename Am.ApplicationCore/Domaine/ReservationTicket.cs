using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.ApplicationCore.Domaine
{
    public class ReservationTicket

    {
        public string Date { get; set; }
        public float prix { get; set; }
        [ForeignKey("Ticket")]
        public int TicketFk { get; set; }
        [ForeignKey("Passenger")]
        public int PassengerFk { get; set; }
        public Ticket Ticket { get; set; }
        public Passenger Passenger { get; set; }


    }
}
