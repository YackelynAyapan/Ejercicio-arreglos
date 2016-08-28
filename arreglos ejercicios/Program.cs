using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres; // Declaración del array
            ushort num = 0;

            do
            {
                try
                {
                    Console.Write("¿Cuántos nombres vas a introducir? ");
                    num = UInt16.Parse(Console.ReadLine());
                }
                catch
                {
                    continue;
                }
            } while (num == 0);

            nombres = new string[num]; // Instanciación del array

            for (int i = 0; i < num; i++)
            {
                Console.Write("Escribe el nombre para elemento {0}: ", i);
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine("Introducidos los {0} nombres", num);
            Console.WriteLine("el nombre Juan Perez se modificara por Mario Perez");
             nombres[0]="Mario perez";
           

            Console.WriteLine("Pulsa INTRO para listarlos");

            string a = Console.ReadLine();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(" {1}", i, nombres[i]);
            }
            Console.WriteLine("a continuacion se borrara Mario Perez");
            nombres[0] = "<<vacio>>";

            Console.WriteLine("Pulsa INTRO para listarlos");

            string b = Console.ReadLine();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{1}", i, nombres[i]);
            }

            a = Console.ReadLine();



            Console.ReadLine();
             }
    }
    
}



