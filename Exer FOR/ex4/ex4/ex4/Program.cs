using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sp = 0, si = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("informe o {0} numero: ", i);
                num = int.Parse(Console.ReadLine());


                if (num % 2 == 0)
                {
                    sp += num;


                }
                else
                {
                    si += num;

                }

               
            }
            Console.WriteLine("Soma dos numeros pares => {0}" , sp);
                Console.WriteLine("Soma dos numeros impares => {0}" , si);
                Console.ReadKey();
        }

    }
}