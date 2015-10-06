using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am jAIson, son of Bobnomercy. It's nice to have a friend to talk to, ask me a question please.");
            string input = Console.ReadLine(); 
            checkText(input);
            Console.ReadLine();
        }

        static void checkText(string input)
        {
            string newInput = filterText(input);
            Console.WriteLine(newInput);
        }

        //remove any punctuation, return first sentence in question if more than one is given
        static string filterText(string input)
        {
            string newInputText = input;
            if (newInputText != string.Empty)
            {
                newInputText = newInputText.Replace(",", "");
                newInputText = newInputText.Split('.')[0];
            }

            return newInputText;
        }
    }
}
