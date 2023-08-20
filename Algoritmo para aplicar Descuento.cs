using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el sueldo bruto (SB) de un empleado :$");
            double sueldoBruto = double.Parse(Console.ReadLine());

            double descuento = sueldoBruto * 0.07;
            double sueldoNeto = sueldoBruto - descuento;

            Console.WriteLine("\n\n\tEl descuento fue de :$" + descuento);
            Console.WriteLine("\tEl sueldo Neto es de :$" + sueldoNeto);

            Console.ReadLine();

        }
    }
}
