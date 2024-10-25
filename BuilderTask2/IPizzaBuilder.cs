namespace BuilderTask2;

public interface IPizzaBuilder
{
    void BuildSize(string p="");
    void BuildDough(string p="");
    void BuildIngredient(string p="");
    Pizza GetResult();
}