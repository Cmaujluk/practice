using PapaJohn_s.Decorators;
using PapaJohn_s.Pizza;
using System;

namespace PapaJohn_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Pizza!");

            var fourCheesePizza = new Cheese(new Cheese(new Cheese(new Cheese((new Sauce(new ThickCrust()))))));
            DisplayPizzaInfo(fourCheesePizza);

            var classicPizza = new Salami(new Cheese(new Sauce(new ThinCrust())));
            DisplayPizzaInfo(classicPizza);





        }

        static void DisplayPizzaInfo(PizzaBase pizza)
        {
            Console.WriteLine($"{pizza.GetDescription()}; Price is {pizza.GetCost()}");
        }
    }
}
