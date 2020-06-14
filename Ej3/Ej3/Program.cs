using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vector;
            int cont;
            int tot;
            cont = 0;

            Console.Write("Ingrese la cantidad de nombres: ");
            tot = Convert.ToInt32(Console.ReadLine());

            vector = new string[tot];

            while (cont < tot)
            {
                Console.Write("Ingrese el nombre " + (cont + 1) + ": ");
                string valor;
                valor = Console.ReadLine();
                vector[cont] = valor;

                cont = cont + 1;
            }

            Console.Write("\nNombre(s) ingresado(s): \n");
            Array.ForEach(vector, Console.WriteLine);
            Console.ReadLine();
        }
    }
}
