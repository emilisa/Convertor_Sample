using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convertor_Sample
{
    class DecimalToHexadecimal
    {
        /// <summary>
        /// This class - DecimalToHexadecimal - converts given Decimal number
        /// of type int to its hexadecimal representation as type string
        /// Examples: 254 = FE; 6883 = 1AE3; 338583669684 = 4ED528CBB4
        /// Hint: A=10, B=11, C=12, D=13, E=14, F=15
        /// Hardcode: 428591 = 428591 % 16 = 15, 26786 % 16 = 2, 1674 % 16 = 10, 104 % 16 = 8, 6 % 16 = 6 = 68A2F 
        /// </summary>

        //Local class DecimalToHexadecimal variables

        static long number;
        static string hexadecimal;
        static string hexadecimalReversed;
        
        public static void ConvertorDH(string input)
        {
            number = long.Parse(input);

            do
            {
                if (number % 16 >= 10)
                {
                    hexadecimal += IntegerToLetter((int)(number % 16));
                }

                else
                {
                    hexadecimal += (number % 16).ToString();
                }

                number /= 16;

            } while (number != 0);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(StringReversor(hexadecimal));
            Console.ResetColor();
            hexadecimal = "";
            hexadecimalReversed = "";

            //tester built-in .NET functionality. 
            //int number = int.Parse(input);
            //string hex = Convert.ToString(number, 16);
            //Console.WriteLine(hex.ToUpper());
        }

        private static string IntegerToLetter(int number)
        {
            string letterABCDEF = "";

            switch (number)
            {
                case 10: letterABCDEF = "A"; return letterABCDEF;
                case 11: letterABCDEF = "B"; return letterABCDEF;
                case 12: letterABCDEF = "C"; return letterABCDEF;
                case 13: letterABCDEF = "D"; return letterABCDEF;
                case 14: letterABCDEF = "E"; return letterABCDEF;
                case 15: letterABCDEF = "F"; return letterABCDEF;
                default: return letterABCDEF;
            }
        }

        private static string StringReversor(string hexadecimal)
        {
            #region ReverseString Var.1

            //char[] array = binary.ToCharArray();

            //Array.Reverse(array);

            //string binaryReversed = array.ToString();

            //return binaryReversed;

            #endregion

            #region ReverseString Var.2

            for (int i = hexadecimal.Length - 1; i >= 0; i--)
            {
                hexadecimalReversed += hexadecimal[i];
            }

            return hexadecimalReversed;

            #endregion

        }
    }
}
