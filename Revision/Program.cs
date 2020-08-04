using System;
using System.Linq;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Any())
            {
                int num1 = Convert.ToInt32(args[0]);
                string operacion = args[1];
                int num2 = Convert.ToInt32(args[2]);

                Calculadora calculadora = new Calculadora();

                Console.WriteLine(calculadora.Operar(num1, operacion, num2));

                return;
            }

            Console.WriteLine("Bienvenido a la calculdora");
            
            Console.ReadKey();
        }
    }
}
