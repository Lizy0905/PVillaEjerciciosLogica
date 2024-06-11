using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DibujarEspiral
{
    internal class Program
    {
        static void DibujarEspiral(int lado)
        {
            //declaracion de matrix

            //fila|columna
            char[,] Matrix = new char[lado, lado];

            int filaInicio = 0;
            int filaFin = lado - 1;
            int columnaInicio = 0;
            int columnaFin = lado - 1;


            while (filaInicio <= filaFin && columnaInicio <= columnaFin)
            {
                for (int i = columnaInicio; i <= columnaFin; i++)
                    Matrix[filaInicio, i] = (i == columnaFin) ? '╗' : '═';

                for (int i = filaInicio + 1; i <= filaFin; i++)
                    Matrix[i, columnaFin] = (i == filaFin) ? '╝' : '║';

                for (int i = columnaFin - 1; i >= columnaInicio; i--)
                    Matrix[filaFin, i] = (i == columnaInicio) ? '╚' : '═';

                for (int i = filaFin -1; i > filaInicio; i--)
                    Matrix[i, columnaInicio] = (i == filaInicio + 1 ) ? '╔' : '║';


                filaInicio++;
                filaFin--;
                columnaInicio++;
                columnaFin--;

            }

            for (int i = 0; i < lado; i++)
            {
                for (int j = 0; j < lado; j++)
                {
                    if (Matrix[i, j] == '\0')
                        Matrix[i, j] = ' ';
                    Console.Write(Matrix[i, j]);
                }
                Console.WriteLine();
            }
            //while (lado <= 15)
            //{
            //    Console.WriteLine("Ciclo while: " + lado);
            //    lado = lado + 1;
            //}

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Inserte un numero");
            int numero = int.Parse(Console.ReadLine());
            DibujarEspiral(numero);
            Console.ReadKey();
        }
    }
}
