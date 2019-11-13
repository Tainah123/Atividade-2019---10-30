using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i<=100; i++)
            {
                Console.WriteLine(i);
                soma = soma + i;


            }
            Console.WriteLine("O resultado é:" + soma);
            Console.ReadKey();
        }
    }
}
