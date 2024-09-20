using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAviones
{
    internal class Program
    {
       
       
            // Constantes para las secciones de fumar y no fumar
            const int Fumarinicio = 0, Fumarfin = 5;
            const int Nofumar = 5, Nofumarfin = 10;

            // Constantes para los asientos
            const int Asientolibre = 0, AsientoOcupado = 1;

            static void Main(string[] args)
            {
                // Inicialización de los asientos. El arreglo tiene 10 elementos.
                int[] asientos = new int[10]; // 0: libre, 1: ocupado
                bool asientoAsignado;
                int opcion;
                string respuesta, input;

                while (true)
                {
                    // Menú para seleccionar la sección de asientos
                    Console.Clear(); // Limpiar la pantalla para una mejor visibilidad
                    Console.WriteLine("Por favor, elija 1 para 'fumar'");
                    Console.WriteLine("Por favor, elija 2 para 'no fumar'");
                    input = Console.ReadLine();

                    // Verificar que la entrada sea válida
                    if (!int.TryParse(input, out opcion) || (opcion != 1 && opcion != 2))
                    {
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey(); // Pausar para permitir al usuario ver el mensaje
                        continue; // Volver al inicio del bucle para mostrar el menú nuevamente
                    }

                    // Procesar la selección del usuario
                    if (opcion == 1)
                    {
                        // Intentar asignar un asiento en la sección de fumar (0-4)
                        asientoAsignado = AsignarAsiento(asientos, Fumarinicio, Fumarfin, "fumar");
                        if (!asientoAsignado)
                        {
                            // Si la sección de fumar está llena, ofrecer cambiar a la sección de no fumar
                            Console.WriteLine("La sección de fumar está llena.");
                            Console.WriteLine("¿Acepta ser colocado en la sección de no fumar? (sí/no)");
                            respuesta = Console.ReadLine().ToLower();

                            if (respuesta == "sí" || respuesta == "si")
                            {
                                // Intentar asignar en la sección de no fumar (5-9)
                                asientoAsignado = AsignarAsiento(asientos, Nofumar, Nofumarfin, "no fumar");
                                if (!asientoAsignado)
                                {
                                    Console.WriteLine("La sección de no fumar también está llena.");
                                    Console.WriteLine("Next flight leaves in 3 hours.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Next flight leaves in 3 hours.");
                            }
                        }
                    }
                    else if (opcion == 2)
                    {
                        // Intentar asignar un asiento en la sección de no fumar (5-9)
                        asientoAsignado = AsignarAsiento(asientos, Nofumar, Nofumarfin, "no fumar");
                        if (!asientoAsignado)
                        {
                            // Si la sección de no fumar está llena, ofrecer cambiar a la sección de fumar
                            Console.WriteLine("La sección de no fumar está llena.");
                            Console.WriteLine("¿Acepta ser colocado en la sección de fumar? (sí/no)");
                            respuesta = Console.ReadLine().ToLower();

                            if (respuesta == "sí" || respuesta == "si")
                            {
                                // Intentar asignar en la sección de fumar (0-4)
                                asientoAsignado = AsignarAsiento(asientos, Fumarinicio, Fumarfin, "fumar");
                                if (!asientoAsignado)
                                {
                                    Console.WriteLine("La sección de fumar también está llena.");
                                    Console.WriteLine("Next flight leaves in 3 hours.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Next flight leaves in 3 hours.");
                            }
                        }
                    }

                    // Pausar la ejecución para que el usuario pueda ver los resultados
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey(); // Pausar para permitir al usuario ver el mensaje
                }
            }

            // Función para asignar un asiento en una sección específica
            static bool AsignarAsiento(int[] asientos, int inicio, int fin, string tipoSeccion)
            {
                // Iterar a través de los asientos en el rango especificado
                for (int i = inicio; i < fin; i++)
                {
                    if (asientos[i] == Asientolibre) // Verificar si el asiento está libre
                    {
                        asientos[i] = AsientoOcupado; // Marcar el asiento como ocupado
                        Console.WriteLine($"Pase de abordaje: Asiento {i + 1} en la sección de {tipoSeccion}.");
                        return true; // Asiento asignado con éxito
                    }
                }
                return false; // No se encontraron asientos libres en la sección especificada
            }
        }

    }
