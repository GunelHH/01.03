using System;
namespace _01._03
{
    static class Search
    {
        //Task2
       public static bool Contain(this string[] sentence,string word)
        {
            foreach (string  item in sentence)
            {
               while (item==word)
                {
                    return true;
                }
               
            }return false;
        }
    }
}
