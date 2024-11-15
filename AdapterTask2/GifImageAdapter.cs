namespace AdapterTask2;

public class GifImageAdapter:IImage
{
    private GifHandler _gh;

    public GifImageAdapter(GifHandler gh)
    {
        _gh = gh;
    }
    public void Load(string filename)
    {
        _gh.OpenFile(filename);
    }

    public void Display()
    {
        _gh.RenderGif();
    }
}