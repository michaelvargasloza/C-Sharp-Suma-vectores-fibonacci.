using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vector;
            vector = new string[5];
            int cont;
            int tot;
            int suma;
            cont = 0;
            tot = 5;
            suma = 0;

            while (cont < tot) {
                Console.Write("Ingrese el valor " + (cont + 1) + ": ");
                string valor;
                valor = Console.ReadLine();
                vector[cont] = valor;

                suma = suma + Convert.ToInt32(valor);

                cont = cont + 1;
            }

            Console.Write("La suma de los valores es: " + suma);
            Console.ReadLine();
        }
    }
}
