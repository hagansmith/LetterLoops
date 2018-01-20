using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;


namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some characters \n-----------------------");

            string input = Console.ReadLine();
            string builtString = "";

            for (int i = 0;  i < input.Length; i++)
            {
                var character = input[i];
                string toUpper = character.ToString().ToUpper();
                if (i == 0)
                {
                    builtString += $"{toUpper}-";
                }
                else if (i == input.Length-1)
                {
                    string repeat = new String(character, i);
                    builtString += $"{toUpper}{repeat}";
                }
                else
                {
                    string repeat = new String(character, i);
                    builtString += $"{toUpper}{repeat}-";
                }
            }
            Console.WriteLine(builtString);
            Console.ReadLine();
        }
    }
}
