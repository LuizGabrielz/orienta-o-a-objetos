/*
using System;
using System.Collections.Generic;

namespace Course {

    class Program {

        static void Main(String[] args) {

        SortedSet<int> a = new SortedSet<int>() {0, 2, 4, 5, 6, 8, 10 }; Instanciar um SortedSet
        SortedSet<int> b = new SortedSet<int>() {5, 6, 7, 8, 9, 10};
        Cada objeto vai ser um número inteiro
       
        Union
        SortedSet<int> c = new SortedSet<int>(a);
        c.UnionWith(b);
        PrintCollection(c);

        intersection
        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b);
        PrintCollection(d);

        difference 
        SortedSet<int> e = new SortedSet<int>(a);
        e.ExceptWith(b);
        PrintCollection(e);
    }

        static void PrintCollection<T>(IEnumerable<T> collection) {
            foreach (T obj in collection) {Função printCollection pra printar uma coleção
            
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}*/

// SortedSet mantém os elementos ordenados