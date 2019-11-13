using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int  i, soma = 0;

            for(i = 85; i <= 907; i++)
            {
                Console.WriteLine(i);
                soma += i;
                if (i % 2 == 0);
            }
            Console.WriteLine("Soma dos numeros pares entre 85 e 907 => {0}", soma);
            Console.ReadKey();
        }

    }
}
