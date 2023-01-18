using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

           // DateTime d1 = DateTime.Now; // Devolve o instante atual do sistema
            //Console.WriteLine(d1);

           /* DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            */

            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
        }
    }
}