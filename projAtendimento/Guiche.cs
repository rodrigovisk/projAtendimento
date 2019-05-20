using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAtendimento
{
    class Guiche
    {
        private int id;
        public Queue<Senha> atendimentos;

        public Guiche()
        {
            id = 0;
            atendimentos = new Queue<Senha>();
        }

        public Guiche(int id)
        {
            this.id = id;
            atendimentos = new Queue<Senha>();
        }

        public bool Chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas.Count() == 0)
            {
                return false;
            }
            else
            {
                Senha aux = filaSenhas.Dequeue();
                aux.dataAtend = DateTime.Now.Date;
                aux.horaAtend = DateTime.Now;

                this.atendimentos.Enqueue(aux);

                return true;
            } 
        }
    }
}
