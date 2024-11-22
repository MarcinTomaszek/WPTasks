using Microsoft.VisualBasic.CompilerServices;

namespace StateTask2;

public class Context
{
    private State _state ;
    public string chosen_product;
    public decimal moneyInTransaction;
    
    public Context()
    {
        _state = new MoneyInserted(this);
    }

    public Dictionary<string, (decimal, int)> Products = new Dictionary<string, (decimal, int)>()
    {
        { "Coca Cola", (5, 10) },
        { "Pepsi", (7, 1) },
        { "Sprite", (3, 1) }
    };
    
    public void ChangeState(State s)
    {
        _state = s;
    }

    public void Start()
    {
        _state.Start();
    }

    public void InsertMoney(decimal amount)
    {
        _state.InsertMoney(amount);
    }

    public void Finalize()
    {
        _state.Finalize();
    }
    
    
}