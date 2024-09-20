using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Areglo2._2
{
    internal class Program
    {
        static void Main(string[] args)
        //suma de fila 2
        {
            // Crear una tabla 3x3
            int[,] tabla1 = new int[3, 3];
            int f, c; // f = filas y c = columnas

            // Sumas para las filas
            int sumafila1 = 0;
            int sumafila2 = 0;
            int sumafila3 = 0;

            // Sumas para las columnas
            int columna1 = 0;
            int columna2 = 0;
            int columna3 = 0;

            Console.WriteLine("Ejemplo de arreglo bidimensional");
            Console.WriteLine("Digite los datos del arreglo (3x3):");

            // Lectura de la tabla con valores usando un bucle for
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                 tabla1= int.Parse(Console.ReadLine());
                }
            }

            // Imprimir el arreglo
            Console.WriteLine("Imprimiendo el arreglo:");
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    Console.Write(tabla1[f, c] + " ");
                }
                Console.WriteLine();
            }

            // Suma de las filas
            for (c = 0; c < 3; c++)
            {
                sumafila1 += tabla1[0, c];
                sumafila2 += tabla1[1, c];
                sumafila3 += tabla1[2, c];
            }

            // Suma de las columnas
            for (f = 0; f < 3; f++)
            {
                columna1 += tabla1[f, 0];
                columna2 += tabla1[f, 1];
                columna3 += tabla1[f, 2];
            }

            // Mostrar las sumas de las filas
            Console.WriteLine("Suma de la fila 1: " + sumafila1);
            Console.WriteLine("Suma de la fila 2: " + sumafila2);
            Console.WriteLine("Suma de la fila 3: " + sumafila3);

            // Mostrar las sumas de las columnas
            Console.WriteLine("Suma de la columna 1: " + columna1);
            Console.WriteLine("Suma de la columna 2: " + columna2);
            Console.WriteLine("Suma de la columna 3: " + columna3);

            Console.ReadKey();
        }
    }
}