using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convertor_Sample
{
    class HexadecimalToDecimal
    {
        /// <summary>
        /// This class - HexadecimalToDecimal - converts given Hexadecimal number
        /// of type string to its decimal representation as type long
        /// Examples: FE = 254; 1AE3 = 6883; 4ED528CBB4 = 338583669684
        /// Hint: A=10, B=11, C=12, D=13, E=14, F=15
        /// Hardcode: 2AF3 = 2*(16^3) + 10*(16^2) + 15*(16^1) + 3*(16^0) = 2*4096 + 10*256 + 15*16 + 3*1 = 10995
        /// Hardcode: 9BC = 9*(16^2) + 11*(16^1) + 12*(16^0) = 2*256 + 11*16 + 12*16 = 2492
        /// </summary>

        //Local class HexadecimalToDecimal variables        

        static long number;

        public static void ConvertorHD(string input)
        {
            long inputI = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    inputI = long.Parse(Convert.ToString(LetterToInteger(input[i])));
                }

                else
                {
                    inputI = long.Parse(Convert.ToString(input[i]));
                }

                number = number + (inputI * MathPower(16, input.Length - (i + 1)));
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(number);
            Console.ResetColor();
            number = 0;
            
            //tester built-in .NET functionality 
            //int dec = Convert.ToInt32(input, 16);
            //Console.WriteLine(dec);
        }

        private static int LetterToInteger(char letter)
        {
            int letterToInt = 0;
            
            switch (letter)
            {
                case 'a': letterToInt = 10; return letterToInt;
                case 'b': letterToInt = 11; return letterToInt;
                case 'c': letterToInt = 12; return letterToInt;
                case 'd': letterToInt = 13; return letterToInt;
                case 'e': letterToInt = 14; return letterToInt;
                case 'f': letterToInt = 15; return letterToInt;
                default: return letterToInt;
            }
        }

        private static long MathPower(int numToPow, int pow)
        {
            long poweredNum = 1;

            #region PowerNumber Var.1

            for (int i = 1; i <= pow; i++)
            {
                poweredNum = poweredNum * numToPow;
            }

            #endregion

            #region PowerNumber Var.2

            //poweredNum = (int)Math.Pow(numToPow, pow);

            #endregion

            return poweredNum;
        }

    }
}
