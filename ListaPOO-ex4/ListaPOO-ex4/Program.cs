using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b = 10;
            double h = 7;

            Triangulo triangulo = new Triangulo(b, h);
            triangulo.CalcularArea();
            Console.WriteLine("A área do triângulo é:{0}", triangulo.GetArea());
        }
    }
}
