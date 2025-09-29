using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex2
{
    internal class Quadrado
    {
        private double aresta;  
        private double area;    

        
        public Quadrado(double aresta)
        {
            this.aresta = aresta;
        }

        
        public void SetAresta(double aresta)
        {
            this.aresta = aresta;
        }

      
        public double GetAresta()
        {
            return this.aresta;
        }

        
        public double GetArea()
        {
            return this.area;
        }

       
        public void CalcularArea()
        {
            this.area = this.aresta * this.aresta;
        }
    }
}
    
