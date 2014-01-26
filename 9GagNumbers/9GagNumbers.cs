using System;
using System.Collections.Generic;
//Use the serach engine in BGCoder.com to find the task.
class Program
{
    static void Main()
    {
        string stringInput = Console.ReadLine();
        List<int> numbers = new List<int>();
        ExtractNumber(stringInput, numbers);
        ConvertToDecimal(numbers);
    }

    private static void ConvertToDecimal(List<int> numbers)
    {
        ulong sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += (ulong)numbers[i] * PowerOfNumber(9, i);
        }
        Console.WriteLine(sum);
    }

    private static ulong PowerOfNumber(ulong p, int power)
    {
        ulong product = 1;
        for (int i = 0; i < power; i++)
        {
            product *= p;
        }
        return product;
    }

    private static void ExtractNumber(string stringInput, List<int> numbers)
    {
        int startIndex = 0;
        int length = 2;
        while (startIndex <= stringInput.Length - 1)
        {
            string extract = stringInput.Substring(startIndex, length);
            switch (extract)
            {
                case "-!":
                    numbers.Add(0);
                    startIndex += length;
                    length = 2;
                    break;
                case "**":
                    numbers.Add(1);
                    startIndex += length;
                    length = 2;
                    break;
                case "!!!":
                    numbers.Add(2);
                    startIndex += length;
                    length = 2;
                    break;
                case "&&":
                    numbers.Add(3);
                    startIndex += length;
                    length = 2;
                    break;
                case "&-":
                    numbers.Add(4);
                    startIndex += length;
                    length = 2;
                    break;
                case "!-":
                    numbers.Add(5);
                    startIndex += length;
                    length = 2;
                    break;
                case "*!!!":
                    numbers.Add(6);
                    startIndex += length;
                    length = 2;
                    break;
                case "&*!":
                    numbers.Add(7);
                    startIndex += length;
                    length = 2;
                    break;
                case "!!**!-":
                    numbers.Add(8);
                    startIndex += length;
                    length = 2;
                    break;
                default:
                    length++;
                    break;
            }
        }
        numbers.Reverse();
    }
}
