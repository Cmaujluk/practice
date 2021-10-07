using PapaJohn_s.Pizza;

namespace PapaJohn_s.Decorators
{
    class Sauce : IngredientDecoratorBase
    {
        public Sauce(PizzaBase pizza)
        {
            _pizza = pizza;
            Description = _pizza.GetDescription() + DESCRIPTION;
        }

        private readonly PizzaBase _pizza;
        private const string DESCRIPTION = " + Sauce";
        private const int PRICE = 30;

        public override float GetCost()
        {
            return _pizza.GetCost() + PRICE;
        }
    }
}
