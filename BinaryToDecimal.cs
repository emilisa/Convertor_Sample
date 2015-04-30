using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convertor_Sample
{
    public class BinaryToDecimal
    {
        /// <summary>
        /// This class - BinnaryToDecimal - converts given binary number
        /// of type string to its decimal representation as type long
        /// Examples: 0 = 0; 11 = 3; 101 = 5; 1010101010101011 = 43691
        /// Hardcode: 101 = (1*2)^2 + (0*2)^1 + (1*2)^0 = (4 + 0 + 1) = 5
        /// Hardcode: 11 = (1*2)^1 + (1*2)^1 = (2 + 1) = 3
        /// </summary>

        //Local class BinnaryToDecimal variables
        
        static long number;
        
        public static void ConvertorBD(string input)
        {
            int zeroOrOne = 0;

            for (int i = 0; i < input.Length; i++)
            {
                zeroOrOne = int.Parse(Convert.ToString(input[i]));

                number += zeroOrOne * MathPower(2, input.Length - (i + 1));
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(number);
            Console.ResetColor();
            number = 0;
        }

        private static int MathPower(int numToPow, int pow)
        {
            int poweredNum = 1;

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
