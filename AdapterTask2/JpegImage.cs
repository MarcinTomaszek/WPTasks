namespace AdapterTask2;

public class JpegImage:IImage
{
    
    public void Load(string filename)
    {
        Console.WriteLine($"Loading JPEG file: {filename}");
    }

    public void Display()
    {
        Console.WriteLine($"Displaying JPEG file");
    }
}