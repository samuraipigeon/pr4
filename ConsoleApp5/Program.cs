using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string sentence = "Якщо не можна вітер змалювати, прозорий вітер на ясному тлі, — змалюй дуби, могутні та крислаті, котрі од вітру гнуться до землі.";
            Console.WriteLine(sentence);
            Console.WriteLine("Введіть літеру: ");
            string find = Console.ReadLine();
            string[] s1 = sentence.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in s1) 
            {
                if(word.StartsWith(find)) {Console.Write(word+" "); }
                
            }
            Console.ReadLine();
        }
    }
}