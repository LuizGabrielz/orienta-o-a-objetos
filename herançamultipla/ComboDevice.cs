using System;

namespace Course.Devices {
    class ComboDevice : Device, IScanner, IPrinter { // Classe ComboDevice herda de Device, porém vai herdar tb de IScanner e IPrinter
        public void Print(string document) {
            Console.WriteLine("Combodevice print " + document);
        }

        public override void ProcessDoc(string document) {
            Console.WriteLine("Combodevice processing " + document);
        }

        public string Scan() {
            return "Combodevice scan result";
        }
        }
    }