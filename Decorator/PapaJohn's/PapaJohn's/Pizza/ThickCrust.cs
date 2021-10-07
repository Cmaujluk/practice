namespace PapaJohn_s.Pizza
{
    class ThickCrust : PizzaBase
    {
        private const int PRICE = 150;
        private const string DESCRIPTION = "The best Thick Crust";

        public ThickCrust()
        {
            Description = DESCRIPTION;
        }

        public override float GetCost()
        {
            return PRICE;
        }
    }
}
