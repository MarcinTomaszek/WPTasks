namespace StateTask1;

public abstract class State
{
    protected Context context;

    public State(Context context)
    {
        context = context;
    }
    public abstract void InsertCard();
    public abstract void EjectCard();
    public abstract void InsertPin(string pin);
    public abstract void WithdrawCash(int amount);
}