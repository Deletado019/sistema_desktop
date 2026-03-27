
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
    public partial class FormPrincipal : Form
    {

        
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Click_1(object sender, EventArgs e)
        {
            cadastro_funcionarios tela_funcionario = new cadastro_funcionarios();
            
            panel_principal.Controls.Clear();

            tela_funcionario.Dock = DockStyle.Fill;
            tela_funcionario.TopLevel = false;
            panel_principal.Controls.Add(tela_funcionario);
            tela_funcionario.FormBorderStyle = FormBorderStyle.None;
            tela_funcionario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calculadora_Click(object sender, EventArgs e)
        {
            Form3 tela_calculadora = new Form3();
            tela_calculadora.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void chamados_Click(object sender, EventArgs e)
        {

            chamados tela_chamados = new chamados(this);

      
            panel_principal.Controls.Clear();

            tela_chamados.Dock = DockStyle.Fill;
            tela_chamados.TopLevel = false;
            tela_chamados.FormBorderStyle = FormBorderStyle.None;
            panel_principal.Controls.Add(tela_chamados);
            tela_chamados.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                    }

        private void panel_principal_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel_principal_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
