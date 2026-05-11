using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.ApplicationCore.Domaine
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Classe { get; set; }
        public string Destination { get; set; }
        public ICollection<ReservationTicket> ReservationTicket { get; set; }
        public Ticket Ticket { get; set; }
        public Passenger Passenger { get; set; }


    }
}
