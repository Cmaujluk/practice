namespace PapaJohn_s.Pizza
{
    public abstract class PizzaBase
    {
        protected string Description;

        public string GetDescription()
        {
            return Description;
        }

        public abstract float GetCost();
    }
}
