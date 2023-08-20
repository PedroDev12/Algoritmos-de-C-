using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\tPROGRAMA QUE CALCULA EL COCIENTE Y EL RESIDUO DE 2 NUMERO");

            Console.WriteLine("\nIngrese un numero :");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero :");
            int numero2 = int.Parse(Console.ReadLine());

            int cociente = numero1 / numero2;
            int residuo = numero1 % numero2;

            Console.WriteLine("\n\n\tEl Cociente es :" + cociente);
            Console.WriteLine("\tEl Residuo es :" + residuo);

            Console.ReadLine();

        }
    }
}
