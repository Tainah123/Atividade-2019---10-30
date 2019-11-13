using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i , num;

            Console.Write("Informe um número: ");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(" {0} * {1} = {2}", num, i, (num * i));
                
            }
            Console.ReadKey();
        }
    }
}
