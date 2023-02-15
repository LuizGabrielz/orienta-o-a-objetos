using System;
using System.Collections.Generic; // Para usar o HashSet, tem que usar o using System.Collections.Generic. (Mesmo using que a gente usa para listas)

namespace Course {

    class Program {

        static void Main(string[] args) {

            HashSet<string> set = new HashSet<string>(); // HashSet de string
            // Agora a gente tem um conjunto na memória instanciado, porem ele esta vazio
            set.Add("TV"); // Inserir alguns elementos usando o Add
            set.Add("Notebook"); // Inserir com o Add
            set.Add("Tablet"); // Inserir com o Add
     
            Console.WriteLine(set.Contains("Notebook")); // Verificar se existe Notebook
            // Se existir esse elemento no conjunto ele vai retornar verdadeiro, se não existir vai retornar falso
            foreach (string p in set) { // Vamos ter que usar o foreach pq ele vai pecorrer os elementos do conjunto, porem fazendo a interação dos elementos de forma interna conforme esta representada no conjunto
            // Para cada string p dentro do set, vai mandar imprimir esse "p"
                Console.WriteLine(p); // Mandar rodar
            }   
        }
    }
} 