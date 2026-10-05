using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cálculo del Factorial del 0 al 10
            for (long contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine("{0}! = {1}", contador, Factorial(contador));
            }

            // Evita que la consola se cierre de golpe al finalizar
            Console.ReadKey();
        }

        // Declaración recursiva del método Factorial
        public static long Factorial(long numero)
        {
            // Caso base: si el número es 0 o 1, el factorial es 1
            if (numero <= 1)
                return 1;
            // Paso de recursividad: el número multiplicado por el factorial del número anterior
            else
                return numero * Factorial(numero - 1);
        }
    }
}