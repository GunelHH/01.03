using System;

namespace _01._03
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word= "exTensiON claSSi staTIc OLMalIdiR ";
            // Console.WriteLine(word.IsCapitalized());
            string[] str = { "salam", "dunya" };
            Console.WriteLine(Search.Contain(str, "dunya"));

        }
    }
}

