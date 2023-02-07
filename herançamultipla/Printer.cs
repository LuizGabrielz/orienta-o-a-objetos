using System;

namespace Course.Devices {
    class Printer : Device, IPrinter { //Herdar de Device e herdar tb de IPrinter

        public override void ProcessDoc(string document) { // Sobrescreve ProcessDoc que é um método abstrato, eu sou obrigado a reescrever 
            Console.WriteLine("Printer processing: " + document); // Printer processing para a gente ver o que está acontecendo

        }

        public void Print(String document) {
            Console.WriteLine("Printer print " + document); // Outro método printer da class "Print"
        }
            
        }
    }