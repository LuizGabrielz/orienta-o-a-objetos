using System;
using System.IO;
using System.Collections.Generic;
using Course.Entities;

namespace Course {
    class Program {
        static void Main(string[] args) {

            string path = @"c:\temp\in.txt"; // Informando um caminho hardcover

            try {
                using (StreamReader sr = File.OpenText(path)) { // Abrindo um arquivo usando o StreamReader
                    List<Employee> list = new List<Employee>(); // Vou criar uma lista 
                    while (!sr.EndOfStream) { // Pecorrer o arquivo e enquanto não for o final do arquivo eu vou
                        list.Add(new Employee(sr.ReadLine())); // Adiconar a minha lista a linha que eu le nesse arquivo
                    } // Vou ter uma lista preenchida com cada um dos nomes que vão colocar 
                    list.Sort(); // Para ordernar a lista a gente tem que usar o método Sort
                    foreach (Employee emp in list) { // Foreach para cada empregado na minha lista
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e ) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
      } 
    }