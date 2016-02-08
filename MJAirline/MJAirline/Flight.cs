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
        private int AirCraftNumber;
        private string Origin;
        private string Destination;
        private DateTime departureTime;
        private DateTime arrivalTime;

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
    }
}



  
