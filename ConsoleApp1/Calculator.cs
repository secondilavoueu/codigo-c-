using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public int numero1;
        public int numero2;
        public float resultado;

        //Construindo a classe Calculadora

        public Calculator (int numero1, int numero2, float resultado)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
      
        }

        // Método Adição

        public void Adição() {

            resultado = numero1 + numero2;
            Console.WriteLine();
        }

        // Método Subtração

        public void Subtração()
        {

            Console.WriteLine("A subtração entre esses números é: " + (numero1 - numero2));
        }

        // Método Multiplicação

        public void Multiplicação()
        {

            Console.WriteLine("A multiplicação entre esses números é: " + (numero1 * numero2));
        }

        // Método Divisão

        public void Divisão()
        {
            Console.WriteLine("A divisão entre esses números é: " + (numero1 / numero2));
        }
        public void On()
        {
            Console.WriteLine("soma entre esses números é: " + Adição());
        }

    }
}
