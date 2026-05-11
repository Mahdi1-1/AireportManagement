using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.ApplicationCore.Domaine
{
    public class Staff : Passenger
    {

        public DateTime EmploymentDate { get; set; }

        public string Function { get; set; }
        [DataType(DataType.Currency)]
        public double Salary { get; set; }

        override public void passengerType()
        {
            base.passengerType();
            Console.WriteLine("I am a staff");
        }
    }
}
