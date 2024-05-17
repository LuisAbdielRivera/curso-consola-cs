using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Character");
            char ch = (char)Console.Read();

            if(Char.IsUpper(ch))
            {
                Console.WriteLine("Es Mayuscula");
            }
            else if(Char.IsLower(ch))
            {
                Console.WriteLine("Es Minuscula");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("Es Numero");
            }
            else
            {
                Console.WriteLine("No es Alfanumerico");
            }
        }
    }
}