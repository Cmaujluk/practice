using PapaJohn_s.Pizza;

namespace PapaJohn_s.Decorators
{
    class Salami : IngredientDecoratorBase
    {
        public Salami(PizzaBase pizza)
        {
            _pizza = pizza;
            Description = _pizza.GetDescription() + DESCRIPTION;
        }

        private readonly PizzaBase _pizza;
        private const string DESCRIPTION = " + Salami";
        private const int PRICE = 55;

        public override float GetCost()
        {
            return _pizza.GetCost() + PRICE;
        }
    }
}
