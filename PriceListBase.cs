using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPriceSettlement

    //set price for base complection
{
    public class PriceListBase: IPriceList
    {
        
        public Car Car { get; set; }

        public double SetPrice()
        {
            return 100;
        }
    }
}
