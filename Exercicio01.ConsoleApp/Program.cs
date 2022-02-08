using System;

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numA, numB, numC;

            Console.Write("Digite o número A: ");
            numA = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Digite o número B: ");
            numB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o número C: ");
            numC = Convert.ToDouble(Console.ReadLine());

            if (numA + numB < numC)
            {
                Console.WriteLine("Sim,A + B é menor que C ! ! ! ");
               
            } else { Console.WriteLine("Não,A+B é maior que C ! ! !"); }
            Console.ReadLine();
           
               
        }
    }
}
