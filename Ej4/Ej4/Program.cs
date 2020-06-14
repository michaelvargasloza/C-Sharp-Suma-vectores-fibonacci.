using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vector;
            double[] vector2;
            double[] vector3;
            double[] vectorResultado;

            int cont1;
            int cont2;
            int cont3;
            int cont4;
            int tot;
            cont1 = 0;
            cont2 = 0;
            cont3 = 0;
            cont4 = 0;

            Console.Write("Ingrese el tamaño de los vectores: ");
            tot = Convert.ToInt32(Console.ReadLine());

            vector = new double[tot];
            vector2 = new double[tot];
            vector3 = new double[tot];
            vectorResultado = new double[tot];      

            while (cont1 < tot)
            {
                Console.Write("Ingrese el valor " + (cont1 + 1) + " del vector 1: ");
                string valor;
                valor = Console.ReadLine();
                vector[cont1] = Convert.ToInt32(valor);

                cont1 = cont1 + 1;
            }

            while (cont2 < tot)
            {
                Console.Write("Ingrese el valor " + (cont2 + 1) + " del vector 2: ");
                string valor;
                valor = Console.ReadLine();
                vector2[cont2] = Convert.ToInt32(valor);

                cont2 = cont2 + 1;
            }

            while (cont3 < tot)
            {
                Console.Write("Ingrese el valor " + (cont3 + 1) + " del vector 3: ");
                string valor;
                valor = Console.ReadLine();
                vector3[cont3] = Convert.ToInt32(valor);

                cont3 = cont3 + 1;
            }

            while (cont4 < tot)
            {
                vectorResultado[cont4] = vector[cont4] + vector2[cont4] + vector3[cont4];
                cont4 = cont4 + 1;
            }

            //Array.ForEach(vector, Console.WriteLine);
            Console.Write("\nVector 1: \n");
            Console.WriteLine("[{0}]", string.Join(", ", vector));
            Console.Write("\nVector 2: \n");
            Console.WriteLine("[{0}]", string.Join(", ", vector2));
            Console.Write("\nVector 3: \n");
            Console.WriteLine("[{0}]", string.Join(", ", vector3));
            Console.Write("\nSuma de vectores: \n");
            Console.WriteLine("[{0}]", string.Join(", ", vectorResultado));
            Console.ReadLine();
        }
    }
}
