namespace AdapterTask2;

public class PngImage:IImage
{
    
    public void Load(string filename)
    {
        Console.WriteLine($"Loading PNG file: {filename}");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying PNG file");
    }
}