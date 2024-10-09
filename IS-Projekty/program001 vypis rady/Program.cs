using System;

class Program {
    static void Main () {

        string again = "a";

        while(again== "a") {

            Console.WriteLine("*****************************");
            Console.WriteLine("***Výpis řady čísel**********");
            Console.WriteLine("*****************************");
            Console.WriteLine("***Alex Funke****************");
            Console.WriteLine("*****************************");
            Console.WriteLine();

            // vstup do programu
            //Console.Write("Zadejte první číslo: ");
            //int first = int,Parse(Console.ReadLine());

            //Vstup hodnot do programu - správné řešení
            Console.Write("Zadejte první celé číslo: ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)) {
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu");
            }
            Console.Write("Zadejte druhé celé číslo: ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)) {
                Console.Write("Nezadali jste celé číslo. Zadejte druhé číslo řady znovu");
            }     
            Console.Write("Zadejte třetí celé číslo: ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)) {
                Console.Write("Nezadali jste celé číslo. Zadejte třetí číslo řady znovu");
            }

            //Výpis řady I
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine("Výpis číselné řady");
            int current = first;
            while(current < last) {
                Console.WriteLine(current);
                current = current + step; // Ruční přičtení diference
            }
            Console.WriteLine("Zadali jste tyto hodnoty: ");
            Console.WriteLine("První číslo řady: {0}", first);
            Console.WriteLine("První číslo řady: {0}", step);
            Console.WriteLine("První číslo řady: {0}", last);


            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");    
            again = Console.ReadLine();
        }
    }    
}


// toto je jednořádkový komentář
 
/* dvouřádkový
komentář */
