using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int N1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int N2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual tipo de conta você quer rea1lizar (1 = +, 2 = -, 3 = *, 4 = /)? ");
            int conta = int.Parse(Console.ReadLine());

            if (conta == 1) 
            {
            int resultado = N1 + N2;
            Console.WriteLine("A sua conta deu: " +  resultado);
            }
            else if (conta == 2) 
            {
            int resultado = N1 - N2;
            Console.WriteLine("A sua conta deu: " + resultado);
            }
            else if (conta == 3)
            {
            int resultado = N1 * N2;
            Console.WriteLine("A sua conta deu: " + resultado);
            } 
            else if (conta == 4)
            {
            int resultado = N1 / N2;
            Console.WriteLine("A sua conta deu: " + resultado);
            }

        }
    }
}
