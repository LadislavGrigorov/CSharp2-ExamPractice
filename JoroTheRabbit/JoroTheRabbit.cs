using System;

class JoroTheRabbit
{
    static void TerrainJump(int[] terrain)
    {
        int step = 1;
        int lengthOfSteps = 1;
        int maxLengthOfSteps = 0;     
        while (step <= terrain.Length - 1)
        {
            for (int startIndex = 0; startIndex < terrain.Length; startIndex++)
            {
                bool[] isVisited = new bool[terrain.Length];
                int currentIndex = startIndex;
                while (true)
                {
                    isVisited[currentIndex] = true;
                    int nextIndex = (currentIndex + step) % terrain.Length;
                    if (terrain[currentIndex] < terrain[nextIndex] && isVisited[nextIndex] == false)
                    {
                        lengthOfSteps++;
                        currentIndex = nextIndex;
                    }
                    else
                    {
                        break;
                    }
                }
                if (lengthOfSteps > maxLengthOfSteps)
                {
                    maxLengthOfSteps = lengthOfSteps;
                    lengthOfSteps = 1;
                }
                else
                {
                    lengthOfSteps = 1;
                }
                if (maxLengthOfSteps == terrain.Length)
                {
                    break;
                }
            }
            if (maxLengthOfSteps == terrain.Length)
            {
                break;
            }
            step++;
        }
        Console.WriteLine(maxLengthOfSteps);
       
    }
    static void Main()
    {
        string[] terrainString = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] terrainNumbers = new int[terrainString.Length];
        for (int i = 0; i < terrainString.Length; i++)
        {
            terrainNumbers[i] = int.Parse(terrainString[i]);
        }
        TerrainJump(terrainNumbers);
    }
}
