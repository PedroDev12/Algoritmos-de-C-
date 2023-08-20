using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Tiempo time = new Tiempo();
            TimeSpan oTimeSpan = new TimeSpan(1, 1, 1, 1, 1);
            int opc;


            Console.WriteLine("\t  ****TIEMPO****");
            Console.WriteLine("\n\tEl tiempo es: " + time.mostrar());


            Console.WriteLine("\n      MENU   ");
            Console.WriteLine("1-cambie las horas");
            Console.WriteLine("2-cambie los minutos");
            Console.WriteLine("3-cambiar todos los atributos a la vez.");
            Console.WriteLine("4-tiempo en formato estándar ");


            Console.WriteLine("\nDigite una opcion :");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {

                case 1:
                    Console.WriteLine("\nCambiar Hora :");
                    time.sethora(int.Parse(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Cambiar minutos");
                    time.setminutos(int.Parse(Console.ReadLine()));
                    break;
                case 3:
                    Console.WriteLine("Cambiar Horas y Minutos :");
                    time.setHorasyMinutos(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    break;
                case 4:
                    Console.WriteLine("\n" + time.mostrar());
                    break;

            }


            Console.WriteLine("\nEl tiempo es:" + time.mostrar());

            Console.ReadLine();
        }
    }
}
