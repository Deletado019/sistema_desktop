namespace sistema_vendas
{
    partial class cadastro_funcionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cadastrar_funcionario = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.departamento = new System.Windows.Forms.ComboBox();
            this.label_departamento = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.label_telefone = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.label_cpf = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.nome = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label_nome = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.email = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label_email = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 620);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(66, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(447, 565);
            this.panel5.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cadastrar_funcionario, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 565);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // cadastrar_funcionario
            // 
            this.cadastrar_funcionario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastrar_funcionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastrar_funcionario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cadastrar_funcionario.Location = new System.Drawing.Point(3, 473);
            this.cadastrar_funcionario.Name = "cadastrar_funcionario";
            this.cadastrar_funcionario.Size = new System.Drawing.Size(441, 89);
            this.cadastrar_funcionario.TabIndex = 6;
            this.cadastrar_funcionario.Text = "cadastrar";
            this.cadastrar_funcionario.UseVisualStyleBackColor = false;
            this.cadastrar_funcionario.Click += new System.EventHandler(this.cadastrar_funcionario_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.departamento);
            this.panel10.Controls.Add(this.label_departamento);
            this.panel10.Location = new System.Drawing.Point(3, 379);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(392, 88);
            this.panel10.TabIndex = 5;
            // 
            // departamento
            // 
            this.departamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departamento.FormattingEnabled = true;
            this.departamento.Items.AddRange(new object[] {
            "Administrador",
            "vendas",
            "TI"});
            this.departamento.Location = new System.Drawing.Point(0, 41);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(392, 21);
            this.departamento.TabIndex = 5;
            // 
            // label_departamento
            // 
            this.label_departamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_departamento.Location = new System.Drawing.Point(0, 0);
            this.label_departamento.Name = "label_departamento";
            this.label_departamento.Size = new System.Drawing.Size(392, 41);
            this.label_departamento.TabIndex = 4;
            this.label_departamento.Text = "Departamento";
            this.label_departamento.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.telefone);
            this.panel9.Controls.Add(this.label_telefone);
            this.panel9.Location = new System.Drawing.Point(3, 285);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(392, 88);
            this.panel9.TabIndex = 4;
            // 
            // telefone
            // 
            this.telefone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.telefone.Location = new System.Drawing.Point(0, 68);
            this.telefone.Mask = "(99) 0000-00000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(392, 20);
            this.telefone.TabIndex = 5;
            // 
            // label_telefone
            // 
            this.label_telefone.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telefone.Location = new System.Drawing.Point(0, 0);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(392, 65);
            this.label_telefone.TabIndex = 4;
            this.label_telefone.Text = "Telefone";
            this.label_telefone.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel15);
            this.panel8.Controls.Add(this.cpf);
            this.panel8.Controls.Add(this.label_cpf);
            this.panel8.Location = new System.Drawing.Point(3, 191);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(392, 88);
            this.panel8.TabIndex = 3;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 26);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(392, 42);
            this.panel15.TabIndex = 6;
            // 
            // cpf
            // 
            this.cpf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cpf.Location = new System.Drawing.Point(0, 68);
            this.cpf.Mask = "000,000,000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(392, 20);
            this.cpf.TabIndex = 5;
            // 
            // label_cpf
            // 
            this.label_cpf.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cpf.Location = new System.Drawing.Point(0, 0);
            this.label_cpf.Name = "label_cpf";
            this.label_cpf.Size = new System.Drawing.Size(392, 26);
            this.label_cpf.TabIndex = 4;
            this.label_cpf.Text = "CPF";
            this.label_cpf.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(395, 88);
            this.panel6.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.nome);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 44);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(395, 44);
            this.panel12.TabIndex = 3;
            // 
            // nome
            // 
            this.nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nome.Location = new System.Drawing.Point(0, 0);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(395, 20);
            this.nome.TabIndex = 0;
            this.nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label_nome);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(395, 44);
            this.panel11.TabIndex = 2;
            // 
            // label_nome
            // 
            this.label_nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(0, 0);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(395, 44);
            this.label_nome.TabIndex = 1;
            this.label_nome.Text = "Nome";
            this.label_nome.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel14);
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 97);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(441, 88);
            this.panel7.TabIndex = 7;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.email);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 38);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(441, 53);
            this.panel14.TabIndex = 1;
            // 
            // email
            // 
            this.email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.email.Location = new System.Drawing.Point(0, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(441, 20);
            this.email.TabIndex = 3;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label_email);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(441, 38);
            this.panel13.TabIndex = 0;
            // 
            // label_email
            // 
            this.label_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(0, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(441, 38);
            this.label_email.TabIndex = 4;
            this.label_email.Text = "E-mail";
            this.label_email.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label_email.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(513, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 565);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(66, 565);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 55);
            this.panel2.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // cadastro_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 620);
            this.Controls.Add(this.panel1);
            this.Name = "cadastro_funcionarios";
            this.Text = "cadastro_funcionarios";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label_cpf;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.MaskedTextBox telefone;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox departamento;
        private System.Windows.Forms.Label label_departamento;
        private System.Windows.Forms.Button cadastrar_funcionario;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel15;
    }
}