﻿﻿using System;

class Program {
    static void Main() {
        
        string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("***** Výpis řady čísel *****");
            Console.WriteLine("****************************");
            Console.WriteLine("******* Tomáš Žižka ********");
            Console.WriteLine("****************************");
            Console.WriteLine();

            Console.Write("Zadejte výšku obrazce (celé číslo)");
            


            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }

    }
}   