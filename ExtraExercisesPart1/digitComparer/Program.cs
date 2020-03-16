using System;

namespace digitComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i < 20 && i - 11 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (i >= 20 && i < 30 && (i - 20) < 2)
                {
                    Console.WriteLine(i);
                }
                else if (i >= 30 && i < 40 && (i - 30) < 3)
                {
                    Console.WriteLine(i);
                }
                else if (i >= 40 && i < 50 && (i - 40) < 4)
                {
                    Console.WriteLine(i);
                }
                else if (i >= 50 && i < 60 && (i - 50) < 5)
                {
                    Console.WriteLine(i);
                }
                else if (i >= 60 && i < 70 && (i - 60) < 6)
                {
                    Console.WriteLine(i);
                }
                else if (i >= 70 && i < 80 && (i - 70) < 7)
                {
                    Console.WriteLine(i);
                }
                else if (i >= 80 && i < 90 && (i - 80) < 8)
                {
                    Console.WriteLine(i);
                }
                else if (i >= 90 && i < 100 && (i - 90) < 9)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
