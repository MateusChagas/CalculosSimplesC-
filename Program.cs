using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosMatematicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro");
            int Numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Insira outro número inteiro");
            int Numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Os números inseridos foram "+ Numero1+" e "+ Numero2);
            Console.WriteLine();
            Console.WriteLine("Soma = " + (Numero1 + Numero2));
            Console.WriteLine("Subtração = " + (Numero1 - Numero2));
            Console.WriteLine("Multiplicação " + Numero1 * Numero2);
            Console.WriteLine("Divisão" + Numero1 / Numero2);
            Console.ReadKey();


        }
    }
}
