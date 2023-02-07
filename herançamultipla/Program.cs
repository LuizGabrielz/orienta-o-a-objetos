using System;
using Course.Devices;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Printer p = new Printer() { SerialNumber = 1080 }; // Objeto do tipo "Printer"
            p.ProcessDoc("My letter"); // Chama o ProcessDoc
            p.Print("My letter"); // Chama o Print com o My Letter

            Scanner s = new Scanner() { SerialNumber = 2003 }; // Objeto do tipo "Scanner". O print tem o SerialNumber
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 }; //Instanciei o objeto
            c.ProcessDoc("My dissertation"); // Chamo o ProcessDoc
            c.Print("My dissertation");
            Console.WriteLine(c.Scan()); // Dou um WriteLine no Scan

        }
    }
}