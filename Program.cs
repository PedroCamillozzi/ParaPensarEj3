using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPensarEj3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p=1, po=0, q, n;
            Console.WriteLine("¿Cuantos numeros quiere calcular para la suma de Fibonnacci?");
            q = Convert.ToInt32(Console.ReadLine());
            for (int i=3; i<q; i++)
            {
                n = (p + po);
                po = p;
                p = n;
                Console.WriteLine(n.ToString());
            }
            Console.ReadKey();
        }
    }
}
