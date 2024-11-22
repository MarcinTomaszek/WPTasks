namespace StateTask2;

public class StartState:State
{
    public StartState(Context context) : base(context)
    {
        base.context = context;
    }

    public override void Start()
    {
        Console.WriteLine("Type product You want to buy:");
        Console.WriteLine("Products:");
        foreach (var v in context.Products)
        {
            Console.WriteLine(v.Key+" price:"+v.Value.Item1);
        }

        context.chosen_product = Console.ReadLine();
        context.ChangeState(new Finalization(context));

    }

    public override void InsertMoney(decimal amount)
    {
        Console.WriteLine("Choose your product first");
    }

    public override void Finalize()
    {
        Console.WriteLine("Choose your product first");
    }
}