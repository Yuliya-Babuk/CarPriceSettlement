using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPriceSettlement
{
    // in case we need to add new complection type - we have to change this class Price-list => it will be a violation of
    // open-close principle (OCP)
   public class Price_list
    {
        double price;
        public double SetPrice(Car car)

        {
            if (car.Complection == "base")
            {
                // price calculation for the "base" complection 
            }
            if (car.Complection == "optima")
            {
                // price calculation for the "optima " complection 
            }
            return price;
        }
                   
    }
}
