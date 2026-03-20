
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_vendas
{
    public partial class Form3 : Form
    {
        string strConexao = "server=localhost;database=db_calculadora;uid=root;password=;";
        private decimal resultado { get; set; }
        private decimal valor1 { get; set; }
        private enum operacao
        {
            soma,
            subtracao,
            multiplicacao,
            divisao
        }

        private operacao operacao_selecionada { get; set; }
        public Form3()
        {
          
        InitializeComponent();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtvisor.Clear();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "9";
        }

        private void button_virgula_Click(object sender, EventArgs e)
        {
            if (!txtvisor.Text.Contains(","))
            {
                txtvisor.Text += ",";
            }
            
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            txtvisor.Text += "0";   
        }

        private void button_mais_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtvisor.Text);
            operacao_selecionada = operacao.soma;
            txtvisor.Clear();
        }

        private void button_igual_Click(object sender, EventArgs e)
        {
            decimal valor2 = Convert.ToDecimal(txtvisor.Text);
           

            switch (operacao_selecionada)
            {
                case operacao.soma:
                    resultado = valor1 + valor2;
                    break;
                case operacao.subtracao:
                    resultado = valor1 - valor2;
                    break;
                case operacao.multiplicacao:
                    resultado = valor1 * valor2;
                    break;
                case operacao.divisao:
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    else
                        MessageBox.Show("Não é possível dividir por zero!");
                    break;
            }

            txtvisor.Text = resultado.ToString();
            try
            {
                // 1. Prepara a conexão
                using (MySqlConnection conexao = new MySqlConnection(strConexao))
                {
                    conexao.Open();

                    // 2. O comando SQL (Use o nome que você deu para a sua tabela no HeidiSQL)
                    string sql = "INSERT INTO tb_historico (valor1,operacao, valor2, resultado, data_hora) " +
                                 "VALUES (@v1, @op, @v2, @res, NOW())";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);

                    // 3. Vincula as variáveis do C# com as colunas do banco
                    cmd.Parameters.AddWithValue("@v1", valor1);
                    cmd.Parameters.AddWithValue("@op", operacao_selecionada.ToString());
                    cmd.Parameters.AddWithValue("@v2", valor2);
                    cmd.Parameters.AddWithValue("@res", resultado);

                    // 4. Manda pro banco de verdade
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A conta foi feita, mas não salvou no banco: " + ex.Message);
            }
        }

        private void button_menos_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtvisor.Text);
            operacao_selecionada = operacao.subtracao;
            txtvisor.Clear();
        }

        private void button_Div_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtvisor.Text);
            operacao_selecionada = operacao.divisao;
            txtvisor.Clear();
        }

        private void button_Vezes_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(txtvisor.Text);
            operacao_selecionada = operacao.multiplicacao;
            txtvisor.Clear();
        }
    }
}
