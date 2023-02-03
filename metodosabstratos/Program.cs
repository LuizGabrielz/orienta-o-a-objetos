using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program 
    {
        static void Main(String[] args)
        {
            List<Shape> list = new List<Shape>(); // Lista do tipo Shape, do tipo genérico

            Console.Write("Enter the number of shapes: "); // Entre com a quantidade de figuras
            int n = int.Parse(Console.ReadLine()); // Recebendo a variável "n"

            for (int i = 1; i <= n; i++) // For para ter a leitura dos dados da figura
            {
                Console.WriteLine($"Shape #{i} data:"); // Figura "i" que é variável do for
                Console.Write("Rectangle or Circle (r/c)? "); // Perguntar se é triangulo ou cículo
                char ch = char.Parse(Console.ReadLine()); // Pedir pra o usuário digitar r ou c
                Console.Write("Color (Black/Blue/Red): "); // Perguntar ao usuário qual é a cor
                Color color = Enum.Parse<Color>(Console.ReadLine()); // Variável auxiliar e vai receber a palavra que o usuário digitar sendo uma das tres que está na color
                if (ch == 'r') // Se a variável ch for igual a r, siginifica que é um retangulo
                {
                    Console.Write("Width: "); // Pedir pra digitar a largura 
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Receber uma variável temporária
                    Console.Write("Height: "); // Pedir pra digitar a altura
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Receber Variável auxiliar temporária
                    list.Add(new Rectangle(width, height, color)); // Adicionar na lista um new retangulo recebendo altura, largura e cor
                }
                else 
                {
                    Console.Write("Radius: "); // Pedir pra o usuário digitar o Raio
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Receber variável auxiliar temporária
                    list.Add(new Circle(radius, color)); // Adiconar uma lista Circle, recebendo Raio e cor
                }   
            }

             Console.WriteLine(); // Pular uma linha
             Console.WriteLine("SHAPE AREAS: ");
             foreach (Shape shape in list) // Pecorrer a lista para cada Shape na lista
             {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture)); // Vai mostrar na tela o Shape.Area
             }
        }
    }
}