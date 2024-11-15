namespace AdapterTask2;

public class GifHandler
{
    public void OpenFile(string filename)
    {
        Console.WriteLine($"Opening GIF file {filename}");
    }

    public void RenderGif()
    {
        Console.WriteLine("Rendering GIF");
    }
}