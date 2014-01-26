using System;
using System.Text;

class Program
{
    private static long PowerOfNumber(long number, long power)
    {
        long powerOfNum = 1;
        for (int i = 0; i < power; i++)
        {
            powerOfNum *= number;
        }
        return powerOfNum;
    }
    private static long ConvertToDecimal(string[] separate)
    {
        long number = 0;
        long stringToNumber = 0;
        for (int i = 0; i < separate.Length; i++)
        {

            stringToNumber = StringToNumber(separate, stringToNumber, i);
            number += stringToNumber * PowerOfNumber(15, i);
        }
        return number;
    }


    private static void FillArray(string inputString, string[] separate)
    {
        int index = 0;
        for (int i = inputString.Length - 1; i >= 0; i -= 4)
        {
            StringBuilder separateNumbers = new StringBuilder(4);
            for (int k = i - 3; k <= i; k++)
            {
                separateNumbers.Append(inputString[k]);
            }
            separate[index] = separateNumbers.ToString();
            index++;
        }
    }
    private static long StringToNumber(string[] separate, long stringToNumber, int i)
    {
        switch (separate[i])
        {
            case "Rawr":
                stringToNumber = 0;
                break;
            case "Rrrr":
                stringToNumber = 1;
                break;
            case "Hsst":
                stringToNumber = 2;
                break;
            case "Ssst":
                stringToNumber = 3;
                break;
            case "Grrr":
                stringToNumber = 4;
                break;
            case "Rarr":
                stringToNumber = 5;
                break;
            case "Mrrr":
                stringToNumber = 6;
                break;
            case "Psst":
                stringToNumber = 7;
                break;
            case "Uaah":
                stringToNumber = 8;
                break;
            case "Uaha":
                stringToNumber = 9;
                break;
            case "Zzzz":
                stringToNumber = 10;
                break;
            case "Bauu":
                stringToNumber = 11;
                break;
            case "Djav":
                stringToNumber = 12;
                break;
            case "Myau":
                stringToNumber = 13;
                break;
            case "Gruh":
                stringToNumber = 14;
                break;
        }
        return stringToNumber;
    }
    static void Main()
    {
        string inputString = Console.ReadLine();
        string[] separate = new string[(inputString.Length / 4)];
        FillArray(inputString, separate);
        long result = ConvertToDecimal(separate);
        Console.WriteLine(result);

    }
}
