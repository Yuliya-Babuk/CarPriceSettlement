using System;

namespace CarPriceSettlement
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car ();
            var price_list = new IPrice_List();
            var priceForBaseComplection = price_list.SetPrice(car);                        
        }
    }
}
