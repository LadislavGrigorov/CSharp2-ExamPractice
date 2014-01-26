using System;

class GreedyDwarf
{
    private static long PatternSum(int[] valleyNumbers, int[] patternNumbers)
    {
        long currentSum = 0;
        bool[] visitedValley = new bool[valleyNumbers.Length];
        currentSum += valleyNumbers[0];
        int nextPosition = 0;
        visitedValley[0] = true;
        int patternCounter = 0;
        while (true)
        {
            if (patternCounter>patternNumbers.Length-1)
            {
                patternCounter = 0;
            }
            nextPosition = nextPosition + patternNumbers[patternCounter];
            if (nextPosition < valleyNumbers.Length && nextPosition >= 0 && visitedValley[nextPosition] == false)
            {
                currentSum += valleyNumbers[nextPosition];
                visitedValley[nextPosition] = true;
                patternCounter++;
            }
            else
            {
                return currentSum;
            }
        }
    }
    static void Main()
    {
        string[] valleyNumbersString = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int numberOfPatterns = int.Parse(Console.ReadLine());
        int[] valleyNumbers = new int[valleyNumbersString.Length];
        long bestSum = long.MinValue;
        long currentSum = 0;
        for (int i = 0; i < valleyNumbersString.Length; i++)
        {
            valleyNumbers[i] = int.Parse(valleyNumbersString[i]);
        }
        for (int i = 0; i < numberOfPatterns; i++)
        {
            string[] patternString = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] patternNumbers = new int[patternString.Length];
            for (int k = 0; k < patternString.Length; k++)
            {
                patternNumbers[k] = int.Parse(patternString[k]);
            }
            currentSum = PatternSum(valleyNumbers, patternNumbers);
            BestSum(currentSum, ref bestSum);
        }
        Console.WriteLine(bestSum);
    }

    private static void BestSum(long currentSum, ref long bestSum)
    {
        if (currentSum>bestSum)
        {
            bestSum = currentSum;
        }
    }

}
