using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, qp = 0, qi = 0;

            for(int i = 1; i <= 10; i++)
            {
                Console.Write("informe o número: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    qp++;

                }
                else
                {
                    qi++;

                }
                Console.WriteLine("Quantidade de par:" + qp);
                Console.WriteLine("Quantidade de impar:" + qi);
                Console.ReadKey();
            }
        }
    }
}
