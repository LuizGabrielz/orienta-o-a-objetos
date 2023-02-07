using System;

namespace Course.Devices {
    class Scanner : Device, IScanner { // Classe Scanner herda de Device e tb de IScanner

        public override void ProcessDoc(string document) { // Ela vai sobrescrever o método ProcessDoc
            Console.WriteLine("Scanner processing: " + document); // WriteLine pra gente ter o controle do que está acontecendo
        } // O ProcessDoc vem do Device

        public string Scan() { // Incluir o método Scan que vai retornar o string
            return "Scanner scan result"; // Retornando scan result só pra ter controle do que aconteceu
        }
            
        } // O Scan vem do IScanner
    }