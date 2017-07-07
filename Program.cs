using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brief Opening to clearify instructions as well as the function of the program
            Console.WriteLine("Welcome to Brad's C# Encryptor!" + Environment.NewLine);
            Console.WriteLine("Please type in the messasge that you wish to encrypt");

            //string "usertext" obtains the user's original message 
            string userText = Console.ReadLine();

            //string "Etext" (Encrypted text) turns user input into lower case to make the message easier to encrypt 
            string Etext = userText.ToLower();

            //StringBulider Object "sb" converts the characters of the user's input into numbers rendering the encrypted message illegible
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(Etext);

            //For the time being this program replaces letters with random three-digit numbers in order to scramble the user's input
            //However I plan to use a more sophisticated process in the near future ( I am open to suggestions and I would love to hear them =) )
            sb.Replace("a", "349");
            sb.Replace("b", "110");
            sb.Replace("c", "929");
            sb.Replace("d", "853");
            sb.Replace("e", "330");
            sb.Replace("f", "753");
            sb.Replace("g", "635");
            sb.Replace("h", "838");
            sb.Replace("i", "941");
            sb.Replace("j", "543");
            sb.Replace("k", "185");
            sb.Replace("l", "462");
            sb.Replace("m", "118");
            sb.Replace("n", "450");
            sb.Replace("o", "430");
            sb.Replace("p", "309");
            sb.Replace("q", "268");
            sb.Replace("r", "311");
            sb.Replace("s", "948");
            sb.Replace("t", "757");
            sb.Replace("u", "218");
            sb.Replace("v", "439");
            sb.Replace("w", "610");
            sb.Replace("x", "625");
            sb.Replace("y", "271");
            sb.Replace("z", "570");

            //print the recently encrypted message
            Console.WriteLine(sb.ToString() + Environment.NewLine);

            //Brief conclusion to congratulate the user and provide them insight on how to decrypt their message
            Console.WriteLine("Congratulations! You're message has been encrypted" + Environment.NewLine);

            Console.WriteLine("If you wish to Decrypt your message please visit the second file labled 'Decryptor'");

            Console.ReadLine();

            //I hope you enjoyed =)
        }
    }
}
