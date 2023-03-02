using System;
using System.Collections.Generic;
using System.IO;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter file full path: "); // Entre com o caminho completo do arquivo
            string path = Console.ReadLine(); // Leitura do texto

            try {
                using (StreamReader sr = File.OpenText(path)) { // Use o arquivo salvo do caminho

                    Dictionary<String, int> dictionary = new Dictionary<string, int>(); // Instanciar um Dictionary que recebe uma string e um int

                    while (!sr.EndOfStream) {

                        string[] votingRecord = sr.ReadLine().Split(',');  // Separador por vírgula(split) ler o valor de "sr" que são os votos 
                        string candidate = votingRecord[0]; // String cadidato recbe o valor votingRecord na posição zero
                        int votes = int.Parse(votingRecord[1]); // int votos mostrando os votos na posição 1

                        if (dictionary.ContainsKey(candidate)) { // Se em dicitionary tiver a chave candidato
                            dictionary[candidate] += votes; // vai receber o própio valor mais o número
                        }
                        else {
                            dictionary[candidate] = votes; // Mostrar od votos
                        }
                    }

                    foreach (var item in dictionary) { // Para cada item dentro do dictionary
                        Console.WriteLine(item.Key + ": " + item.Value); // Vai mostrar o item chave e o item valor
                    }
                     }
                        }
                        catch (IOException e) { // Se não tiver nada, mostra a mensagem abaixo
                            Console.WriteLine("An error occurred"); // Ocorreu um erro
                            Console.WriteLine(e.Message); // Mostrar a mensagem
                        }
                    }
                }
            }