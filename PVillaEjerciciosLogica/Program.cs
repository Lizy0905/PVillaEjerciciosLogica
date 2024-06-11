using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVillaEjerciciosLogica
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserta un numero para crear una escalera");
            int numero;
            numero = int.Parse(Console.ReadLine());

            Escalera(numero);
            Console.ReadKey();
        }
 
        static  void Escalera(int numero)
        {
            string escalon1 = "_|";
            string escalon2 = "|_";
            string piso = "__";
            string escalera = "";
            string espacio = " ";
            string resultado = "";

            if (numero == 0)
            {
                Console.WriteLine(piso);
                
            }
            else if (numero > 0)
            {
                for (int i = numero; i > 0; i--)
                {
                    Console.WriteLine(new string(' ', i - 1) + escalon1);
                }
            }
            else if (numero < 0)
            {
                for (int i = 0; i > numero; i--)
                {
                    espacio += " ";
                    escalera += espacio + escalon2 + "\n";
                }
                var pisofijo = "_" + "\n";
                resultado = escalera;

                Console.WriteLine(resultado);
            }
         
        }

      
    }
}



