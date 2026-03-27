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
    public partial class cadastro_funcionarios : Form
    {
        string strConexao = "server=localhost;database=sistema_vendas;uid=root;password=;";
        public cadastro_funcionarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
           private void cadastrar_funcionario_Click(object sender, EventArgs e)
        {
            // Validação do Nome
            if (nome.Text.Trim() == "")
            {
                MessageBox.Show("Nome é obrigatório.");
                nome.Focus();
                return;
            }

            // Validação do E-mail
            if (email.Text.Trim() == "")
            {
                MessageBox.Show("E-mail é obrigatório.");
                email.Focus();
                return;
            }

           
            if (cpf.MaskCompleted == false) 
            {
                MessageBox.Show("CPF incompleto ou obrigatório.");
                cpf.Focus();
                return;
            }

            
            if (telefone.MaskCompleted == false)
            {
                MessageBox.Show("Telefone incompleto ou obrigatório.");
                telefone.Focus();
                return;
            }

            // Validação do Departamento (ComboBox)
            // Se o índice for -1, significa que nada foi selecionado na lista
            if (departamento.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um departamento.");
                departamento.Focus();
                return;
            }

            // Se o código chegar aqui, todos os campos passaram no teste!
            MessageBox.Show("Funcionário cadastrado com sucesso!");

            string sql = "INSERT INTO tb_funcionario (nome, cpf, telefone, departamento, email) " +
             "VALUES (@nome, @cpf, @telefone, @depto, @email)";

            using (MySqlConnection conexao = new MySqlConnection(strConexao))
            {
                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    // Vinculando os campos do formulário aos parâmetros do SQL
                    cmd.Parameters.AddWithValue("@nome", nome.Text);
                    cmd.Parameters.AddWithValue("@cpf", cpf.Text);
                    cmd.Parameters.AddWithValue("@telefone", telefone.Text);
                    cmd.Parameters.AddWithValue("@depto", departamento.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro inserido com sucesso!");

                    // Opcional: Limpar os campos após o sucesso
                    nome.Clear();
                    cpf.Clear();
                    telefone.Clear();
                    email.Clear();
                    departamento.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message);
                }
            }

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cadastrar_funcionario_Click_1(object sender, EventArgs e)
        {
          
        }

        private void label_nome_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

