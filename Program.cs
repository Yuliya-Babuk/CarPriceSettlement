using System;

namespace CarPriceSettlement
{
    class Program
    {
        static void Main(string[] args)
        {

            var carOptima = new Car("Audi", "black", "auto", "2020", Complection.Optima);
            var carLux = new Car("Audi", "black", "auto", "2020", Complection.Lux);
            Console.WriteLine(GetPrice(carOptima).ToString()+"\n" + GetPrice(carLux).ToString());
            
            string GetPrice(Car car)
            {
                switch (car.Complection)
                {
                    case Complection.Base:

                        return $"price for {car.Complection} is {(new PriceListBase()).SetPrice()}";
                    case Complection.Optima:
                        return $"price for {car.Complection} is {(new PriceListForOptima(new PriceListBase())).SetPrice()}";
                    case Complection.Lux:
                        return $"price for {car.Complection} is {(new PriceListForLux(new PriceListBase())).SetPrice()}";
                    default:
                        return $"price can not be set";
                }
            }
          
        }
    }
}
