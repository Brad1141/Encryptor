using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor_and_Decryptor
{
    class Program
    {
        static void Main(string[] args)
        {
                //Brief introduction to clarify instructions 
                Console.WriteLine("Please type in the messasge that you wish to encrypt");

                //String 'userText' obtains the message that will be encrypted
                string userText = Console.ReadLine();
                
                //string 'Etext'(Encrypted text) converts the user's text into lowercase
                string Etext = userText.ToLower();
                
                //StringBuilder 'sb' encrypts the input by swaping the letters with numbers
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
                
                //Prints results
                Console.WriteLine(sb.ToString() + Environment.NewLine);
                
                //Instructions for decrypting
                Console.WriteLine("Do you wish to decrypt this message? (Please type either 'yes' or 'no')");
                
                //string 'answer' obtains the encrypted message
                string answer = Console.ReadLine();
                
                //string 'answer1' converts user input to lowercase
                string answer1 = answer.ToLower();
                
                //if user answered yes
                if (answer1 == "yes")
                {
                    //Transfers message from string 'Etext' to string 'Dtext'(Decrpyted text)
                    string Dtext = Etext;
                   
                    //new StringBuilder 'sbb' converts numbers back into readible text
                    StringBuilder sbb = new StringBuilder();

                    sbb.AppendFormat(Dtext);
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

                    //Print results
                    Console.WriteLine(sbb.ToString() + Environment.NewLine);

                    Console.WriteLine("I hope you enjoyed the presentation and have a wonderfull day!");
                }

                //If user answered no
                else if (answer1 == "no")
                {
                    Console.WriteLine("I hope you enjoyed the presentaion and have a wonderfull day! =) ");
                }

                //If user's answer is not 'Yes' or 'No'
                else
                {
                    Console.WriteLine("ERROR : please type in either 'yes' or 'no' ");
                }
                Console.ReadLine();

            }
        }
    }
