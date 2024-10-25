namespace BuilderTask2;

public class PizzaDirector
{
    private IPizzaBuilder _pizzaBuilder;

    public PizzaDirector(IPizzaBuilder builder)
    {
        _pizzaBuilder = builder;
    }

    public void Construct()
    {
        _pizzaBuilder.BuildDough();
        _pizzaBuilder.BuildSize();
        _pizzaBuilder.BuildIngredient();
    }
}