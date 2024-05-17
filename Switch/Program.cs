using System;

namespace Switch;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("a, b, c: ");
        char ch = (char)Console.Read();
        switch (ch) 
        {
            case 'a':
                Console.WriteLine("Esto es una a");
                break;
            case 'b':
                Console.WriteLine("Esto es una b");
                break;
            case 'c':
                Console.WriteLine("Esto es una c");
                break;
            default: 
                Console.WriteLine("Esto no es una a b c");
                break;
        }
    }
}