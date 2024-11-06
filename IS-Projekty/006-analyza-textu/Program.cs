﻿using System;

class Program {
    static void Main() {
        
        string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("****************************************");
            Console.WriteLine("***** Výpis samohlásek a souhlásek *****");
            Console.WriteLine("****************************************");
            Console.WriteLine("************** Alex Funke **************");
            Console.WriteLine("****************************************");
            Console.WriteLine();

            Console.Write("\Zadejte váš text:");
            string myText = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(myText);
            Console.WriteLine(myText{0});
            Console.WriteLine(myText.Lenght);

            string samohlasky = "aáeéiíoóuůúyý";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž";
            string cislice = "0123456789";


            int pocetSamohlaska = 0;
            int pocetSouhlasek = 0;
            int pocetCislic = 0;
            int pocetOstatnich = 0;

            foreach(char znak in myText){
                if(souhlasky.Contains znak){
                    pocetSouhlasek++;
                }
                else if(samohlasky.Contains znak){
                    pocetSamohlasek++;
                }
                else if(cislice.Contains znak){
                    pocetCislic++;
                }
                else
                pocetOstatnich++;  
            }    



            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }

    }
}    
