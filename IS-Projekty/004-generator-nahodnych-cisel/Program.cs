﻿using System;

class Program {
    static void Main() {
        
        string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Generátor náhodných čísel *****");
            Console.WriteLine("*************************************");
            Console.WriteLine("************* Alex Funke ************");
            Console.WriteLine("*************************************");
            Console.WriteLine();

            Console.WriteLine("Zadejte počet generovaných čísel (celé číslo)");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)){
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu");
            }

            Console.WriteLine("Zadejte dolní mez (celé číslo)");
            int dn;
            while(!int.TryParse(Console.ReadLine(), out n)){
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu");
            }

            Console.WriteLine("Zadejte horní mez (celé číslo)");
            int hn;
            while(!int.TryParse(Console.ReadLine(), out n)){
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu");
            }

            Console.WriteLine();
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dn, hn);
            Console.WriteLine("***********************************************************");
            Console.WriteLine();

            int[] myArray = new int[n];

            Random randomNumber = new Random();

            Console.WriteLine("\n\nNáhodná čísla:");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dn, hn);
                Console.WriteLine("{0}; ", myArray[i]);
                }
                
                while(again == "a") {
                for(int i=0, int<n, i++) {
                    else
                        nuly
                    }
                if(myArray[i]>0)
                    kladna++;
                if(myArray[i]<0)
                    zaporna++;
                if(myArray[i]==0)
                    nuly++;
            }


            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }

    }
}    
