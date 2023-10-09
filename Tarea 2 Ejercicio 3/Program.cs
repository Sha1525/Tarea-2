using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Un vendedor ofrece su producto de la siguiente manera:
//Si le compran 10 productos o menos, el precio por producto es de $20.
//Si le compran más de 10 artículos, el precio es de $15 por artículo.
//Realice un algoritmo y diagrama de flujo que con solo proporcionarle
//la cantidad de artículos dé como resultado el precio y el total.
namespace Tarea_2_Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int cantidadProducto;
            double total;

            Console.WriteLine("Digite la cantidad");
            cantidadProducto = int.Parse(Console.ReadLine());

            

            if (cantidadProducto >= 10)
            {
                total = (cantidadProducto * 15);
                Console.WriteLine("Total a pagar por producto es de $15 por producto");
            }
            else 
            {
                total = (cantidadProducto * 20);
                Console.WriteLine("Total a pagar por producto es $20 por producto");

                double totalPorPagar;
                totalPorPagar = (cantidadProducto + total);
                Console.WriteLine("Debe un total de  " +totalPorPagar+ "$");

                Console.ReadLine();
            }
    }
}
}
