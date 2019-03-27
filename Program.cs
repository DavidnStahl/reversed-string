using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a word: ");
            string word = Console.ReadLine();
            string revString = ReverseString(word);
            Console.WriteLine("Your word reversed: " + revString);
            Console.ReadLine();

        }
        public static string ReverseString(string word)
        {
            string reversedString = "";
            
            int wordLength = word.Length -1;

            while (wordLength >= 0)
            {
                reversedString += word[wordLength];
                wordLength--;
            }
            return reversedString;
        }
        
    }
}
