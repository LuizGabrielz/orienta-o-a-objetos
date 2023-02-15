using System;
using System.Collections.Generic;
using Course.Entities; // Chamando a classe Product

namespace Course { 

    class Program {

        static void Main(string[] args) {

            HashSet<Product> a = new HashSet<Product>(); // HashSet do tipo Product instanciado
            a.Add(new Product("TV", 900.0)); // Adicionando Produto TV e Preço
            a.Add(new Product("Notebook", 1200.0)); // Adicionando Produto Notebook e Preço

            HashSet<Point> b = new HashSet<Point>(); // HashSet do tipo Point instanciado
            b.Add(new Point(3, 4)); // Adicionando uma coordenada
            b.Add(new Point(5, 10)); // Adicionando uma coordenada

            Product prod = new Product("Notebook", 1200.0); // Criar um produto com new Product e ele vai receber o Notebook com o mesmo valor do "A"
            Console.WriteLine(a.Contains(prod)); // Testando se o meu produto "A" está contido esse Product
            // Como colocamos "new" ele vai ser um outro objeto diferente do Produto "A"
            // Dentro da memória são objetos diferentes
            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));
        }
    }
}