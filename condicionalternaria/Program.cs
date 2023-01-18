﻿using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto; // Tem que declarar a variável fora do if
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.5;
            if (preco < 20.0) {
                desconto = preco * 0.1;
            }
            else {
                desconto = preco * 0.05;
            }

            Console.WriteLine(desconto);
        } 
    }
}