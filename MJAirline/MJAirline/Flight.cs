using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJAirline
{
    public class Flight
    {
        private int MaxFlightMiles;
        private static bool[] seat;
        private static int totalFirstClass;
        private static int totalCoach;
        private bool firstclass;
        private bool coach;
        private DateTime departureTime;
        private DateTime arrivalTime;
        public enum aircraftNumber { Bowing727 = 0001 }
        public enum mileageBeforeMaintenance { Bowing727 = 76000 }
        public enum flightRange { Bowing727 = 1700 }
        public enum destinations { Tampa, Milwaukee }

        public bool[] Seat
        {
            get { return seat; }
            set { seat = value; }
        }

        public bool FirstClass
        {
            get { return firstclass; }
            set { firstclass = value; }
        }
        public bool Coach
        {
            get { return coach; }
            set { coach = value; }
        }
        public int TotalFirstClass
        {
            get { return totalFirstClass; }
            set { totalFirstClass = value; }
        }
        public int TotalCoach
        {
            get { return totalCoach; }
            set { totalCoach = value; }
        }
        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }
        public DateTime ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; }
        }
        public destinations Destination
        {
            get;
            set;
        }
        public aircraftNumber AircraftNumber
        {
            get;
            set;
        }
        public flightRange FlightRange
        {
            get;
            set;
        }
        public mileageBeforeMaintenance MileageBeforeMaintenance
        {
            get;
            set;
        }

    }
}




