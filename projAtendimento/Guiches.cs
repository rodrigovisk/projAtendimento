using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAtendimento
{
    class Guiches
    {
        public List<Guiche> listaGuiches;

        public Guiches()
        {
            listaGuiches = new List<Guiche>();
        }

        public void adicionar(Guiche guiche)
        {
            this.listaGuiches.Add(guiche);
        }
    }
}
