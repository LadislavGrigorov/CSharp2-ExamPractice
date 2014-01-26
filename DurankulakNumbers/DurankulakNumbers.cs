using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurankulakNumbers
{
    class DurankulakNumbers
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int numberIndex = 0;
            int durankolakDecimalNumber = 0;
            long result = 0;
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                string currentNumber = string.Empty;
                currentNumber += inputString[i];
                if (i-1>=0 && Char.IsLower(inputString[i - 1]))
                {
                    currentNumber += inputString[i - 1];
                    i--;
                    durankolakDecimalNumber = (currentNumber[0] - 'A') + (currentNumber[1] - '`') * 26;
                }
                else
                {
                    durankolakDecimalNumber = currentNumber[0] - 'A';
                }
                result += durankolakDecimalNumber * PowerOfNumber(168, numberIndex);
                numberIndex++;
            }
            Console.WriteLine(result);
        }

        private static long PowerOfNumber(int p, int numberIndex)
        {
            long product = 1;
            for (int i = 0; i < numberIndex; i++)
            {
                product *= p;
            }
            return product;
        }
    }
}
