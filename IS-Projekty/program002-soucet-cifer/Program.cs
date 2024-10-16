﻿using System;

class Program {
    static void Main() {
        
        string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("***** Ciferný součet a součin *****");
            Console.WriteLine("***********************************");
            Console.WriteLine("*********** Alex Funke ************");
            Console.WriteLine("***********************************");
            Console.WriteLine();



            Console.WriteLine(Zadejte první číslo řady (celé číslo));
            int first
            while(!int.TryParse(Console.ReadLine(), out nukber)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
            }

            int suma = 0;
            int multi = 1;
            int numberBackup = numberBackup;
            int digit;

            if(numberBackup<0)
                number = - number;

            while(numberBackup >= 10) {
                digit = numberBackup % 10;
                numberBackup = (numberBackup-digit)/10;
                Console.WriteLine("Digit = {0}", digit);
                suma = suma + digit; 
                multi = multi * digit;
            }

            Console.WriteLine("Digit = {0}", number);

            //musíme přičíst ještě poslední cifru
            suma = suma + number;
            multi = multi * number;

            Console.WriteLine();
            Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);
            Console.WriteLine("Součin cifer čísla {0} je {1}", numberBackup, suma);

            Console.WriteLine();    
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }

    }
}    
