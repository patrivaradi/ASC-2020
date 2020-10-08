using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moore_s_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            float x = Convert.ToInt32((Math.Log(n, 2)));
            double y = x * 1.5;            
            Console.WriteLine("Dupa {0} ani va fi puterea de calcul de {1} ori mai mare.", y, n);
            Console.ReadKey();
        }
    }
}
