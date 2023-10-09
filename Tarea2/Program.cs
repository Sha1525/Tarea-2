using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//hacer un algoritmo de una tienda que vende camisas, si la persona se lleva una camisa se lo lleva a precio de costo, 

//si la persona se lleva entre 2 y 5 camisas se le hace un descuento del 15%

//si la persona se lleva más de 5 el descuento es de 20%

//El sistema debe solicitar la cantidad de camisas y el precio de las camisas

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float precio = 0f;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("Digite el precio de la camisa");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"Total a pagar: {cantidad*precio }");
            }

            if (cantidad > 1 && cantidad <6)
            {
                total = precio*0.15f;
                total = precio - total;
                Console.WriteLine($"Total a pagar: {total} con descuento de 15$");
            }
            if (cantidad >= 6)
            {
                total = (cantidad*precio) * 0.15f;
                total = (cantidad * precio) - total;
                Console.WriteLine($"Total a pagar: {total} con descuento de 20%");

                Console.ReadLine();
            }
        }
    }
}
