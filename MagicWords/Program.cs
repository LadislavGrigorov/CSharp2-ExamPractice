using System;
using System.Collections.Generic;
using System.Text;
class MagicWords
{
    private static void Reorder(string[] arrayWords)
    {
        List<string> wordList = new List<string>();
        for (int i = 0; i < arrayWords.Length; i++)
        {
            wordList.Add(arrayWords[i]);
        }
        int position = 0;
        for (int i = 0; i < wordList.Count; i++)
        {
            position = wordList[i].Length % (wordList.Count + 1);
            string temp = wordList[i];
            wordList[i] = null;
            wordList.Insert(position, temp);
            wordList.Remove(null);

        }
        wordList.TrimExcess();
        int maxLenght = 0;
        for (int i = 0; i < wordList.Count; i++)
        {
            if (wordList[i].Length > maxLenght)
            {
                maxLenght = wordList[i].Length;
            }
        }
        StringBuilder printEm = new StringBuilder();
        for (int i = 0; i < maxLenght; i++)
        {
            for (int k = 0; k < wordList.Count; k++)
            {
                if (i <= wordList[k].Length - 1)
                {
                    printEm.Append(wordList[k][i]);
                }
            }
        }
        Console.WriteLine(printEm.ToString());
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] arrayWords = new string[n];
        for (int i = 0; i < n; i++)
        {
            arrayWords[i] = Console.ReadLine();
        }
        Reorder(arrayWords);
    }
}
