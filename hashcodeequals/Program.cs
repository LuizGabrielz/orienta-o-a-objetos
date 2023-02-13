using System;

namespace Course {

    class Program {

        static void Main(string[] args) {

            string a = "Maria";
            string b = "Alex";

            Console.WriteLine(a.Equals(b)); // Ja tem o Equals pq o "A" é do tipo string e a string implementa a operação Equals 
        } // Deu falso pq o realmente o nome "Maria" é diferente do nome "Alex"
    }     // Se fosse Maria com Maria ia dar true pq os objetos são iguais
}