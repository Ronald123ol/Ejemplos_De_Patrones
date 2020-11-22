using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronEstrategia_cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Dato = "";
            double x = 0;
            double y = 0;
            double proceso = 0;
            string opciones = "";
            IOperaciones misOperaciones = new Suma();

            while (opciones != "5")
            {
                Console.WriteLine("1- Suma, 2- Resta, 3- Multiplicacion, 4- Division, 5- Salir");
                opciones = Console.ReadLine();

                if (opciones == "5")
                    break;

                Console.WriteLine("Colocar el valor de a");
                Dato = Console.ReadLine();
                x = Convert.ToDouble(Dato);

                Console.WriteLine("Colocar el valor de b");
                Dato = Console.ReadLine();
                y = Convert.ToDouble(Dato);

                if (opciones == "1")
                    misOperaciones = new Suma();
                if (opciones == "2")
                    misOperaciones = new Resta();
                if (opciones == "3")
                    misOperaciones = new Multiplicacion();
                if (opciones == "4")
                    misOperaciones = new Division();

                    proceso = misOperaciones.operaciones(x, y);
                     Console.Clear();
                     Console.WriteLine("El resultado es {0}", proceso);
            }
        }
    }
}
