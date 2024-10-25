namespace BuilderTask1;

public interface IComputerBuilder
{
    void BuildProcessor(string p);
    void BuildRam(string p);
    void BuildHardDisc(string p);
    void BuildMotherBoard(string p);
    void BuildGraphicCard(string p);
    Computer GetResult();
}