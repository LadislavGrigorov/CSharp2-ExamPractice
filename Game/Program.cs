using System;
using System.Text;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        int fullBlock = 0x2588;
        int square = 0x25a0;
        int leftSemiBlock = 0x258c;
        int rightSemiBlock = 0x2590;
        int bullet = 0x25cf;
        string tankFaceRight = ((char)fullBlock).ToString() + ((char)fullBlock).ToString() + ((char)square).ToString() + ((char)square).ToString();
        string tankFaceLeft = ((char)square).ToString() + ((char)square).ToString() + ((char)fullBlock).ToString() + ((char)fullBlock).ToString();
        string tankFaceUp = " " + ((char)fullBlock).ToString() + " \n" + ((char)rightSemiBlock).ToString() + ((char)fullBlock).ToString() + ((char)leftSemiBlock).ToString();
        string tankFaceDown = ((char)rightSemiBlock).ToString() + ((char)fullBlock).ToString() + ((char)leftSemiBlock).ToString() + "\n " + ((char)fullBlock).ToString() + " ";
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(tankFaceRight);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(tankFaceLeft);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(tankFaceUp);
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(tankFaceDown);
    }
}