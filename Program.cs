using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Convertor_Sample
{
    class Program
    {
        /// <summary>
        /// Using loops write a program that converts:
        /// An integer number to its binary representation. 
        /// The input is entered as long. The output should be a variable of type string.
        /// <summary>
        /// A binary integer number to its decimal form. 
        /// The input is entered as string. The output should be a variable of type long. 
        /// <summary>
        /// A hexadecimal integer number to its decimal form. 
        /// The input is entered as string. The output should be a variable of type long. 
        /// <summary>
        /// An integer number to its hexadecimal representation. 
        /// The input is entered as long. The output should be a variable of type string.
        /// Do not use the built-in .NET functionality.
        /// </summary>

        //Local variables

        static string input;
        static string comand;
        static string programStatus;
        
        private static void Main()
        {
            programStatus = "Initialization";
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Status: {0}", programStatus);
            Console.ResetColor();
            Console.WriteLine("For - Decimal To Binnary conversion type: 1");
            Console.WriteLine("For - Binnary To Decimal conversion type: 2");
            Console.WriteLine("For - Hexadecimal To Decimal conversion type: 3");
            Console.WriteLine("For - Decimal To Hexadecimal conversion type: 4");
            Console.WriteLine("For - Exit type: exit");

            comand = Console.ReadLine().ToLower();

            CheckComandForError(comand);
            
            if (comand == "1")
            {
                programStatus = "DecimalToBinnary";
                
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Status: {0}", programStatus);
                    Console.ResetColor();
                    Console.WriteLine("Type decimal number or 'return': ");

                    input = Console.ReadLine().ToLower(); ;

                    if (input == "return")
                    {
                        break;
                    }

                    Console.WriteLine("The number {0} to binary is:", input);

                    DecimalToBinary.ConvertorDB(input);

                } while (input != "return");

                Main();
            }

            else if (comand == "2")
            {
                programStatus = "BinnaryToDecimal";
                
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Status: {0}", programStatus);
                    Console.ResetColor();
                    Console.WriteLine("Type binnary number or 'return': ");

                    input = Console.ReadLine().ToLower(); ;

                    if (input == "return")
                    {
                        break;
                    }

                    Console.WriteLine("The number {0} to decimal is:", input);

                    BinaryToDecimal.ConvertorBD(input);

                } while (input != "return");

                Main();
            }

            else if (comand == "3")
            {
                programStatus = "HexadecimalToDecimal";

                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Status: {0}", programStatus);
                    Console.ResetColor();
                    Console.WriteLine("Type hexadecimal number or 'return': ");

                    input = Console.ReadLine().ToLower(); ;

                    if (input == "return")
                    {
                        break;
                    }

                    Console.WriteLine("The number {0} to decimal is:", input.ToUpper());

                    HexadecimalToDecimal.ConvertorHD(input);

                } while (input != "return");

                Main();
            }

            else if (comand == "4")
            {
                programStatus = "DecimalToHexadecimal";

                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Status: {0}", programStatus);
                    Console.ResetColor();
                    Console.WriteLine("Type decimal number or 'return': ");

                    input = Console.ReadLine().ToLower(); ;

                    if (input == "return")
                    {
                        break;
                    }

                    Console.WriteLine("The number {0} to hexadecimal is:", input.ToUpper());

                    DecimalToHexadecimal.ConvertorDH(input);

                } while (input != "return");

                Main();
            }

            else if (comand == "exit")
            {
                programStatus = "Exit";
                
                for (int i = 3; i >= 0; i--)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Status: {0}", programStatus);
                    Console.ResetColor();
                    Console.WriteLine("Program is closing...{0}", i);
                    Thread.Sleep(1000);
                }

                Environment.Exit(0);
            }
        }

        private static void CheckComandForError(string comand)
        {

            if (programStatus == "Initialization")
            {
                if (comand != "1" && comand != "2" && comand != "3" && comand != "4" && comand != "exit")
	            {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Comand \"{0}\" is wrong", comand);
                    Thread.Sleep(3000);
                    Console.ResetColor();
                    Main();
                }
            }

            else if (programStatus == "BinnaryToDecimal")
            {
                //TODO
            }

            else if (programStatus == "DecimalToBinnary")
            {
                //TODO
            }

            else if (programStatus == "DecimalToHexadecimal")
            {
                //TODO
            }

            else if (programStatus == "HexadecimalToDecimal")
            {
                //TODO
            }
        }
    }
}
