namespace ControleDeAcesso.view
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPaiLogin = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.gboxDadosLogin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnLogar = new System.Windows.Forms.Button();
            this.pboxUsuario = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEsqueceuSenha = new System.Windows.Forms.Label();
            this.pboxSideLogin = new System.Windows.Forms.PictureBox();
            this.panelPaiLogin.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.gboxDadosLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSideLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPaiLogin
            // 
            this.panelPaiLogin.Controls.Add(this.panelLogin);
            this.panelPaiLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaiLogin.Location = new System.Drawing.Point(0, 0);
            this.panelPaiLogin.Name = "panelPaiLogin";
            this.panelPaiLogin.Size = new System.Drawing.Size(583, 329);
            this.panelPaiLogin.TabIndex = 4;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.lblTituloLogin);
            this.panelLogin.Controls.Add(this.gboxDadosLogin);
            this.panelLogin.Controls.Add(this.pboxSideLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(583, 329);
            this.panelLogin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fazer Login";
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.Location = new System.Drawing.Point(221, 9);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(350, 26);
            this.lblTituloLogin.TabIndex = 1;
            this.lblTituloLogin.Text = "Fazer autenticação para entrar sistema";
            // 
            // gboxDadosLogin
            // 
            this.gboxDadosLogin.Controls.Add(this.label1);
            this.gboxDadosLogin.Controls.Add(this.lblUsuario);
            this.gboxDadosLogin.Controls.Add(this.btnLogar);
            this.gboxDadosLogin.Controls.Add(this.pboxUsuario);
            this.gboxDadosLogin.Controls.Add(this.txtSenha);
            this.gboxDadosLogin.Controls.Add(this.txtUsuario);
            this.gboxDadosLogin.Controls.Add(this.lblSenha);
            this.gboxDadosLogin.Controls.Add(this.lblEsqueceuSenha);
            this.gboxDadosLogin.Location = new System.Drawing.Point(218, 49);
            this.gboxDadosLogin.Name = "gboxDadosLogin";
            this.gboxDadosLogin.Size = new System.Drawing.Size(353, 277);
            this.gboxDadosLogin.TabIndex = 9;
            this.gboxDadosLogin.TabStop = false;
            this.gboxDadosLogin.Text = "Dados de Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Informe os dados de usuário";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(18, 81);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(121, 19);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Nome de Usuário";
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLogar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.White;
            this.btnLogar.Location = new System.Drawing.Point(22, 226);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(308, 42);
            this.btnLogar.TabIndex = 8;
            this.btnLogar.Text = "Entrar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // pboxUsuario
            // 
            this.pboxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pboxUsuario.Image = global::ControleDeAcesso.Properties.Resources.escudo2;
            this.pboxUsuario.Location = new System.Drawing.Point(22, 19);
            this.pboxUsuario.Name = "pboxUsuario";
            this.pboxUsuario.Size = new System.Drawing.Size(54, 52);
            this.pboxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxUsuario.TabIndex = 7;
            this.pboxUsuario.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(22, 158);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(308, 26);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(22, 103);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(308, 26);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(18, 136);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(48, 19);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.AutoSize = true;
            this.lblEsqueceuSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEsqueceuSenha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueceuSenha.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(18, 187);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(131, 19);
            this.lblEsqueceuSenha.TabIndex = 6;
            this.lblEsqueceuSenha.Text = "Esqueceu a senha?";
            this.lblEsqueceuSenha.Click += new System.EventHandler(this.lblEsqueceuSenha_Click);
            // 
            // pboxSideLogin
            // 
            this.pboxSideLogin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pboxSideLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxSideLogin.Image = global::ControleDeAcesso.Properties.Resources.escudoLogin;
            this.pboxSideLogin.Location = new System.Drawing.Point(3, 3);
            this.pboxSideLogin.Name = "pboxSideLogin";
            this.pboxSideLogin.Size = new System.Drawing.Size(206, 323);
            this.pboxSideLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxSideLogin.TabIndex = 1;
            this.pboxSideLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(583, 329);
            this.Controls.Add(this.panelPaiLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar no Sistema";
            this.panelPaiLogin.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.gboxDadosLogin.ResumeLayout(false);
            this.gboxDadosLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSideLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPaiLogin;
        private System.Windows.Forms.PictureBox pboxSideLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pboxUsuario;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEsqueceuSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.GroupBox gboxDadosLogin;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
    }
}

