using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa.cs
{
    class Program // clase ejecutora
    {
        static void Main(string[] args)
        {
            string nombre, apellido;
            Console.WriteLine("ingrese nombre");
            nombre = System.Console.ReadLine();
            Console.WriteLine("ingrese apellido");
            apellido = System.Console.ReadLine();
            saludar(nombre, apellido);
            System.Console.ReadKey();
        }

        static void saludar (string nombre, string apellido)
        {
            System.Console.WriteLine("Hola {0} {1} .como estas?", nombre, apellido); // escribo en pantalla
        }

        static int doble(int numero)
        {
            int resultado = numero * 2;
            return resultado;
        }

    }
}
