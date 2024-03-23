using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaHandlowa
{
    internal class Miasto
    {
        private readonly string miastoName;

        private readonly Kraj kraj;

        private List<Galeria> galeriaList = new List<Galeria>();
        public Miasto(string miastoName, Kraj kraj)
        {
            this.miastoName = miastoName;
            this.kraj = kraj;
        }

        public void addGaleria(Galeria galeria)
        {
            galeriaList.Add(galeria);
        }
        public Galeria getGaleria(string idGalerii)
        {
            return null;
        }

        public void removeGaleria(string idGaleria)
        {

        }

        public int size()
        {
            return galeriaList.Count;
        }
    }
}

