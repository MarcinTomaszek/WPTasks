namespace BuilderTask2;

public class PizzaBuilder: IPizzaBuilder
{
    private Pizza _p = new Pizza();
    public void BuildSize(string p)
    {
        _p.Add(p);
    }

    public void BuildDough(string p)
    {
        _p.Add(p);
    }

    public void BuildIngredient(string p)
    {
        _p.Add(p);
    }

    public Pizza GetResult()
    {
        return _p;
    }
}