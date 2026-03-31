using MySql.Data.MySqlClient;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=sistema_vendas;uid=root;pwd=;";

            MySqlConnection conn = new MySqlConnection(conexao);
            conn.Open();

            string sql = "SELECT nome from tb_funcionario";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Panel card = new Panel();
                card.Width = 300;
                card.Height = 200;
                card.BackColor = Color.Green;

                // Cria o texto do nome
                Label lblNome = new Label();

                // Pega o nome vindo direto do banco de dados!
                lblNome.Text = reader["nome"].ToString();

                lblNome.ForeColor = Color.White;
                lblNome.Dock = DockStyle.Top;
                lblNome.TextAlign = ContentAlignment.MiddleCenter;
                lblNome.Font = new Font("Arial", 12, FontStyle.Bold);

                // Primeiro adicionamos o texto DENTRO do card
                card.Controls.Add(lblNome);

                // Depois adicionamos o card completo na tela
                painelListagemFuncionarios.Controls.Add(card);
            }

            // Sempre feche as conexões para evitar travar o banco!
            reader.Close();
            conn.Close();
        }
    }
}
