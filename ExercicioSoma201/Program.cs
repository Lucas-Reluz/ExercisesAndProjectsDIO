using System;

namespace TestesC_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb2 = 0;

            for (int n1 = 200; n1 > numb2; n1--)
            {
                numb2++;
                int numero = n1 + numb2;
                Console.WriteLine($"{n1} + {numb2} = {numero}");
            }
        }
    }
}
