using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da diagonal do quadrado:");
            double diagonal = Double.Parse (Console.ReadLine());
            Quadrado quadrado = new Quadrado(diagonal);
            quadrado.CalcularArea();  
            Console.WriteLine("A área do quadrado é: {0} ",  quadrado.GetArea());
        }
    }
}
