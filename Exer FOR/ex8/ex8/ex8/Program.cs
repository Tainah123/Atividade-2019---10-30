using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double num, soma = 0, media;

            for (i = 1; i <= 10; i++)
            {
                Console.Write("Informe o {0}º número: ", i);
                num = double.Parse(Console.ReadLine());

                soma += num; //soma = soma + num
            }
            media = soma / 10;
            Console.WriteLine("Soma dos Números => {0:N}", soma);
            Console.WriteLine("Média da soma dos números => {0:N}", media);
            Console.ReadKey();
        }
    }
}
