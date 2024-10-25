namespace BuilderTask2;

public class PizzaMargheritaBuilder: IPizzaBuilder
{
    private Pizza _p = new Pizza();
    public void BuildSize(string p="")
    {
        _p.Add(p);
    }

    public void BuildDough(string p="")
    {
        _p.Add(p);
    }

    public void BuildIngredient(string p="")
    {
        _p.Add("Tomato Sauce");
        _p.Add("Mozarella");
        _p.Add("Basil");
    }

    public Pizza GetResult()
    {
        return _p;
    }
}