namespace BuilderTask2;

public class Pizza
{
    private List<string> pizza = new List<string>();
    
    public void Add(string p)
    {
        pizza.Add(p);
    }
    
    public void Show()
    {
        Console.WriteLine("Your pizza consists of:");
        foreach (var p in pizza)
        {
            Console.WriteLine(p);
        }
    }
}