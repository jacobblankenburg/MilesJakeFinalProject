using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJAirline
{
    class FlightPrice : Flight
    {
        private int Price;
        private int FirstClassPrice = 350;
        private int CoachPrice = 150;

        public FlightPrice(int price)
        {
            this.Price = price;
        }
        public int GetPrice()
        {
            if (FirstClass == true)
            {
                Price = FirstClassPrice;
            }
            else if (Coach == true)
            {
                Price = CoachPrice;
            }
            return Price;
        }

    }
}

