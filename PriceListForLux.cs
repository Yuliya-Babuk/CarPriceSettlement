using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPriceSettlement
{
    //set price for optima complection
    public class PriceListForLux: PriceListDecorator
    {
        public PriceListForLux(IPriceList priceList): base(priceList) { }
        public override double SetPrice()
        {
            return base.priceList.SetPrice()+30;
        }
    }
}
