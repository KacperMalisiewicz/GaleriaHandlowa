using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaHandlowa
{
    internal class Kontynent
    {
        private List<Kraj> krajList = new List<Kraj>();

    public void addKraj(Kraj kraj)
        {
            krajList.Add(kraj);
        }
    public Kraj getKraj(string idKraju)
        {
            return null;
        }

    public void removeKraj(string idKraj)
        {

        }

        public int size()
        {
            return krajList.Count;
        }
    }
}
