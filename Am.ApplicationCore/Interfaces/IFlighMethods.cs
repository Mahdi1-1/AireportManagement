using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    interface IFlighMethods
    {
        List<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);

        int countnbdays7(DateTime date);
        int avgdays(String destination);



    }
}
