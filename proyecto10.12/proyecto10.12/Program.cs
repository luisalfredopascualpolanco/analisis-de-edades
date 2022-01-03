using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int posicion;
                float promedioManana = 0;
                float promedioTarde = 0;
                float promedioNoche = 0;

                for (int i = 0; i < 50; i++)
                {
                    posicion = i + 1;
                    Console.Write("Dame la edad del estudiante de la mañana #" + posicion + ": ");
                    promedioManana = promedioManana + float.Parse(Console.ReadLine());
                }
                promedioManana = promedioManana / 50;

                for (int i = 0; i < 60; i++)
                {
                    posicion = i + 1;
                    Console.Write("Dame la edad del estudiante de la tarde #" + posicion + ": ");
                    promedioTarde = promedioTarde + float.Parse(Console.ReadLine());
                }
                promedioTarde = promedioTarde / 60;

                for (int i = 0; i < 110; i++)
                {
                    posicion = i + 1;
                    Console.Write("Dame la edad del estudiante de la noche #" + posicion + ": ");
                    promedioNoche = promedioNoche + float.Parse(Console.ReadLine());
                }
                promedioNoche = promedioNoche / 110;

                Console.WriteLine("La edad promedio de los estudiantes de la mañana es "+promedioManana+" años, de la tarde "+promedioTarde+" años " +
                    "y "+promedioNoche+" de la noche.");

                if (promedioManana < promedioTarde && promedioManana < promedioNoche)
                {
                    Console.WriteLine("El promedio de edades menor es el turno de la mañana.");
                }
                else if(promedioNoche < promedioManana && promedioNoche < promedioTarde)
                {
                    Console.WriteLine("El promedio de edades menor es el turno de la noche.");
                }
                else
                {
                    Console.WriteLine("El promedio de edades menor es el turno de la tarde.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido en dato invalido.");               
            }
            Console.ReadKey();
        }
    }
}
