namespace StateTask1;

public class CardInserted:State
{
    public CardInserted(Context context) : base(context)
    {
        base.context = context;
    }

    public override void InsertCard()
    {
        Console.WriteLine("Card Already Inserted");
    }

    public override void EjectCard()
    {
        Console.WriteLine("Card Ejected");
        context.ChangeState(new NoCard(context));
    }

    public override void InsertPin(string pin)
    {
        Console.WriteLine("Pin Inserted");
        Console.WriteLine("Validating Pin");
        context.ChangeState(new PinInserted(context));
    }

    public override void WithdrawCash(int amount)
    {
        Console.WriteLine("No Pin Inserted");
    }
}