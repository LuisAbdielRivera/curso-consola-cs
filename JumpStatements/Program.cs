using System;

namespace JumpStatemts
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    //break;
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}