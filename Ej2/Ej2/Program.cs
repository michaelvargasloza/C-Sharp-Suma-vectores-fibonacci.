using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vector;
            double[] vector2;
            double[] vector3;
            vector = new double[10];
            vector2 = new double[10];
            vector3 = new double[10];
            int cont;
            int tot;
            cont = 0;
            tot = 10;

            while (cont < tot)
            {
                Console.Write("Ingrese el valor " + (cont + 1) + ": ");
                string valor;
                valor = Console.ReadLine();
                vector[cont] = Convert.ToInt32(valor);
                vector2[cont] = Math.Pow(Convert.ToInt32(valor), 2);
                vector3[cont] = Math.Sqrt(Convert.ToInt32(valor));

                cont = cont + 1;
            }

            //Array.ForEach(vector, Console.WriteLine);
            Console.Write("\nVector resultado: \n");
            Console.WriteLine("[{0}]", string.Join(", ", vector));
            Console.Write("\nVector al cuadrado: \n");
            Console.WriteLine("[{0}]", string.Join(", ", vector2));
            Console.Write("\nRaíz del vector: \n");
            Console.WriteLine("[{0}]", string.Join(", ", vector3));
            Console.ReadLine();
        }
    }
}
