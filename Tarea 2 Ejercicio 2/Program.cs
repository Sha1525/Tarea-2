using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreEstudiante;
            int numeroCarnet;
            int quiz1;
            int quiz2;
            int quiz3;
            int tarea1;
            int tarea2;
            int tarea3;
            int examen1;
            int examen2;
            int examen3;

            Console.WriteLine("Promedio Final:");

            Console.WriteLine("Nombre del Estudiante:");
            nombreEstudiante = Console.ReadLine();

            Console.WriteLine("Digite el Número de Carnet:");
            numeroCarnet = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota de Quiz 1");
            quiz1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota de Quiz 2");
            quiz2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota de Quiz 3");
            quiz3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota de Tarea 1");
            tarea1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota de Tarea 2");
            tarea2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota de Tarea 3");
            tarea3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota de Examen 1");
            examen1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota de Examen 2");
            examen2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota de Examen 3");
            examen3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre: " + nombreEstudiante);
            Console.WriteLine("Numero de Carnet:  " + numeroCarnet);
            Console.WriteLine("Nota de Quiz 1:  " + quiz1);
            Console.WriteLine("Nota de Quiz 2:  " + quiz2);
            Console.WriteLine("Nota de Quiz 3:  " + quiz3);
            Console.WriteLine("Nota de Tarea 1:  " + tarea1);
            Console.WriteLine("Nota de Tarea 2:  " + tarea2);
            Console.WriteLine("Nota de Tarea 3:  " + tarea3);
            Console.WriteLine("Nota de Examen 1:  " + examen1);
            Console.WriteLine("Nota de Examen 2:  " + examen2);
            Console.WriteLine("Nota de Examen 3:  " + examen3);

            Console.WriteLine("Porcentajes Obtenidos");
            double totalDeQuices;
            double totalDeTareas;
            double totalDeExamenes;


            totalDeQuices = (quiz1 + quiz2 + quiz3) / 3 * 0.25;
            Console.WriteLine("Suma de Quiz; " + totalDeQuices);


            totalDeTareas = (tarea1 + tarea2 + tarea3) / 3 * 0.45;
            Console.WriteLine("Suma de Tareas: " + totalDeTareas);

            totalDeExamenes = (examen1 + examen2 + examen3) / 3 * 0.30;
            Console.WriteLine("Suma de Examenes: " + totalDeExamenes);

            double PromedioTotal;
            PromedioTotal = (totalDeQuices + totalDeTareas + totalDeExamenes);

            if
                (PromedioTotal >= 70)
                Console.WriteLine("El promedio del estudiante es  " + PromedioTotal + " Aprobado");
            else
                Console.WriteLine("El promedio del estudiante es  " + PromedioTotal + "Reprobado");


            Console.ReadLine();
        }
    }
}
