namespace BuilderTask1;

class Program
{
    static void Main(string[] args)
    {
        IComputerBuilder c = new ComputerBuilder();
        c.BuildProcessor("Intel i7");
        c.BuildRam("32GB");
        c.BuildHardDisc("HDD 1TB");
        c.BuildMotherBoard("Motherboard one");
        c.BuildGraphicCard("Nvidia RTX 4070");

        Computer computer = c.GetResult();
        computer.Show();
    }
}