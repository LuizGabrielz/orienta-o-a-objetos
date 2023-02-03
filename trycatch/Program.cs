using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

          try { // Tente
            int n1 = int.Parse(Console.ReadLine()); // Variável recebendo int.Parse
            int n2 = int.Parse(Console.ReadLine()); // Variável recebendo int.Parse

            int result = n1 / n2; // Variável "result" para receber o resultado
            Console.WriteLine(result); // Mostrar na tela o resultado
          }
            catch (DivideByZeroException) {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e ) { // O "e" é um apelido que a gente da pra xception
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}