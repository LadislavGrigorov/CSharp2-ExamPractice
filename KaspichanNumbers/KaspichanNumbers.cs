using System;
using System.Collections.Generic;
using System.Text;

class KaspichanNumbers
{
    static string ConvertToKaspichan(ulong number)
    {
        ulong remainder = 0;
        StringBuilder kaspichanNum = new StringBuilder(2);
        remainder = number % (ulong)26;
        number /= 26;
        if (number > 0)
        {
            kaspichanNum.Append((char)('`' + number));
            kaspichanNum.Append((char)('A' + remainder));
            return kaspichanNum.ToString();
        }
        else
        {
            kaspichanNum.Append((char)('A' + remainder));
            return kaspichanNum.ToString();
        }
    }
    static void ConvertTo256(ulong number)
    {
        List<string> stringList = new List<string>();
        StringBuilder kaspichanNum = new StringBuilder();
        if (number == 0)
        {
            Console.WriteLine("A");
        }
        else
        {
            while (number >= 0)
            {
                ulong remainder = number % 256;
                number /= 256;
                stringList.Add(ConvertToKaspichan(remainder));
            }
            for (int i = stringList.Count - 1; i >= 0; i--)
            {
                kaspichanNum.Append(stringList[i]);
            }
            Console.WriteLine(kaspichanNum.ToString());
        }

    }
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        ConvertTo256(number);
    }
}
