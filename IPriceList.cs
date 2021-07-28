namespace CarPriceSettlement
{
    // now class is open for extension
    public interface IPriceList

    //base desing,can not be changed
    {
        Car Car { get; set; }
        double SetPrice();

    }
}
