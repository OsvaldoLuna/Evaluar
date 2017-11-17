using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluar
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos, res = 0;
            
            Console.WriteLine("Cuantos alumnos desea registrar: ");
            alumnos = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Alumnos \n");
            int[] calificaciones = RegistrarCalificaciones(alumnos);
            
            Console.WriteLine("Evaluacion");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write("El Alumno {0} tiene una califiacion de {0} es ", i + 1, calificaciones[i]);
                Evaluar(calificaciones[i]);
                res += calificaciones[i];
            }
            Console.WriteLine("__________________________________");
            
            Console.Write("El Grupo tiene un promedio de: {0}, asi que es: ", (float)res / calificaciones.Length);
            Evaluar(res / calificaciones.Length);
            Console.ReadKey();
        }

        static int[] RegistrarCalificaciones(int numeroCalificaciones)
        {
            int[] cAlum = new int[numeroCalificaciones];
            int nCal = 0;
            do
            {
                Console.WriteLine("Calificacion del alumno No. [{0}]", (nCal + 1));
                cAlum[nCal] = int.Parse(Console.ReadLine());
                nCal++;
            } while (nCal < numeroCalificaciones);
            return cAlum;
        }
        static void Evaluar(int p)
        {
            if (p >= 9)
                Console.Write($"Excelente\n");
            else if (p >= 7)
                Console.Write($"Bueno\n");
            else
                Console.Write($"Malo\n");
        }
    }
}
