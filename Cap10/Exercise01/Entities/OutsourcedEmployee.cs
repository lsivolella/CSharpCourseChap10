namespace Cap10.Exercise01.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AddionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addionalCharge) 
                : base (name, hours, valuePerHour)
        {
            AddionalCharge = addionalCharge;
        }

        public override double Payment()
        {
            double bonus = 1.10f * AddionalCharge;
            return base.Payment() + bonus;
        }
    }
}
