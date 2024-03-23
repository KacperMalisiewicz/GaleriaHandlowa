using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaHandlowa
{
    internal class Galeria
    {
        private readonly string galeriaName;

        private readonly Miasto miasto;

        private List<Sklep> sklepList = new List<Sklep>();

        public Galeria( Miasto miasto)
        { 
            this.miasto = miasto;
        }
        public void addSklep(Sklep sklep)
        {
            sklepList.Add(sklep);
            
        }
        public Miasto getSklep(string idSklepu)
        {
            return null;
        }

        public void removeSklep(string idSklep)
        {

        }

        public int size()
        {
            return sklepList.Count;
        }


    }
}
