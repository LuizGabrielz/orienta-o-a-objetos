using System;
using Course.Entities;
using Course.Entities.Enums;


namespace Course {
    class Program {
        static void Main(string[] args) {
        
        Order order = new Order {
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment // Pega o valor de PendingPayment 
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); // Imprimiu o valor de PendingPayment em String

           OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // Conversão de string para tipo enumerado

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}