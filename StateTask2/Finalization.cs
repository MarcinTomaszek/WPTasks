namespace StateTask2;

public class Finalization:State
{
    public Finalization(Context context) : base(context)
    {
        base.context = context;
    }

    public override void Start()
    {
        Console.WriteLine("Wait for finalization");
    }

    public override void InsertMoney(decimal amount)
    {
        Console.WriteLine("Wait for finalization");
    }
    

    public override void Finalize()
    {
        if(context.Products.ContainsKey(context.chosen_product))
        {
            if (context.Products[context.chosen_product].Item2 > 0)
            {
                if (context.Products[context.chosen_product].Item1 < context.moneyInTransaction)
                {
                    var key = context.chosen_product;
                    var val = context.Products[context.chosen_product];
                    val.Item2 -= 1;
                    context.Products.Remove(key);
                    context.Products.Add(key,val);
                    Console.WriteLine($"Item {context.chosen_product} Bought");
                    context.ChangeState(new MoneyInserted(context));
                }
                else
                {
                    Console.WriteLine($"not enough money");
                }
            }
            else
            {
                Console.WriteLine($"product out of stock {context.chosen_product}");
            }
            
        }
        else
        {
            Console.WriteLine($"there is no such product as {context.chosen_product}");
        }

        context.chosen_product = "";
        context.moneyInTransaction = 0;
        context.ChangeState(new MoneyInserted(context));
    }
}