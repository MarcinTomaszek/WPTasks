namespace BuilderTask3;

public class CarBuilder:ICarBuilder
{
    private Car _p = new Car();
    public void BuildBody(string p="")
    {
        _p.Add(p);
    }

    public void BuildWheels(string p="")
    {
        _p.Add(p);
    }

    public void BuildEngine(string p="")
    {
        _p.Add(p);
    }

    public Car GetResult()
    {
        return _p;
    }
}