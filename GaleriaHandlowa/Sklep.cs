using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaHandlowa
{
    internal class Sklep
    {
        public Sklep() { }

        private readonly Galeria galeria;

        private int x;

        private readonly int y;

        public Sklep(int x, int y)
        {
            if (x >0)
            {
                this.x = x;
            }
            if (y > 0)
            {
                this.y = y;
            }
        }

        public Sklep(int x, int y, Galeria galeria)
        {
            this.galeria = galeria;
            if (x > 0) { this.x = x; }
            if (y > 0) { this.y = y; }
        }

        public int X
        {
            get { return x; }
            set
            {
                if (x > 0)
                {
                    this.x = x;
                }
            }
        }
    }
}
