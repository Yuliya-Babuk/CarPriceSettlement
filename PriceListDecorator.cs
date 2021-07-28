namespace CarPriceSettlement
{
    public abstract class PriceListDecorator : IPriceList
    {
        protected  IPriceList priceList;

        public PriceListDecorator(IPriceList priceList) 
        {
            this.priceList = priceList;
        }

        public Car Car { get; set; }
        public abstract double SetPrice();
    }
}
