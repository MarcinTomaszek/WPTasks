namespace BuilderTask3;

class Program
{
    static void Main(string[] args)
    {
        ICarBuilder carBuilder = new CarBuilder();
        carBuilder.BuildBody("Low Bodykit");
        carBuilder.BuildWheels("Rectangle Wheels");
        carBuilder.BuildEngine("Big Engine V8");
        CarDirector dir = new CarDirector(carBuilder);
        dir.Construct();
        Car c = carBuilder.GetResult();
        c.Show();
    }
}