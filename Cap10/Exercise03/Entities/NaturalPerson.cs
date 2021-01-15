namespace Cap10.Exercise03.Entities
{
    class NaturalPerson : Taxpayer
    {
        public double HealthExpenses { get; set; }

        public NaturalPerson(string name, double annualIncome, double healthExpenses)
            : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double DueTax()
        {
            double taxQuotient = 0.15;
            if (AnnualIncome >= 20000)
                taxQuotient = 0.25;
            double dueTax = (AnnualIncome * taxQuotient) - (HealthExpenses * 0.5);
            return dueTax;
        }
    }
}
