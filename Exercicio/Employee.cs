namespace Course.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours {get; set; }
        public double ValuePerHour { get; set; }
        // Atributos dessa classe.
        public Employee()
        {

        }

        public Employee(string name, int hours, double ValuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = ValuePerHour;
        }

        public virtual double Payment() // Liberar a opção de pagamento para que ela possa ser sobescrita. Pra fazer isso colocamos a palavra virtual
        {
            return Hours * ValuePerHour;
        }
    }
}