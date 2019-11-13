using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe6
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1, produto = 1;

            for (i = 1; i <= 15; i++)
            {
                produto *= i;
                Console.WriteLine("Produtos dos numeros impares e entre 1 e 15 => {0}", produto);
            }

            Console.ReadKey();
        }
        
    }
}
