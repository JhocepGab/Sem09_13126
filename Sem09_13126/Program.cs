using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem09_13126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            while (true)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 0)
                {
                    break;
                }
            }
        }
    }
}
