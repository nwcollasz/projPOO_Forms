using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex4
{
    internal class Triangulo
    {
        private double b;
        private double h;
        private double area;

        public Triangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }

        public void SetBase(double b)
        {
            this.b = b;
        }

        public void SetAltura(double h)
        {
            this.h = h;
        }

        public double GetBase()
        {
            return this.b;
        }

        public double GetAltura()
        {
            return this.h;
        }

        public double GetArea()
        {
            return this.area;
        }

        public void CalcularArea()
        {
            this.area = (this.b * this.h) / 2;
        }
    }
}
