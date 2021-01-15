namespace Cap10.Exercise03.Entities
{
    class LegalPerson : Taxpayer
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson(string name, double annualIncome, int numberOfEmployees)
            : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double DueTax()
        {
            double taxQuotient = 0.16;
            if (NumberOfEmployees >= 10)
                taxQuotient = 0.14;
            double dueTax = AnnualIncome * taxQuotient;
            return dueTax;
        }
    }
}
