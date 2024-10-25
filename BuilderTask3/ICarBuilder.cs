namespace BuilderTask3;

public interface ICarBuilder
{
    void BuildBody(string p="");
    void BuildWheels(string p="");
    void BuildEngine(string p="");
    Car GetResult();
    
}