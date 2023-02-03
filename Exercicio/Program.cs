using System;
using System.Collections.Generic; // Colocar a lista
using System.Globalization; // Colocar CultureInfo.InvariantCulture
using Course.Entities; // Chamar a classe 

namespace Course
{ 
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>(); // Lista de funcionário

            Console.Write("Enter the number of employees: "); //Pedindo a quantidade de funcionários
            int n = int.Parse(Console.ReadLine()); // Variável n recebendo int.Parse

            for (int i =1; i <= n; i++) // For para fazer a leitura dos dados desses N funcionários
            {
                Console.WriteLine($"Employee #{i} data:"); // Aqui não vai ser número 1, vai ser i para usar interpulação e tem que colocar o $ na frente 
                Console.Write("Outsourced (y/n)? "); // Funcionário terceirizado
                char ch = char.Parse(Console.ReadLine()); // Criar uma variável char recebendo char.Parse. É a resposta se pq ele é terceirizado ou não
                Console.Write("Name: "); // Digitar nome
                string name = Console.ReadLine(); // Criar uma variável temporária chamada "Name"
                Console.Write("Hours: "); // Digitar hora
                int hours = int.Parse(Console.ReadLine()); // Criar uma variável chamada hora
                Console.Write("Value per hour: "); // Digitar valor por hora
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Criar uma variável chamada valor por hora
                if (ch == 'y') // Se avariável for igual a letra "y", então ele é terceirizado
                {
                    Console.Write("Additional charge: "); // Então nesse caso eu vou pedir para o usuário digitar despeza adicional
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Leitura de uma variável auxiliar
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge)); // Chamar a lista e eu vou adiconar na lista o OutsourcedEmployee
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour)); // Adicionar lista recebendo o Employee recebendo nome, hora e valor por hora
                }
            }
            // Terminamos a interação com os funcionários
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list) // Pecorrer a lista 
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}