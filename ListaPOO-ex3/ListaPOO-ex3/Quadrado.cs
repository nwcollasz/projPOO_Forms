using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex3
{
    internal class Quadrado
    {
        private double diagonal;  
        private double area;      
        private double aresta;    

        public Quadrado(double diagonal)
        {
            this.diagonal = diagonal;
        }

        public void SetDiagonal(double diagonal)
        {
            this.diagonal = diagonal;
        }

        public double GetDiagonal()
        {
            return this.diagonal;
        }

        public double GetArea()
        {
            return this.area;
        }

        public void CalcularArea()
        {
            this.aresta = this.diagonal / Math.Sqrt(2);

            this.area = this.aresta * this.aresta;
        }
    }
}

