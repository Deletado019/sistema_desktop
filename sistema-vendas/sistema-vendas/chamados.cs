using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_vendas
{
    public partial class chamados : Form
    {
        private FormPrincipal principal;
  
        public chamados(FormPrincipal form)
        {
            InitializeComponent();
            principal = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastrar tela_cadastro = new cadastrar();


            tela_cadastro.Dock = DockStyle.Fill;
            tela_cadastro.FormBorderStyle = FormBorderStyle.None;
            tela_cadastro.TopLevel = false;

            principal.panel_principal.Controls.Clear();
            principal.panel_principal.Controls.Add(tela_cadastro);
            tela_cadastro.Show();

        }
    }
}
