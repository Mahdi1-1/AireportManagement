using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Am.ApplicationCore.Domaine
{
    public class Plane
    {
        /*public Plane() { }
        public Plane(int capacity, DateTime manufactureDate, int planeld, PlaneType planeType)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            Planeld = planeld;
            PlaneType = planeType;
        }
        */
        [Range(0, int.MaxValue)]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }

        public int PlaneId { get; set; }

        public PlaneType PlaneType { get; set; }

        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "PlaneType : " + PlaneType + " ManufactureDate : " + ManufactureDate + " Capacity : " + Capacity;
        }


        /*
        private int Capacity ;
            
        public int getCapacity()
        {
            return Capacity;
        }
        public void setCapacity(int capacity)
        {
            if (capacity > 0)
            {
                Capacity = capacity;
            }
        }*/
    }
}
