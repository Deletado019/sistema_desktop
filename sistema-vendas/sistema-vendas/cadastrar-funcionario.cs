using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_vendas
{
    public partial class cadastrar : Form
    {
        string strConexao = "server=localhost;database=db_sistema_chamados;uid=root;password=;";
        public cadastrar()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prioridade = cbPrioridade.Text.ToLower();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void text_nome_TextChanged(object sender, EventArgs e)
        {
            string nome = text_nome.Text;
        }

        private void text_canal_contato_TextChanged(object sender, EventArgs e)
        {
            string nome = text_canal_contato.Text;
        }

        private void text_assunto_TextChanged(object sender, EventArgs e)
        {
            string nome = text_assunto.Text;
        }

        private void text_cidade_TextChanged(object sender, EventArgs e)
        {
            string cidade = text_cidade.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string observacao = text_observacao.Text;
        }

        private void cadastrar_button_Click(object sender, EventArgs e)
        {
        }
            private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // 1º: Criar a variável com o texto do comando SQL
            string sql = "INSERT INTO tb_chamados (nome, canal_contato, assunto, prioridade, status, cidade, data_abertura, observacao_o) " +
                         "VALUES (@nome, @canal, @assunto, @prioridade, 'aberto', @cidade, NOW(), @obs)";

            // 2º: Abrir a conexão e preparar o comando
            using (MySqlConnection conexao = new MySqlConnection(strConexao))
            {
                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    cmd.Parameters.AddWithValue("@nome", text_nome.Text);
                    cmd.Parameters.AddWithValue("@canal", text_canal_contato.Text);
                    cmd.Parameters.AddWithValue("@assunto", text_assunto.Text);
                    cmd.Parameters.AddWithValue("@prioridade", cbPrioridade.Text); // Texto do ComboBox
                    cmd.Parameters.AddWithValue("@cidade", text_cidade.Text);
                    cmd.Parameters.AddWithValue("@obs", text_observacao.Text);

                    
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro inserido com sucesso!");

                 
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
                }
            }
        }
    }
    }


