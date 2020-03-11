namespace ControleDeAcesso.view
{
    partial class FrmRecuperacaoSenha
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
            this.btnProximo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxPerguntas = new System.Windows.Forms.ComboBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(199, 15);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(264, 41);
            this.btnProximo.TabIndex = 29;
            this.btnProximo.Text = "Prosseguir";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ControleDeAcesso.Properties.Resources.fundo;
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 68);
            this.panel1.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cboxPerguntas);
            this.groupBox2.Controls.Add(this.txtResposta);
            this.groupBox2.Controls.Add(this.lblResposta);
            this.groupBox2.Controls.Add(this.lblPergunta);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 184);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pergunta de Segurança";
            // 
            // cboxPerguntas
            // 
            this.cboxPerguntas.Font = new System.Drawing.Font("Yu Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPerguntas.FormattingEnabled = true;
            this.cboxPerguntas.Location = new System.Drawing.Point(19, 57);
            this.cboxPerguntas.Name = "cboxPerguntas";
            this.cboxPerguntas.Size = new System.Drawing.Size(599, 27);
            this.cboxPerguntas.TabIndex = 43;
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(19, 129);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(599, 28);
            this.txtResposta.TabIndex = 42;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResposta.ForeColor = System.Drawing.Color.White;
            this.lblResposta.Location = new System.Drawing.Point(16, 109);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(73, 17);
            this.lblResposta.TabIndex = 40;
            this.lblResposta.Text = "Resposta";
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPergunta.ForeColor = System.Drawing.Color.White;
            this.lblPergunta.Location = new System.Drawing.Point(16, 37);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(72, 17);
            this.lblPergunta.TabIndex = 37;
            this.lblPergunta.Text = "Pergunta";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(103, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(515, 42);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "Recuperação de Senha - Paso 1";
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUsuario.Image = global::ControleDeAcesso.Properties.Resources.cadeado_64;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(85, 79);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuario.TabIndex = 34;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // FrmRecuperacaoSenha
            // 
            this.BackgroundImage = global::ControleDeAcesso.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(657, 363);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBoxUsuario);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmRecuperacaoSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRecuperacaoSenha_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboxPerguntas;
    }
}