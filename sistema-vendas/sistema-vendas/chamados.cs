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

        private void chamados_Load(object sender, EventArgs e)
        {
            // --- DAQUI PARA BAIXO FOI ADICIONADO E ADAPTADO ---

            // Conexão com o banco (ajuste o nome do banco se for diferente de 'sistema_vendas')
            string conexao = "server=localhost;database=db_sistema_chamados;uid=root;pwd=;";

            MySqlConnection conn = new MySqlConnection(conexao);
            conn.Open();

            // Buscando os dados que o bloco de notas pediu: nome, data, prioridade e status
            string sql = @"SELECT nome, data_abertura, prioridade, status FROM tb_chamados";
            MySqlCommand comando = new MySqlCommand(sql, conn);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Panel card = new Panel();
                card.Width = 250;
                card.Height = 180;
                card.Margin = new Padding(10); // Dá um espacinho show entre os cards

                string status = reader["status"].ToString().ToLower();

                // 1. Cor de fundo do card de acordo com o status
                if (status == "aberto")
                {
                    card.BackColor = Color.Red;
                }
                else if (status == "em andamento")
                {
                    card.BackColor = Color.Yellow;
                }
                else if (status == "resolvido")
                {
                    card.BackColor = Color.Green;
                }
                else
                {
                    card.BackColor = Color.Gray; // Cor padrão caso venha vazio
                }

                // 2. Adicionar a data de abertura
                Label dataAbertura = new Label();
                // Converte e deixa no padrão brasileiro: dia/mês/ano
                dataAbertura.Text = "Aberto em: " + Convert.ToDateTime(reader["data_abertura"]).ToString("dd/MM/yyyy");
                dataAbertura.ForeColor = (status == "em andamento") ? Color.Black : Color.White; // Amarelo com letra branca não dá pra ler!
                dataAbertura.Font = new Font("Arial", 10);
                dataAbertura.TextAlign = ContentAlignment.MiddleCenter;
                dataAbertura.AutoSize = false;
                dataAbertura.Dock = DockStyle.Top;
                card.Controls.Add(dataAbertura);

                // 3. Adicionar o Nome
                Label nome = new Label();
                nome.ForeColor = (status == "em andamento") ? Color.Black : Color.White;
                nome.Font = new Font("Arial", 12, FontStyle.Bold);
                nome.TextAlign = ContentAlignment.MiddleCenter;
                nome.AutoSize = false;
                nome.Text = reader["nome"].ToString();
                nome.Dock = DockStyle.Top;
                card.Controls.Add(nome);

                // 4. Caso a prioridade for alta (mostrar o label)
                string prioridade = reader["prioridade"].ToString().ToLower();
                if (prioridade == "alta")
                {
                    Label labelPrioridade = new Label();
                    labelPrioridade.Text = "⚠ PRIORIDADE ALTA";
                    labelPrioridade.ForeColor = Color.DarkRed;
                    labelPrioridade.BackColor = Color.White;
                    labelPrioridade.Font = new Font("Arial", 10, FontStyle.Bold);
                    labelPrioridade.TextAlign = ContentAlignment.MiddleCenter;
                    labelPrioridade.AutoSize = false;
                    labelPrioridade.Dock = DockStyle.Bottom;
                    labelPrioridade.Height = 30;
                    card.Controls.Add(labelPrioridade);
                }

                // Adiciona o card dentro do seu painel de lista
                panel_lista.Controls.Add(card);
            }

            reader.Close();
            conn.Close();
        }
    }
}