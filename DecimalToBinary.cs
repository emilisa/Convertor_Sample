using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convertor_Sample
{
    public class DecimalToBinary
    {
        /// <summary>
        /// This class - DecimalToBinary - converts given decimal number
        /// of type long to its binary representation as type string
        /// Examples: 0 = 0; 3 = 11; 5 = 101; 43691 = 1010101010101011
        /// Hardcode: 5 = (5 % 2)=1, (2 % 2)=0, (1 % 2)=1 = 101
        /// Hardcode: 8 = (8 % 2)=0, (4 % 2)=0, (2 % 2)=0, (1 % 2)=1 = 1000
        /// Hardcode: 3 = (3 % 2)=1, (1 % 2)=1 = 11
        /// </summary>

        //Local class DecimalToBinary variables

        static long number;
        static string binary;
        static string binaryReversed;
        
        public static void ConvertorDB(string input)
        {
            number = long.Parse(input);

            do
            {
                binary += (number % 2).ToString();

                number /= 2;
                
            } while (number != 0);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(StringReversor(binary));
            Console.ResetColor();
            binary = "";
            binaryReversed = "";
        }

        private static string StringReversor(string binary)
        {
            #region ReverseString Var.1

            //char[] array = binary.ToCharArray();

            //Array.Reverse(array);

            //string binaryReversed = array.ToString();

            //return binaryReversed;

            #endregion

            #region ReverseString Var.2

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                binaryReversed += binary[i];
            }

            return binaryReversed;

            #endregion

        }
    }
}
