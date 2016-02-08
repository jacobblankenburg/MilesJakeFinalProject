using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJAirline
{

    public class FlightClass : Flight
    {

        public void GetSeatAndClass()
        {
            Seat = new bool[21];
            int classSelection = 0;

            for (int i = 0; i < 20; i++)
                Seat[i] = false;

            for (int i = 1; i <= 20; i++)
            {
                classSelection = Convert.ToInt32(Console.ReadLine());
            }
            if (FirstClass == true)
            {
                if (TotalFirstClass == 8 && TotalCoach < 12)
                {
                    //inform user first class is full
                }
                else
                {
                    AssingCoach();
                }
            }
            else if (TotalFirstClass < 8)
            {
                AssingFirstClass();
            }
        }
        // TotalAssignedFirstClass 

        public void AssingFirstClass()
        {
            bool duplication = false;
            Random rand = new Random();
            int index = 0;

            while (!duplication)
            {
                duplication = true;
                index = rand.Next(1, 9);
                if (Seat[index] == true)
                    duplication = false;
            }
            Seat[index] = true;
            TotalFirstClass++;
            //inform user = ("Assigned seat {0:N0), index");

        }
        public void AssingCoach()
        {
            bool duplication = false;
            Random rand = new Random();
            int index = 0;

            while (!duplication)
            {
                index = rand.Next(9, 21);
                if (Seat[index] == true)
                    duplication = false;
            }
            Seat[index] = true;
            TotalFirstClass++;
            //inform user = ("Assigned seat {0:N0), index");

        }

    }
}


