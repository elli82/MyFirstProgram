using System;

namespace MyFirstProgram  //Elin Línderholm SUT22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number= 7;   //deklarerar en variabel o bestämmer den till 7

                if (number > 10)    //skriver ut huruvida talet är stort eller litet med en if-sats
                Console.WriteLine("Talet är stort!");
                else
                Console.WriteLine("Oj. Lågt tal!");

            Console.WriteLine("Vad heter du?");  //Frågar vad användaren heter, sparar och skriver ut det
            string myName=Console.ReadLine();
            Console.WriteLine("Hej " + myName +"!");            

            for (int i=0; i <8; i++) // räknar upp till valda talet 7 med en for-loop
            {
                Console.WriteLine(i);
            }
        }
    }
}