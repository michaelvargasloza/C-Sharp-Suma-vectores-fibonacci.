using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            double[] fibo;

            int cont;
            int tot;

            a = 0;
            b = 1;
            cont = 0;
            Console.Write("Ingrese el tamaño de la serie: ");
            tot = Convert.ToInt32(Console.ReadLine());

            fibo = new double[tot]; 

            while (cont < tot) {
                //c = a + b;
                fibo[cont] = a;
                c = a + b;
                a = b;
                b = c;
                cont = cont + 1;
            }

            Console.Write("\nSerie fibonacci (" + tot + " elementos): \n");
            Console.WriteLine("[{0}]", string.Join(", ", fibo));
            Console.ReadLine();
        }
    }
}
