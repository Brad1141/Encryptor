using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Clear();

            GreetUser();

            MakeChoiceBasedOnUsersDecision();

            Console.ReadLine();

        }  

        static void GreetUser()
        {
            Console.WriteLine("Do you wish to decrypt a message? (Please type either 'yes' or 'no')");
        }

        static void MakeChoiceBasedOnUsersDecision()
        {
            string answer = Console.ReadLine();
            string answer1 = answer.ToLower();

            if (answer1 == "yes")
            {
                EncryptText();
            }

            else if (answer1 == "no")
            {
                SayGoodbye();
            }

            else
            {
                Error();
            }
        }

        static void EncryptText()
        {
            Console.WriteLine("Excellent! Please type the message you want encrypted in the space below");

            //string 'Ctext' (cipher text) obtains the message that needs decrypting
            string Ctext = Console.ReadLine();

            string Ctext1 = Ctext.ToLower();

            //The StringBuilder 'sb' converts the three-digit numbers back into the original text
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(Ctext);
            sb.Replace("349", "a");
            sb.Replace("110", "b");
            sb.Replace("929", "c");
            sb.Replace("853", "d");
            sb.Replace("330", "e");
            sb.Replace("753", "f");
            sb.Replace("635", "g");
            sb.Replace("838", "h");
            sb.Replace("941", "i");
            sb.Replace("543", "j");
            sb.Replace("185", "k");
            sb.Replace("462", "j");
            sb.Replace("118", "k");
            sb.Replace("450", "n");
            sb.Replace("430", "o");
            sb.Replace("309", "p");
            sb.Replace("268", "q");
            sb.Replace("311", "r");
            sb.Replace("948", "s");
            sb.Replace("757", "t");
            sb.Replace("218", "u");
            sb.Replace("439", "v");
            sb.Replace("610", "w");
            sb.Replace("625", "x");
            sb.Replace("271", "y");
            sb.Replace("570", "z");

            //Print original message 
            Console.WriteLine(sb.ToString() + Environment.NewLine);

            //Brief conclusion
            Console.WriteLine("Your decrypted message is in the space above ^ " + Environment.NewLine);

            Console.WriteLine("I hope you enjoyed the presentation and have a wonderfull day!");
        }

        static void SayGoodbye()
        {
            Console.WriteLine("No problem! Come back later if you have a message you need decrypted, " +
                "and have a wonderful day! =) ");
        }

        static void Error()
        {
            Console.WriteLine("ERROR : please type in either 'yes' or 'no' ");
        }
    }
}
