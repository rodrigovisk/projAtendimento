using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAtendimento
{
    class Senhas
    {
        private int proximoAtendimento;
        public Queue<Senha> filaSenhas;

        public Senhas()
        {
            proximoAtendimento = 1;
            filaSenhas = new Queue<Senha>();
        }

        public void gerar()
        {
            this.filaSenhas.Enqueue(new Senha(proximoAtendimento));

            proximoAtendimento++;
        }
    }
}
