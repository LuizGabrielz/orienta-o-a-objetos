namespace Course.Entities
{
    public class Department
    {
        public string Name { get; set; } // Propiedade string name

        public Department() // Construtor padrão 
        {

        }

        public Department(string name) // Construtor que recebe o nome como paramentro de entrada no construtor
        {
            Name = name;
        }
    }
}