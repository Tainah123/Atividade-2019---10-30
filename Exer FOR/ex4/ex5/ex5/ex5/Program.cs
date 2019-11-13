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
            int  i = 85, soma = 0;

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                soma += i;
            }
            Console.WriteLine("Soma dos numeros pares entre 85 e 907 => {0}", soma);
            Console.ReadKey()
        }

    }
}
