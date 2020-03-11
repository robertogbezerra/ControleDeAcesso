namespace ControleDeAcesso.view
{
    partial class FrmMonitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gboxEvento = new System.Windows.Forms.GroupBox();
            this.dataGridAlarmes = new System.Windows.Forms.DataGridView();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoAlarme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumIngresso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoleitura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.checkBoxPartidaAtual = new System.Windows.Forms.CheckBox();
            this.cboxTorneio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxEvento = new System.Windows.Forms.ComboBox();
            this.cboxAno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.pictureBoxMonitor = new System.Windows.Forms.PictureBox();
            this.gboxContadores = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.txtPagante = new System.Windows.Forms.TextBox();
            this.txtLivres = new System.Windows.Forms.TextBox();
            this.lblModoLivre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gboxEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlarmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonitor)).BeginInit();
            this.gboxContadores.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gboxEvento);
            this.panel1.Controls.Add(this.gboxContadores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 687);
            this.panel1.TabIndex = 0;
            // 
            // gboxEvento
            // 
            this.gboxEvento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxEvento.Controls.Add(this.dataGridAlarmes);
            this.gboxEvento.Controls.Add(this.btnConsultar);
            this.gboxEvento.Controls.Add(this.checkBoxPartidaAtual);
            this.gboxEvento.Controls.Add(this.cboxTorneio);
            this.gboxEvento.Controls.Add(this.label1);
            this.gboxEvento.Controls.Add(this.cboxEvento);
            this.gboxEvento.Controls.Add(this.cboxAno);
            this.gboxEvento.Controls.Add(this.label2);
            this.gboxEvento.Controls.Add(this.lblAno);
            this.gboxEvento.Controls.Add(this.pictureBoxMonitor);
            this.gboxEvento.Location = new System.Drawing.Point(16, 13);
            this.gboxEvento.Margin = new System.Windows.Forms.Padding(4);
            this.gboxEvento.Name = "gboxEvento";
            this.gboxEvento.Padding = new System.Windows.Forms.Padding(4);
            this.gboxEvento.Size = new System.Drawing.Size(788, 661);
            this.gboxEvento.TabIndex = 2;
            this.gboxEvento.TabStop = false;
            this.gboxEvento.Text = "Monitorar Evento";
            // 
            // dataGridAlarmes
            // 
            this.dataGridAlarmes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridAlarmes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAlarmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlarmes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colData,
            this.colTipoAlarme,
            this.colAcesso,
            this.colNumIngresso,
            this.colTipoleitura});
            this.dataGridAlarmes.Location = new System.Drawing.Point(77, 194);
            this.dataGridAlarmes.Name = "dataGridAlarmes";
            this.dataGridAlarmes.Size = new System.Drawing.Size(639, 277);
            this.dataGridAlarmes.TabIndex = 7;
            this.dataGridAlarmes.Visible = false;
            // 
            // colData
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colData.DefaultCellStyle = dataGridViewCellStyle4;
            this.colData.FillWeight = 10F;
            this.colData.HeaderText = "Data/Hora";
            this.colData.Name = "colData";
            this.colData.Width = 140;
            // 
            // colTipoAlarme
            // 
            this.colTipoAlarme.HeaderText = "Alarme";
            this.colTipoAlarme.Name = "colTipoAlarme";
            this.colTipoAlarme.Width = 150;
            // 
            // colAcesso
            // 
            this.colAcesso.HeaderText = "Acesso";
            this.colAcesso.Name = "colAcesso";
            this.colAcesso.Width = 80;
            // 
            // colNumIngresso
            // 
            this.colNumIngresso.HeaderText = "N°. Ingresso";
            this.colNumIngresso.Name = "colNumIngresso";
            this.colNumIngresso.Width = 115;
            // 
            // colTipoleitura
            // 
            this.colTipoleitura.HeaderText = "Tipo de Leitor";
            this.colTipoleitura.Name = "colTipoleitura";
            this.colTipoleitura.Width = 115;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(683, 87);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(97, 52);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // checkBoxPartidaAtual
            // 
            this.checkBoxPartidaAtual.AutoSize = true;
            this.checkBoxPartidaAtual.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPartidaAtual.Location = new System.Drawing.Point(11, 91);
            this.checkBoxPartidaAtual.Name = "checkBoxPartidaAtual";
            this.checkBoxPartidaAtual.Size = new System.Drawing.Size(102, 20);
            this.checkBoxPartidaAtual.TabIndex = 3;
            this.checkBoxPartidaAtual.Text = "Evento Atual";
            this.checkBoxPartidaAtual.UseVisualStyleBackColor = false;
            this.checkBoxPartidaAtual.CheckedChanged += new System.EventHandler(this.checkBoxPartidaAtual_CheckedChanged);
            // 
            // cboxTorneio
            // 
            this.cboxTorneio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxTorneio.FormattingEnabled = true;
            this.cboxTorneio.Location = new System.Drawing.Point(132, 44);
            this.cboxTorneio.Margin = new System.Windows.Forms.Padding(4);
            this.cboxTorneio.Name = "cboxTorneio";
            this.cboxTorneio.Size = new System.Drawing.Size(212, 24);
            this.cboxTorneio.TabIndex = 1;
            this.cboxTorneio.TextChanged += new System.EventHandler(this.cboxTorneio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Evento";
            // 
            // cboxEvento
            // 
            this.cboxEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxEvento.FormattingEnabled = true;
            this.cboxEvento.Location = new System.Drawing.Point(352, 44);
            this.cboxEvento.Margin = new System.Windows.Forms.Padding(4);
            this.cboxEvento.Name = "cboxEvento";
            this.cboxEvento.Size = new System.Drawing.Size(428, 24);
            this.cboxEvento.TabIndex = 2;
            // 
            // cboxAno
            // 
            this.cboxAno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxAno.FormattingEnabled = true;
            this.cboxAno.Location = new System.Drawing.Point(8, 44);
            this.cboxAno.Margin = new System.Windows.Forms.Padding(4);
            this.cboxAno.Name = "cboxAno";
            this.cboxAno.Size = new System.Drawing.Size(116, 24);
            this.cboxAno.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detalhes";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(8, 24);
            this.lblAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(96, 16);
            this.lblAno.TabIndex = 0;
            this.lblAno.Text = "Ano do Evento";
            // 
            // pictureBoxMonitor
            // 
            this.pictureBoxMonitor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMonitor.Image = global::ControleDeAcesso.Properties.Resources.monitor;
            this.pictureBoxMonitor.Location = new System.Drawing.Point(0, 36);
            this.pictureBoxMonitor.Name = "pictureBoxMonitor";
            this.pictureBoxMonitor.Size = new System.Drawing.Size(788, 618);
            this.pictureBoxMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMonitor.TabIndex = 0;
            this.pictureBoxMonitor.TabStop = false;
            // 
            // gboxContadores
            // 
            this.gboxContadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxContadores.Controls.Add(this.panel2);
            this.gboxContadores.Location = new System.Drawing.Point(812, 13);
            this.gboxContadores.Margin = new System.Windows.Forms.Padding(4);
            this.gboxContadores.Name = "gboxContadores";
            this.gboxContadores.Padding = new System.Windows.Forms.Padding(4);
            this.gboxContadores.Size = new System.Drawing.Size(200, 661);
            this.gboxContadores.TabIndex = 1;
            this.gboxContadores.TabStop = false;
            this.gboxContadores.Text = "Controle de Público";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.lblSupervisor);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblSocio);
            this.panel2.Controls.Add(this.txtPagante);
            this.panel2.Controls.Add(this.txtLivres);
            this.panel2.Controls.Add(this.lblModoLivre);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtSupervisor);
            this.panel2.Controls.Add(this.txtCapacidade);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(4, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 638);
            this.panel2.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(26, 514);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 31);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisor.ForeColor = System.Drawing.Color.Black;
            this.lblSupervisor.Location = new System.Drawing.Point(24, 412);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(153, 20);
            this.lblSupervisor.TabIndex = 13;
            this.lblSupervisor.Text = "Modo Supervidsor";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox3.Location = new System.Drawing.Point(26, 593);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 31);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(44, 570);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Público Total";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(26, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 31);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(25, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Entradas/Minutos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Capacidade";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtTotal.Location = new System.Drawing.Point(26, 435);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(149, 31);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Público Pagante";
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(35, 175);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(130, 20);
            this.lblSocio.TabIndex = 8;
            this.lblSocio.Text = "Sócio Torcedor";
            // 
            // txtPagante
            // 
            this.txtPagante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagante.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtPagante.Location = new System.Drawing.Point(26, 119);
            this.txtPagante.Name = "txtPagante";
            this.txtPagante.Size = new System.Drawing.Size(149, 31);
            this.txtPagante.TabIndex = 1;
            this.txtPagante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLivres
            // 
            this.txtLivres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLivres.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtLivres.Location = new System.Drawing.Point(26, 277);
            this.txtLivres.Name = "txtLivres";
            this.txtLivres.Size = new System.Drawing.Size(149, 31);
            this.txtLivres.TabIndex = 3;
            this.txtLivres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblModoLivre
            // 
            this.lblModoLivre.AutoSize = true;
            this.lblModoLivre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModoLivre.ForeColor = System.Drawing.Color.Black;
            this.lblModoLivre.Location = new System.Drawing.Point(52, 491);
            this.lblModoLivre.Name = "lblModoLivre";
            this.lblModoLivre.Size = new System.Drawing.Size(96, 20);
            this.lblModoLivre.TabIndex = 2;
            this.lblModoLivre.Text = "Modo Livre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lugares Livres";
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupervisor.Location = new System.Drawing.Point(26, 198);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(149, 31);
            this.txtSupervisor.TabIndex = 2;
            this.txtSupervisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacidade.Location = new System.Drawing.Point(26, 40);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(149, 31);
            this.txtCapacidade.TabIndex = 0;
            this.txtCapacidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 687);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMonitor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoramento de acesso";
            this.Load += new System.EventHandler(this.FrmMonitor_Load);
            this.panel1.ResumeLayout(false);
            this.gboxEvento.ResumeLayout(false);
            this.gboxEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlarmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonitor)).EndInit();
            this.gboxContadores.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gboxEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.GroupBox gboxContadores;
        private System.Windows.Forms.ComboBox cboxAno;
        private System.Windows.Forms.ComboBox cboxEvento;
        private System.Windows.Forms.ComboBox cboxTorneio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxPartidaAtual;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.TextBox txtLivres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.Label lblModoLivre;
        private System.Windows.Forms.TextBox txtPagante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridAlarmes;
        private System.Windows.Forms.PictureBox pictureBoxMonitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoAlarme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumIngresso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoleitura;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
    }
}