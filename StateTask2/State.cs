namespace StateTask2;

public abstract class State
{
    protected Context context;

    public State(Context context)
    {
        context = context;
    }
    
    public abstract void Start();
    public abstract void InsertMoney(decimal amount);
    public abstract void Finalize();
}