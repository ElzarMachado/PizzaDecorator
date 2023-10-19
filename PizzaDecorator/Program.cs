namespace PizzaDecorator
{
    class Program
    {
        static void Main(string[] arg)
        {
              IPizza pizza = new Pizza();
              IPizza quesopizza = new QuesoPizzaDecorator(pizza);
             IPizza peperonipizza = new PeperoniExtraDecorator(quesopizza);


              Console.WriteLine(pizza.PizzaTipo());
              Console.ReadLine();
              Console.WriteLine(quesopizza.PizzaTipo());
              Console.ReadLine();
              Console.WriteLine(peperonipizza.PizzaTipo());   
              Console.ReadLine();
            
        }
    }
}

