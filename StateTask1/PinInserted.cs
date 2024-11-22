namespace StateTask1;

public class PinInserted:State
{
    public PinInserted(Context context) : base(context)
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
        Console.WriteLine("Pin Already Inserted");
    }

    public override void WithdrawCash(int amount)
    {
        if (amount < context.Balance)
        {
            Console.WriteLine("Cash Withdrawed");
            context.Balance -= amount;
            context.ChangeState(new PinInserted(context));
        }
        else
        {
            context.ChangeState(new NoCash(context));
        }
    }
}