namespace sistema_vendas
{
    partial class FormDashboard
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
            this.Label_DashBoard = new System.Windows.Forms.Label();
            this.painelAlertas = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalHD = new System.Windows.Forms.Label();
            this.lblUsadoHD = new System.Windows.Forms.Label();
            this.lblLivreHD = new System.Windows.Forms.Label();
            this.lblPorcentagemHD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_DashBoard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1558, 100);
            this.panel1.TabIndex = 0;
            // 
            // Label_DashBoard
            // 
            this.Label_DashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_DashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_DashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DashBoard.Location = new System.Drawing.Point(0, 0);
            this.Label_DashBoard.Name = "Label_DashBoard";
            this.Label_DashBoard.Size = new System.Drawing.Size(267, 100);
            this.Label_DashBoard.TabIndex = 0;
            this.Label_DashBoard.Text = "Dashboard";
            this.Label_DashBoard.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // painelAlertas
            // 
            this.painelAlertas.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelAlertas.Location = new System.Drawing.Point(0, 100);
            this.painelAlertas.Name = "painelAlertas";
            this.painelAlertas.Size = new System.Drawing.Size(1558, 208);
            this.painelAlertas.TabIndex = 1;
            // 
            // flowLayoutPanelCards
            // 
            this.flowLayoutPanelCards.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelCards.Location = new System.Drawing.Point(0, 308);
            this.flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            this.flowLayoutPanelCards.Size = new System.Drawing.Size(777, 397);
            this.flowLayoutPanelCards.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(777, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 397);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblDataHora);
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 100);
            this.panel3.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(354, 100);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataHora
            // 
            this.lblDataHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHora.Location = new System.Drawing.Point(354, 0);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(427, 100);
            this.lblDataHora.TabIndex = 1;
            this.lblDataHora.Text = "Data";
            this.lblDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPorcentagemHD);
            this.panel4.Controls.Add(this.lblLivreHD);
            this.panel4.Controls.Add(this.lblUsadoHD);
            this.panel4.Controls.Add(this.lblTotalHD);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(781, 297);
            this.panel4.TabIndex = 1;
            // 
            // lblTotalHD
            // 
            this.lblTotalHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHD.Location = new System.Drawing.Point(0, 0);
            this.lblTotalHD.Name = "lblTotalHD";
            this.lblTotalHD.Size = new System.Drawing.Size(781, 36);
            this.lblTotalHD.TabIndex = 0;
            this.lblTotalHD.Text = "Total HD";
            this.lblTotalHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsadoHD
            // 
            this.lblUsadoHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsadoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsadoHD.Location = new System.Drawing.Point(0, 36);
            this.lblUsadoHD.Name = "lblUsadoHD";
            this.lblUsadoHD.Size = new System.Drawing.Size(781, 36);
            this.lblUsadoHD.TabIndex = 1;
            this.lblUsadoHD.Text = "Usando";
            this.lblUsadoHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLivreHD
            // 
            this.lblLivreHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLivreHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivreHD.Location = new System.Drawing.Point(0, 72);
            this.lblLivreHD.Name = "lblLivreHD";
            this.lblLivreHD.Size = new System.Drawing.Size(781, 36);
            this.lblLivreHD.TabIndex = 2;
            this.lblLivreHD.Text = "Livre";
            this.lblLivreHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPorcentagemHD
            // 
            this.lblPorcentagemHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPorcentagemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagemHD.Location = new System.Drawing.Point(0, 108);
            this.lblPorcentagemHD.Name = "lblPorcentagemHD";
            this.lblPorcentagemHD.Size = new System.Drawing.Size(781, 36);
            this.lblPorcentagemHD.TabIndex = 3;
            this.lblPorcentagemHD.Text = "porcentagem";
            this.lblPorcentagemHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 705);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanelCards);
            this.Controls.Add(this.painelAlertas);
            this.Controls.Add(this.panel1);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label_DashBoard;
        private System.Windows.Forms.FlowLayoutPanel painelAlertas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPorcentagemHD;
        private System.Windows.Forms.Label lblLivreHD;
        private System.Windows.Forms.Label lblUsadoHD;
        private System.Windows.Forms.Label lblTotalHD;
    }
}