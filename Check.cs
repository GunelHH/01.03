using System;
using System.Text;

namespace _01._03
{
    static class Check
    {
        //Task1
        public static string IsCapitalized(this string words)
        {
            words = words.ToLower();
            StringBuilder stringBuilder = new StringBuilder();
            string[] arr = words.Split(' ');
            foreach (string word in arr)
            {
                char.ToUpper(word[0]);
                stringBuilder.Append(arr);
            }


            return stringBuilder.ToString();
        }


    }
}
