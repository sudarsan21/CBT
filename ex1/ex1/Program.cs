using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = (char)Console.Read();
            if(char.IsLetter(c))
            {
                if(char.IsUpper(c))
                {
                    Console.WriteLine("\n Upper case");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\n Lower case");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("\n Other Character");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
