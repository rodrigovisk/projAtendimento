using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projAtendimento
{
    class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        public DateTime dataAtend;
        public DateTime horaAtend;

        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Now;
            this.horaGerac = DateTime.Now;
        }

        public string dadosParciais()
        {
            return id + " - " +dataGerac.ToString("dd/MM/yyyy") + " - " +horaGerac;
        }
        public string dadosCompletos()
        {
            return id + "-" + dataGerac + "-" + horaGerac + "-" + dataAtend + "-" + horaAtend;
        }
    }
}
