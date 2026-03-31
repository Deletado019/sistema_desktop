namespace sistema_vendas
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrar_funcionarios = new System.Windows.Forms.Button();
            this.painelListagemFuncionarios = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.cadastrar_funcionarios);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 87);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1131, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "listagem Funcionarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cadastrar_funcionarios
            // 
            this.cadastrar_funcionarios.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastrar_funcionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastrar_funcionarios.FlatAppearance.BorderSize = 0;
            this.cadastrar_funcionarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cadastrar_funcionarios.Location = new System.Drawing.Point(1131, 0);
            this.cadastrar_funcionarios.Name = "cadastrar_funcionarios";
            this.cadastrar_funcionarios.Size = new System.Drawing.Size(415, 87);
            this.cadastrar_funcionarios.TabIndex = 1;
            this.cadastrar_funcionarios.Text = "Cadastrar";
            this.cadastrar_funcionarios.UseVisualStyleBackColor = false;
            // 
            // painelListagemFuncionarios
            // 
            this.painelListagemFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelListagemFuncionarios.Location = new System.Drawing.Point(0, 87);
            this.painelListagemFuncionarios.Name = "painelListagemFuncionarios";
            this.painelListagemFuncionarios.Size = new System.Drawing.Size(1546, 619);
            this.painelListagemFuncionarios.TabIndex = 1;
            this.painelListagemFuncionarios.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 706);
            this.Controls.Add(this.painelListagemFuncionarios);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrar_funcionarios;
        private System.Windows.Forms.FlowLayoutPanel painelListagemFuncionarios;
    }
}