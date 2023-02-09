using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            PrintService printService = new PrintService(); // PrintService recebendo um novo PrintService

            Console.Write("How many values? "); // Escrever a frase na tela
            int n = int.Parse(Console.ReadLine()); // Declarar uma variável int n int.Parse

            for (int i=0; i<n; i++) {
                int x = int.Parse(Console.ReadLine()); // Leitura do valor x qualquer 
                printService.AddValue(x);
            }

            printService.Print(); // Imprime na tela todos os elementos
            Console.WriteLine("First: " + printService.First());
        }
    }
}