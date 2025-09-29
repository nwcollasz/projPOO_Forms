using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da aresta do quadrado:");
            double aresta = Double.Parse(Console.ReadLine());

            Quadrado quadrado = new Quadrado(aresta);
            quadrado.CalcularArea();  // AREA
            Console.WriteLine("A área do quadrado é: " + quadrado.GetArea());
        }
    }
}
