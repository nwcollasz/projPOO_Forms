using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semáforo
{
    internal class Semáforo
    {

        internal class Semaforo
        {
            private byte dado;
            public Semaforo()
            {
                this.dado = 0;
            }
            public Semaforo(byte dado)
            {
                this.dado = dado;
            }
            public void ligar(int estado)
            {
                dado = (byte)((int)dado | (int)(Math.Pow(2, (estado - 1))));
            }
            public void apagar(int estado)
            {
                dado = (byte)((int)dado & (255 - (int)(Math.Pow(2, (estado - 1)))));
            }

            public byte getestado()
            {
                return dado;
            }

            public bool getled(int estado)
            {
                byte teste;
                teste = (byte)((int)dado & (int)(Math.Pow(2, (estado - 1))));
                return (teste > 0);

            }
        }

    }
}
