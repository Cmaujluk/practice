namespace PapaJohn_s.Pizza
{
    class ThinCrust : PizzaBase
    {
        private const int PRICE = 100;
        private const string DESCRIPTION = "Super Thin Crust";

        public ThinCrust()
        {
            Description = DESCRIPTION;
        }

        public override float GetCost()
        {
            return PRICE;
        }


    }
}
