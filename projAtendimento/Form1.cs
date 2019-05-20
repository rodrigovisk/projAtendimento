using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projAtendimento
{
    public partial class Form1 : Form
    {
        private Senhas senhas = new Senhas();
        private Guiches guiches = new Guiches();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void btnListSenhas_Click(object sender, EventArgs e)
        {
            lbSenhas.Items.Clear();
            foreach (Senha s in senhas.filaSenhas) { lbSenhas.Items.Add(s.dadosParciais()); }
        }

        private void btnAddGuiche_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche());

            lblQtdGuiches.Text = guiches.listaGuiches.Count.ToString();
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(txtGuiche.Text) - 1;
            guiches.listaGuiches[index].Chamar(senhas.filaSenhas);
        }

        private void btnAtendimentos_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(txtGuiche.Text) - 1;

            lbAtendimentos.Items.Clear();
            foreach (Senha s in guiches.listaGuiches[index].atendimentos.ToList()) { lbAtendimentos.Items.Add(s.dadosCompletos()); }
        }
    }
}
