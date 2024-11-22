namespace StateTask2;

public class MoneyInserted:State
{
    public MoneyInserted(Context context) : base(context)
    {
        base.context = context;
    }

    public override void Start()
    {
        Console.WriteLine("Insert Money");
    }

    public override void InsertMoney(decimal amount)
    {
        context.moneyInTransaction += amount;
        Console.WriteLine($"Inserted {context.moneyInTransaction}");
        context.ChangeState(new StartState(context));
    }

    public override void Finalize()
    {
        Console.WriteLine("Insert Money");
    }
}