using System;
using System.Collections.Generic;

namespace Course {

    class Program {
        static void Main(String[] args) {

        Dictionary<string, string> cookies = new Dictionary<string, string>();

        cookies["user"] = "maria";
        cookies["email"] = "maria@gmail.com";
        cookies["phone"] = "99712234";
        cookies["phone"] = "83737388";

        Console.WriteLine(cookies["email"]);
        Console.WriteLine(cookies["phone"]);

        cookies.Remove("email");

        Console.WriteLine(cookies["email"]);

        if (cookies.ContainsKey("email")) {
            Console.WriteLine(cookies["email"]);
        }
        else {
            Console.WriteLine("There is no 'email' key");
        }

        Console.WriteLine("Size: " + cookies.Count);
        
        }

        }
    }