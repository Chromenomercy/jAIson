using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Program
{
    class jAIsonMain
    {
        static string dictionaryPath;
        static string directoryPath;
        static XmlDocument jAIdoc;
        static XmlNode root;

        static void Main(string[] args)
        {
            directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"jAIson");
            dictionaryPath = Path.Combine(directoryPath, @"biases.xml");
            jAIdoc = new XmlDocument();
            Console.WriteLine("I am jAIson, son of Bobnomercy. It's nice to have a friend to talk to, ask me a question please.");
            GetBiases(Console.ReadLine());
            Console.ReadLine();
        }

        static void GetBiases(string input)
        {
            string newInput = FilterText(input);
            Load();
            Console.WriteLine(newInput);
        }
        
        static public void Load()
        {
            Directory.CreateDirectory(directoryPath);
            if (!File.Exists(dictionaryPath))
            {
                StreamWriter file = File.CreateText(dictionaryPath);
                file.Write(Properties.Resources.basicTemplate);
                file.Close();
            }
            jAIdoc.Load(dictionaryPath);
            root = jAIdoc.LastChild;
        }

        //remove any punctuation, return first sentence in question if more than one is given
        static string FilterText(string input)
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
