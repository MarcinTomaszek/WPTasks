namespace BuilderTask1;

public class Computer
{
    private List<string> parts = new List<string>();

    public void Add(string p)
    {
        parts.Add(p);
    }

    public void Show()
    {
        Console.WriteLine("Your computer consists of:");
        foreach (var p in parts)
        {
            Console.WriteLine(p);
        }
    }
}