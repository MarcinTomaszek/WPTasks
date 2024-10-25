namespace BuilderTask1;

public class ComputerBuilder:IComputerBuilder
{
    private Computer _c = new Computer();
    
    public void BuildProcessor(string p)
    {
        _c.Add(p);
    }

    public void BuildRam(string p)
    {
        _c.Add(p);
    }

    public void BuildHardDisc(string p)
    {
        _c.Add(p);
    }

    public void BuildMotherBoard(string p)
    {
        _c.Add(p);
    }

    public void BuildGraphicCard(string p)
    {
        _c.Add(p);
    }

    public Computer GetResult()
    {
        return _c;
    }
}