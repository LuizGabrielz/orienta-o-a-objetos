using System;
using System.Collections.Generic;
using Course.Services;
using Course.Entities;
using System.Globalization;

namespace Course {

    class Program {

        static void Main(string[] args) {

            List<Product> list = new List<Product>(); // Cria uma lista de números inteiros. Instancia uma lista vazia

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()); // O usuário vai digitar e guardar na variável n

            for (int i = 0; i < n; i++) { // Fazendo um for pra ir começando do zero e se for menor do que n, ele incrementa
                string[] vect = Console.ReadLine().Split(','); // Vai receber o nome que está antes da vírgula
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture); // preço recebendo um preço na posição 1
                list.Add(new Product(name, price)); // Vou adicionar na lista um new Product recebendo nome e preço
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list); // Max vai ser do tipo Product pra encontrar o máximo

            Console.WriteLine("Max:");
            Console.Write(max);
        }
    }
}