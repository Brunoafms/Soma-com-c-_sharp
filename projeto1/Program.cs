using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro número para ser somado");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número para ser somado");
            int b = int.Parse(Console.ReadLine());
            int soma = a + b;
            Console.WriteLine("Soma: " + soma);

        }
    }
}

    