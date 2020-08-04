using System;
using System.Collections.Generic;
using System.Text;

namespace Revision
{
    public class Calculadora
    {
        public string Operar(int numeroUno, string operacion, int numeroDos)
        {
            if (operacion == "+")
            {
                return $"{numeroUno + numeroDos}";
            }
            return $"La operación ingresada: {operacion} no se puedo ejecutar";
        }
    }
}
