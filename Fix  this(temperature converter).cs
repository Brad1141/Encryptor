using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello {0}, how are you today? ", Name);
            string emotion = Console.ReadLine();
            Console.WriteLine("That is Wonderfull!, How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cool! I am 17 years old, that means I am {0} older than you", 17 - age);
            Console.ReadLine();
        }
    }
}
