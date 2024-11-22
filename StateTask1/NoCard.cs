namespace StateTask1;

public class NoCard:State
{
    public NoCard(Context context) : base(context)
    {
        base.context = context;
    }

    public override void InsertCard()
    {
        Console.WriteLine("Card inserted");
        context.ChangeState(new CardInserted(context));
    }

    public override void EjectCard()
    {
        Console.WriteLine("No card inserted");
    }

    public override void InsertPin(string pin)
    {
        Console.WriteLine("No card inserted");
    }

    public override void WithdrawCash(int amount)
    {
        Console.WriteLine("No card inserted");
    }
}