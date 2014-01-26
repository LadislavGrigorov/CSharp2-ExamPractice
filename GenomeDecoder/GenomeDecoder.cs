using System;
class GenomeDecoder
{
    static void Main()
    {
        string nm = Console.ReadLine();
        string encodedGenome = Console.ReadLine();
        string[] nmString = nm.Split(' ');
        int n = int.Parse(nmString[0]);
        int m = int.Parse(nmString[1]);
        string[] valuesString = encodedGenome.Split(new char[] { 'A', 'G', 'C', 'T', '\n'});
        string[] genomes = encodedGenome.Split(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' });
        for (int i = 0; i < valuesString.Length; i++)
        {
            Console.WriteLine(valuesString[i]);
        }
    }
}
