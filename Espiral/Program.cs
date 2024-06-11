using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espiral
{
    internal class Program
    {
        static void Spiral()
        {
            string signo1 = "═";
            string signo2 = "║";
            string signo3 = "╗";
            string signo4 = "╔";
            string signo5 = "╝";
            string signo6 = "╚";

            string[,] Simbolos = new string[5, 5];

            Simbolos[0, 0] = signo1;
            Simbolos[0, 1] = signo1;
            Simbolos[0, 2] = signo1;
            Simbolos[0, 3] = signo1;
            Simbolos[0, 4] = signo3;
            Simbolos[1, 0] = signo4;
            Simbolos[1, 1] = signo1;
            Simbolos[1, 2] = signo1;
            Simbolos[1, 3] = signo3;
            Simbolos[1, 4] = signo2;
            Simbolos[2, 0] = signo2;
            Simbolos[2, 1] = signo6;
            Simbolos[2, 2] = signo1;
            Simbolos[2, 3] = signo5;
            Simbolos[2, 4] = signo2;
            Simbolos[3, 0] = signo6;
            Simbolos[3, 1] = signo1;
            Simbolos[3, 2] = signo1;
            Simbolos[3, 3] = signo1;
            Simbolos[3, 4] = signo5;


            for (int i = 0; i < Simbolos.GetLength(0); i++)
            {
                for (int j = 0; j < Simbolos.GetLength(1); j++)
                {
                   Console.Write(Simbolos[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static void Matrix()
        {
            int[,] Matrix = new int[2, 2];

            Matrix[0, 0] = 1;
            Matrix[0, 1] = 2;
            Matrix[1, 0] = 3;
            Matrix[1, 1] = 3;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Intento de Espiral");
            //Spiral();
            //Matrix();
            Console.WriteLine("Ingrega los numeros que quieras");

            List<int> Numeros = new List<int>();
            
            Console.ReadKey();
        }

        static void Numeros(List<int> numeros)
        {
            List<int> Numeros = new List<int>();

            Numeros.Add(numeros.Count);

        }





    }


}

