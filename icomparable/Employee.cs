using System; // O incoparable é do System, então eu vou ter que colocar aqui o using System;
using System.Globalization; // Para usar o CultureInfo.InvariantCulture

namespace Course.Entities { 
    class Employee : IComparable { // Realiza a interface IComparable
        // Esse empregado tem nome e salário
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) { // Fazer um construtor que recebe uma string no formato csvEmployee
            string[] vect = csvEmployee.Split(','); // Criar um vetor string, recebendo csvEmployee.Split baseado no caracterer ","
            Name = vect[0]; // Nome do funcionario vai ser meu vetor na posição zero, pq vai ser o primeiro elemento antes da vírgula
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture); // Salário do funcionário vai ser o segundo elemento do meu vetor 
        }

        public override string ToString()
        {
            return Name + "," + Salary.ToString("F2", CultureInfo.InvariantCulture); // ToString básico com nome e salário concatenado
        }

        public int CompareTo(object obj) {
            if (!(obj is Employee)) { // Se o objeto for do tipo Employee 
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }
            Employee other = obj as Employee; // Chamar a variável de other, recebe obj como Employee 
            return Name.CompareTo(other.Name); // Feito isso eu vou comparar os dois funcionários por nome 
        }   // Poderia tb comparar por salário, mas estamos ordenando por nomes
    }
}