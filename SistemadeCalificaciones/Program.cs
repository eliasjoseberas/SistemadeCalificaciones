using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeCalificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomEstudiante;
            byte nota;
            string clasificacion = string.Empty;
            string estado = string.Empty;

            Console.WriteLine("Escriba su nombre");
            nomEstudiante = Console.ReadLine();

            Console.WriteLine("Ingrese su calificación");

            while (!byte.TryParse(Console.ReadLine(), out nota))
            {
                Console.WriteLine("Ingrese un valor valido");
            }

            if (nota > 100)
            {
                Console.WriteLine("Nota invalida");
            }
            else
            {
                if (nota >= 90 && nota <= 100)
                {
                    clasificacion = "Excelente";
                }
                if (nota >= 80 && nota <= 90)
                {
                    clasificacion = "Muy bueno";
                }
                if (nota >= 70 && nota <= 80)
                {
                    clasificacion = "Aprobado";
                }
                else
                {
                    clasificacion = "Muy mal";
                }
            }

            if (nota >= 0 && nota < 70)
            {
                estado = "Reprobado";
            }
            if (nota > 70)
            {
                estado = "Aprobado";
            }
            Console.WriteLine("==========================================");
            Console.WriteLine ("Resultados:");
            Console.WriteLine("==========================================");
            Console.WriteLine($"Nombre del estudiante {nomEstudiante}");
            Console.WriteLine($"Calificación: {nota}");
            Console.WriteLine($"Clasificación: {clasificacion}");
            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine("==========================================");
        }

    }
}
