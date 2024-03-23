using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaHandlowa
{
    internal class Kraj
    {
        private List<Miasto> miastoList = new List<Miasto>();

        public Kraj(string idPanstwa)
        {
            
        }

        public void addMiast(Miasto miasto)
        {
            miastoList.Add(miasto);
        }
        public Miasto getMiasto(string idMiasta)
        {
            return null;
        }

        public void removeMiasto(string idMiasto)
        {

        }

        public int size()
        {
            return miastoList.Count;
        }
    }
}

