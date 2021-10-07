using PapaJohn_s.Pizza;

namespace PapaJohn_s.Decorators
{
    class Mushrooms : IngredientDecoratorBase
    {
        public Mushrooms(PizzaBase pizza)
        {
            _pizza = pizza;
            Description = _pizza.GetDescription() + DESCRIPTION;
        }

        private readonly PizzaBase _pizza;
        private const string DESCRIPTION = " + Mushrooms";
        private const int PRICE = 35;

        public override float GetCost()
        {
            return _pizza.GetCost() + PRICE;
        }
    }
}
