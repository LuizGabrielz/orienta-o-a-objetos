namespace Course.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge {get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double ValuePerHour, double additionalCharge)
            : base(name, hours, ValuePerHour)
            {
                AdditionalCharge = additionalCharge;
            }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge; // Reaproveitando a lógica do pagamento comum
        }
    }
}