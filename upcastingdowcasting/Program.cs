using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0); // Criamos dois objetos, um do tipo account e outro do tipo BusinesAccount
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0); //Colocando valores nos objetos
        
            // UPCASTING que é a conversão da subclasse para superclasse

            Account acc1 = bacc; //Account recebendo o businesaccount
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0); // Posso dar um new normal em um tipo da subclasse e atribuir para uma variável de superclasse
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01); // SavingsAccount é uma subclasse, Account é uma superclasse

            // DOWNCASTING conversão de superclasse para subclasse

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            if (acc3 is BusinessAccount) 
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // Outa forma de fazer 
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
                
                }
                if (acc3 is SavingsAccount)
                {
                    SavingsAccount acc5 = (SavingsAccount)acc3;
                    acc5.UpdateBalance();
                    Console.WriteLine("Uptade");
                } 
        }
    }
}