namespace StateTask1;

public class NoCash:State
{
    public NoCash(Context context) : base(context)
    {
        base.context = context;
    }

    public override void InsertCard()
    {
        Console.WriteLine("No Cash in ATM");
    }

    public override void EjectCard()
    {
        Console.WriteLine("Card Ejected");
        context.ChangeState(new NoCard(context));
    }

    public override void InsertPin(string pin)
    {
        Console.WriteLine("No Cash in ATM");
    }

    public override void WithdrawCash(int amount)
    {
        Console.WriteLine("No Cash in ATM");
    }
}