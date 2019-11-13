using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int produto =  1;

            for (int i = 1; i <= 15; i++)
            {
                if (i % 2 != 0)
                {
                    produto = produto * i;
                }
            }
            Console.WriteLine("Produto dos números impares entre 1 e 15 => {0}", produto);
            Console.ReadKey();
        }
    }
}
