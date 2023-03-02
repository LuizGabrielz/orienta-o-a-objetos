using System;
using System.Collections.Generic;

namespace Course {

    class Program {
        static void Main(String[] args) {

        Dictionary<string, string> cookies = new Dictionary<string, string>(); // Parametrizar qual tipo da chave e qual o tipo do valor. Instanciamos o Dictionary
        // Nesse exercicio vamos incrementar um cookie
        cookies["user"] = "maria";// cookies usuario vai receber o valor Maria
        cookies["email"] = "maria@gmail.com";// cookies email vai receber o email
        cookies["phone"] = "99712234";// cookies phone vai receber o número de telefone
        cookies["phone"] = "83737388";// cookies phone vai receber um telefone diferente

        Console.WriteLine(cookies["email"]);
        Console.WriteLine(cookies["phone"]); //Mandar imprimir dos cookies o fone e o email

        cookies.Remove("email"); // Mandar remover a chave email no cookie

        Console.WriteLine(cookies["email"]);

        if (cookies.ContainsKey("email")) { // Se existir a chave email no cookies, ela vai aparecer
            Console.WriteLine(cookies["email"]);
        }
        else {
            Console.WriteLine("There is no 'email' key"); // Caso não tenha, ele vai mostrar essa mensagem
        }

        Console.WriteLine("Size: " + cookies.Count); // Imprimir o tamanho do Dictionary concatenado com cookies.Count. O Count vai falar pra mim o tamanho 
        
        Console.WriteLine("ALL COOKIES: "); // Imprimir tudo
        foreach (KeyValuePair<string, string> item in cookies) { // Pecorrer um Dictionary fazendo um foreach. Como o Dictionary ele é uma coleção, ele implementa o Inurable, então o foreach funciona com ele tb
            Console.WriteLine(item.Key + ": " + item.Value); // Para cada item do tipo KeyValuePair string, string dentro do meu cookies
            // Vou mandar imprimir na tela o item.Key pra imprimir a chave, concatenar isso aqui com : " e concatenar com meu item.Value 
            // Estou pecorrendo cada um dos pares que é do tipo string, string e pra eu acessar a chave do tipo key e do tipo Value(Pra acessar a chave é tipo key, pra acessar o valor é tipo Value)
        }
      }
     }
    }