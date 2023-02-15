using System;
using System.IO;
using Course.Entities; // Chamando a classe LogRecord para ele reconhecer

namespace Course {
    class Program {
        static void Main(string[] args) {

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' '); // Criar um string vetor recebendo a linha, baseado no espaço em branco
                        string name = line[0]; // Criar um string na posição zero que vai ser o username
                        DateTime instant = DateTime.Parse(line[1]); // DateTime recebedo ele ponto Parse baseado no line posição 1
                        set.Add(new LogRecord { Username = name, Instant = instant}); // Adiconar um new LogRecord recebendo nome e instante 
                        
                    }
                    Console.WriteLine("Total users: " + set.Count); // Quando le tudo ele vai ler a mensagem Total users concatenado com o tamanho do meu set
                } // Count que é a quantidade de elementos no meu conjunto
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}