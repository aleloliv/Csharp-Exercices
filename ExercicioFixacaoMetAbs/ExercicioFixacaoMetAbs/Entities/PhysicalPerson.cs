namespace ExercicioFixacaoMetAbs.Entities
{
    internal class PhysicalPerson : Person
    {
        public double HealthSpends { get; set; }

        public PhysicalPerson() 
        {
        }

        public PhysicalPerson(string name, double anualIncome, double healthSpends) : base(name, anualIncome)
        {
            HealthSpends = healthSpends;
        }

        public sealed override double Taxes()
        {
            if (AnualIncome < 20000.00)
            {
                return ((AnualIncome * 0.15) - (HealthSpends * 0.5));
            }
            else
            {
                return ((AnualIncome * 0.25) - (HealthSpends * 0.5));
            }
        }
    }
}
