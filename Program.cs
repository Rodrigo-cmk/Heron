using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {





            double a, b, c;
            double s, A;



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---- Exercício Heron ----");
            Console.WriteLine("Cálculo da área de um triângulo qualquer, dadas as medidas dos 3 lados.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("- Lado 1");
            a = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("- Lado 2");
            b = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("- Lado 3");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            s = (a+b+c)/2;
            A = Math.Sqrt(s*(s-a)*(s-b)*(s-c));

            Console.WriteLine($"--> Semiperímetro: {s}.");
            Console.WriteLine($"--> Área: {A}.");     

          










        }
    }
}
