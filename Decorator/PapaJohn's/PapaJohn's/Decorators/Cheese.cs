using PapaJohn_s.Pizza;

namespace PapaJohn_s.Decorators
{
    class Cheese : IngredientDecoratorBase
    {
        public Cheese(PizzaBase pizza)
        {
            _pizza = pizza;
            Description = _pizza.GetDescription() + DESCRIPTION;
        }

        private readonly PizzaBase _pizza;
        private const string DESCRIPTION = " + Cheese";
        private const int PRICE = 49;

        public override float GetCost()
        {
            return _pizza.GetCost() + PRICE;
        }
    }
}
