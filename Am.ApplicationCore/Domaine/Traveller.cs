using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.ApplicationCore.Domaine
{
    public class Traveller: Passenger
    {

        public string HealthInformation { get; set; }

        public string Nationality { get; set; }

        override public void passengerType()
        {
            base.passengerType();
            Console.WriteLine("I am a Traveller");
        }

    }
}
