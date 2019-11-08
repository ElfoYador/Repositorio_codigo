using System;

namespace BasicosCSharp
{
    public class Program
    {

        static int maximo (int a, int b) {

            if (a > b)
                return a;
            else
                return b;


        }

        static int maximo(int a, int b, int c)
        {

            return maximo(a, maximo(b, c));


        }
        public static int factorial(int a)
        {
            if (a == 0)
                return 1;
            else
                return a*factorial(a - 1);
        }

        public static int factorialWhile(int a)
        {
            int resultado = a;
            while (a-- > 0)
               resultado *=  a;
            return resultado;
        }

        public static int factorialFor(int a)
        {
            int resultado = 1;
            for (int i = 1; i <= a; i++)
                resultado *= i;
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String texto = "hola";

            Console.WriteLine(maximo(3, 5));
            Console.Read();
        }
    }
}
