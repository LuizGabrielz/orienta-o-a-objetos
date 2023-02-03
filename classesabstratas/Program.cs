using System;
using System.Collections.Generic; // Importar lista
using System.Globalization; // Para fuincionar o CultureInfo.InvariantCulture
using Course.Entities;
// Não podemos criar uma instancia com uma classe que está abstrata

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
        List<Account> list = new List<Account>(); // Mesmo a classe sendo abstrata, podemos colocar ele em uma lista
        // Se a classe Account não existisse, a gente não poderia pegar uma lista e misturar tipos diferentes de cada lista. Como eu tenho uma superclasse genérica, ai eu posso fazer isso
        list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01)); // Adicionar outros elementos em uma lista
        list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
        list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
        list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));
       
       double sum = 0.0; // Criar uma variável soma
       foreach (Account acc in list) // Para cada Account(vou chamar de Acc aqui o apelido dela) na minha lista "List" vou somar 
       { // Pecorri a lista de uma vez só e tenho a totalização dos saldos da minhas contas 
            sum += acc.Balance;
       }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture)); // Soma transforma em string(com o ToString) "f2" pula duas casas decimais 
        
        foreach (Account acc in list) // Para cada conta acc na minha lista, eu vou chamar o Withdraw
        {
            acc.Withdraw(10.0); // Eu vou sacar 10 reais de minha conta
        }

        foreach (Account acc in list)
        {
            Console.WriteLine("Updated balance for account " // Imprimir o saldo atualizado da minha conta
                + acc.Number // Numero da conta
                + ": " // Dois pontos para ficar organizado
                + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)); // Mostrar o saldo da conta
            
        }

        }
    }
} 