namespace BuilderTask2;

class Program
{
    static void Main(string[] args)
    {
        IPizzaBuilder margheritaBuilder = new PizzaMargheritaBuilder();
        margheritaBuilder.BuildDough("Thin");
        margheritaBuilder.BuildSize("XXL");
        PizzaDirector dir = new PizzaDirector(margheritaBuilder);
        dir.Construct();
        Pizza p1 = margheritaBuilder.GetResult();
        p1.Show();
        
        Console.WriteLine("_______________________________");
        
        IPizzaBuilder pizzaBuilder = new PizzaBuilder();
        pizzaBuilder.BuildDough("Thick");
        pizzaBuilder.BuildSize("L");
        pizzaBuilder.BuildIngredient("Cheese");
        pizzaBuilder.BuildDough("White Sauce");
        PizzaDirector dir2 = new PizzaDirector(pizzaBuilder);
        dir2.Construct();
        Pizza p2 = pizzaBuilder.GetResult();
        p2.Show();
    }
}