using System; // Programa principal pra integrar um programa
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace Course {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Enter department's name: "); // Digitar nome do departamento
            string deptName = Console.ReadLine(); //Nome do departamento
            Console.WriteLine("Enter worker data:"); // Dados do trabalhador
            Console.Write("Name: "); // Nome do funcionário
            string name = Console.ReadLine(); // Variável recebendo nome
            Console.Write("Level (Junior/MidLevel/Senior): "); // Ler o nível do funcionário
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); // Declarar uma variável workerLevel ela vai receber um Enum.Parse para transformar, adicona a lista e coloca o que vai transformar em string 
            Console.Write("Base salary: "); // Digitar o salário base do funcionário
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // declarar variável double para transformar em number
            
            Department dept = new Department(deptName); // Imprimir a frase. Instanciar um objeto
            Worker worker = new Worker(name, level, baseSalary, dept); // Paramentros da classe work

            Console.Write("How many contracts to this worker: "); // Quantos contratos tem esse trabalhador
            int n = int.Parse(Console.ReadLine()); // Variável "n" recebendo int.Parse

            for (int i = 1; i <= n; i++) // For normal para executar "n" 
            {
                Console.WriteLine($"Enter #{i} contract data:"); // Vai imprimir o valor de "i" para fazer isso coloca o $ e o {i}
                Console.Write("Date (DD/MM/YYYY): "); // Pedir a data
                DateTime date = DateTime.Parse(Console.ReadLine()); // Digitar data colocar DateTime, vai receber o DateTime.Parse e ele aceita o formato dia/mes/ano
                Console.Write("Value per hour: "); // Digitar o valor por hora
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Converter a string em number com o Parse
                Console.Write("Duration (hours): "); // Pedir a duração em horas
                int hours = int.Parse(Console.ReadLine()); // Digitar na variável hours
                HourContract contract = new HourContract(date, valuePerHour, hours); // Instanciar o contrato e recebe os valores que estão dentro
                worker.AddContract(contract); // Adiconar contratos no contrato do trabalhador
                // Com isso o funcionário digitou os tres dados do contrato
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): "); // Entre com o mes e ano validando mes e ano
            string monthAndYear = Console.ReadLine(); // Criar variável string para imprimir desse formato aqui 08/2018
            int month = int.Parse(monthAndYear.Substring(0, 2)); // Dividir mes e ano. Essa substring vai recortar da posição zero, duas posições. Para ser imprimido como inteiro vai ter que colcoar o Parse pra transformar 
            int year = int.Parse(monthAndYear.Substring(3)); // Substring pra cortar da posição 3 em diante
            Console.WriteLine("Name: " + worker.Name); // Nome do trabalhador vai chamar o Name concatenado com o worker.Name 
            Console.WriteLine("Departament: + worker.Department.Name"); // Acessar departamento concatenando com o worker e chamando o nome do departamento
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)); // Mostrar o mes, o ano e depois o valor, e vai receber o ano e o mes
        }   
    }
}