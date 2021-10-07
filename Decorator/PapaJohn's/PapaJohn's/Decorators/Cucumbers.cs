using PapaJohn_s.Pizza;

namespace PapaJohn_s.Decorators
{
    class Cucumbers : IngredientDecoratorBase
    {
        public Cucumbers(PizzaBase pizza)
        {
            _pizza = pizza;
            Description = _pizza.GetDescription() + DESCRIPTION;
        }

        private readonly PizzaBase _pizza;
        private const string DESCRIPTION = " + Cucumbers";
        private const int PRICE = 25;

        public override float GetCost()
        {
            return _pizza.GetCost() + PRICE;
        }
    }
}
