namespace BuilderTask3;

public class CarDirector
{
    private ICarBuilder _carBuilder;

    public CarDirector(ICarBuilder builder)
    {
        _carBuilder = builder;
    }

    public void Construct()
    {
        _carBuilder.BuildBody();
        _carBuilder.BuildWheels();
        _carBuilder.BuildEngine();
    }
}