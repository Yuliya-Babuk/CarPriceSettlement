using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPriceSettlement
{
    //set price for optima complection
    class Price_List_ForOptima: IPrice_List
    {
        public override double SetPrice(Car car)
        {
            return base.SetPrice(car);
        }
    }
}
