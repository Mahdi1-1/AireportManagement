using Am.ApplicationCore.Domaine;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    class FlightMethods : IFlighMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();
        public List<DateTime> Date { get; set; } = new List<DateTime>();
        public List<DateTime> GetFlightDates(string destination)
        {
            //for (int i=0; i< Flights.Count; i++)
            //{
            //    if ( Flights[i].Destination == destination)
            //    {
            //        Date.Add(Flights[i].FlightDate);
            //        return Date;
            //    }
            //}
            Date = (from f in Flights where f.Destination == destination select f.FlightDate).ToList();
            return Date;
        }
        public void GetFlights(string filterType, string filterValue)
        {
            List<Flight> result = new List<Flight>();

            switch (filterType)
            {
                case "Destination":
                    foreach (Flight f in Flights)
                    {
                        if (f.Destination == filterValue)
                            result.Add(f);
                    }
                    break;

                case "EstimationDuration":
                    foreach (Flight f in Flights)
                    {
                        if (f.Destination == filterValue)
                            result.Add(f);
                    }
                    break;

                case "FlightDate":
                    foreach (Flight f in Flights)
                    {
                        if (f.Destination == filterValue)
                            result.Add(f);
                    }
                    break;


            }
        }
        public int countnbdays7(DateTime Startdate)
        {
            int a;
            a = (from f in Flights where DateTime.Compare(Startdate, f.FlightDate) < 0 && (f.FlightDate - Startdate).TotalDays < 7 select f).Count();
            return a;
        }
        public double avgdays(String destination)
        {
            double a;
            a = 5.5;

            a = (from f in Flights where f.Destination == destination select f.EstimatedDuration).Average();


            return a;
        }

        public IEnumerable<Flight> OrderFlights()
        {
            var query = from f in Flights
                        orderby  f.EstimatedDuration descending
                        select f;
            return query;
        }

        public IEnumerable<Traveller> SeniorTravellers(Flight f)
        {
            var query = from p in f.Passengers.OfType<Traveller>()
                        orderby p.BirthDate
                        select p;
            return query.Take(3);
        }

        public void DestinationGroupedFlights()
        {
            var query = from f in Flights group f by f.Destination;
            foreach(var item in query)
            {
                Console.WriteLine("Destination: " + item.Key);
                foreach(var item2 in item)
                {
                    Console.WriteLine("Decollage: " + item2.FlightDate);
                }
            }
                        
        }

        int IFlighMethods.avgdays(string destination)
        {
            throw new NotImplementedException();
        }
    }

}
