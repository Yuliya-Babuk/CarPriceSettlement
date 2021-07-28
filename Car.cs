namespace CarPriceSettlement
{
    public class Car
    {

        public string Model { get; set; }
        public string Color { get; set; }
        public string EngineType { get; set; }
        public string Year { get; set; }
        public Complection Complection { get; set; }

        public Car() { }
        public Car(string model, string color, string engineType, string year, Complection complection)
        {
            Model = model;
            Color = color;
            EngineType = engineType;
            Year = year;
            Complection = complection;
        }
    }
    }