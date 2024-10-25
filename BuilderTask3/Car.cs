namespace BuilderTask3;

public class Car
{
    private List<string> car = new List<string>();
    
    public void Add(string p)
    {
        car.Add(p);
    }
    
    public void Show()
    {
        Console.WriteLine("Your Car consists of:");
        foreach (var p in car)
        {
            Console.WriteLine(p);
        }
    }
}