﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Clear();
            
            Greetings();

            EncryptText();

            Conclusion();

            Console.ReadLine();

        }

        public static void Greatings()
        {
            Console.WriteLine("Welcome to Brad's C# Encryptor!" + Environment.NewLine);
            Console.WriteLine("Please type in the messasge that you wish to encrypt");

        }

        public static void EncryptText()
        {
            string userText = Console.ReadLine();
            string Etext = userText.ToLower();

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(Etext);

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


            Console.WriteLine(sb.ToString() + Environment.NewLine);
        }
        public static void Conclusion()
        {
            Console.WriteLine("Congratulations! You're message has been encrypted" + Environment.NewLine);

            Console.WriteLine
                ("If you wish to Decrypt your message please visit the second file labled 'Decryptor'");
        }

    }

}



