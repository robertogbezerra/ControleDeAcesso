namespace ControleDeAcesso.view
{
    partial class FrmRelatorios
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gboxPreferenciaRelatorio = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblChave = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.lblTipoVisualizacao = new System.Windows.Forms.Label();
            this.btnPesquisarRelatorio = new System.Windows.Forms.Button();
            this.cboxRelatorios = new System.Windows.Forms.ComboBox();
            this.cboxTipoVisualizacao = new System.Windows.Forms.ComboBox();
            this.gboxOpcoesFiltros = new System.Windows.Forms.GroupBox();
            this.chboxEmail = new System.Windows.Forms.CheckBox();
            this.chboxChaave = new System.Windows.Forms.CheckBox();
            this.chboxCodigo = new System.Windows.Forms.CheckBox();
            this.gboxData = new System.Windows.Forms.GroupBox();
            this.chboxPermiteData = new System.Windows.Forms.CheckBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFim = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.chboxNome = new System.Windows.Forms.CheckBox();
            this.rvEventos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelFundo = new System.Windows.Forms.FlowLayoutPanel();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controledeacessocfoDataSet = new ControleDeAcesso.controledeacessocfoDataSet();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosTableAdapter = new ControleDeAcesso.controledeacessocfoDataSetTableAdapters.eventosTableAdapter();
            this.categoriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new ControleDeAcesso.controledeacessocfoDataSetTableAdapters.categoriasTableAdapter();
            this.configuracoes_de_sistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configuracoesdesistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configuracoes_de_sistemaTableAdapter = new ControleDeAcesso.controledeacessocfoDataSetTableAdapters.configuracoes_de_sistemaTableAdapter();
            this.ingressosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ingressosTableAdapter = new ControleDeAcesso.controledeacessocfoDataSetTableAdapters.ingressosTableAdapter();
            this.usuariosTableAdapter = new ControleDeAcesso.controledeacessocfoDataSetTableAdapters.usuariosTableAdapter();
            this.gboxPreferenciaRelatorio.SuspendLayout();
            this.gboxOpcoesFiltros.SuspendLayout();
            this.gboxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controledeacessocfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracoes_de_sistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracoesdesistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingressosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxPreferenciaRelatorio
            // 
            this.gboxPreferenciaRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxPreferenciaRelatorio.Controls.Add(this.lblEmail);
            this.gboxPreferenciaRelatorio.Controls.Add(this.lblChave);
            this.gboxPreferenciaRelatorio.Controls.Add(this.lblNome);
            this.gboxPreferenciaRelatorio.Controls.Add(this.lblCodigo);
            this.gboxPreferenciaRelatorio.Controls.Add(this.txtEmail);
            this.gboxPreferenciaRelatorio.Controls.Add(this.txtChave);
            this.gboxPreferenciaRelatorio.Controls.Add(this.txtNome);
            this.gboxPreferenciaRelatorio.Controls.Add(this.txtCodigo);
            this.gboxPreferenciaRelatorio.Controls.Add(this.lblRelatorios);
            this.gboxPreferenciaRelatorio.Controls.Add(this.lblTipoVisualizacao);
            this.gboxPreferenciaRelatorio.Controls.Add(this.btnPesquisarRelatorio);
            this.gboxPreferenciaRelatorio.Controls.Add(this.cboxRelatorios);
            this.gboxPreferenciaRelatorio.Controls.Add(this.cboxTipoVisualizacao);
            this.gboxPreferenciaRelatorio.Controls.Add(this.gboxOpcoesFiltros);
            this.gboxPreferenciaRelatorio.Location = new System.Drawing.Point(12, 12);
            this.gboxPreferenciaRelatorio.Name = "gboxPreferenciaRelatorio";
            this.gboxPreferenciaRelatorio.Size = new System.Drawing.Size(795, 201);
            this.gboxPreferenciaRelatorio.TabIndex = 0;
            this.gboxPreferenciaRelatorio.TabStop = false;
            this.gboxPreferenciaRelatorio.Text = "Filtrar Relatórios";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(214, 173);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(6, 173);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(38, 13);
            this.lblChave.TabIndex = 9;
            this.lblChave.Text = "Chave";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 141);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(456, 141);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Código";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(252, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(398, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(47, 170);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(161, 20);
            this.txtChave.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(47, 138);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(400, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(502, 138);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(148, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.AutoSize = true;
            this.lblRelatorios.Location = new System.Drawing.Point(6, 16);
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(54, 13);
            this.lblRelatorios.TabIndex = 5;
            this.lblRelatorios.Text = "Relatórios";
            // 
            // lblTipoVisualizacao
            // 
            this.lblTipoVisualizacao.AutoSize = true;
            this.lblTipoVisualizacao.Location = new System.Drawing.Point(357, 16);
            this.lblTipoVisualizacao.Name = "lblTipoVisualizacao";
            this.lblTipoVisualizacao.Size = new System.Drawing.Size(105, 13);
            this.lblTipoVisualizacao.TabIndex = 7;
            this.lblTipoVisualizacao.Text = "Tipo de Visualização";
            // 
            // btnPesquisarRelatorio
            // 
            this.btnPesquisarRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarRelatorio.Location = new System.Drawing.Point(656, 138);
            this.btnPesquisarRelatorio.Name = "btnPesquisarRelatorio";
            this.btnPesquisarRelatorio.Size = new System.Drawing.Size(131, 52);
            this.btnPesquisarRelatorio.TabIndex = 6;
            this.btnPesquisarRelatorio.Text = "Buscar";
            this.btnPesquisarRelatorio.UseVisualStyleBackColor = true;
            this.btnPesquisarRelatorio.Click += new System.EventHandler(this.btnPesquisarRelatorio_Click);
            // 
            // cboxRelatorios
            // 
            this.cboxRelatorios.FormattingEnabled = true;
            this.cboxRelatorios.Location = new System.Drawing.Point(9, 32);
            this.cboxRelatorios.Name = "cboxRelatorios";
            this.cboxRelatorios.Size = new System.Drawing.Size(337, 21);
            this.cboxRelatorios.TabIndex = 3;
            // 
            // cboxTipoVisualizacao
            // 
            this.cboxTipoVisualizacao.FormattingEnabled = true;
            this.cboxTipoVisualizacao.Location = new System.Drawing.Point(360, 32);
            this.cboxTipoVisualizacao.Name = "cboxTipoVisualizacao";
            this.cboxTipoVisualizacao.Size = new System.Drawing.Size(427, 21);
            this.cboxTipoVisualizacao.TabIndex = 4;
            // 
            // gboxOpcoesFiltros
            // 
            this.gboxOpcoesFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxOpcoesFiltros.Controls.Add(this.chboxEmail);
            this.gboxOpcoesFiltros.Controls.Add(this.chboxChaave);
            this.gboxOpcoesFiltros.Controls.Add(this.chboxCodigo);
            this.gboxOpcoesFiltros.Controls.Add(this.gboxData);
            this.gboxOpcoesFiltros.Controls.Add(this.chboxNome);
            this.gboxOpcoesFiltros.Location = new System.Drawing.Point(9, 59);
            this.gboxOpcoesFiltros.Name = "gboxOpcoesFiltros";
            this.gboxOpcoesFiltros.Size = new System.Drawing.Size(778, 70);
            this.gboxOpcoesFiltros.TabIndex = 2;
            this.gboxOpcoesFiltros.TabStop = false;
            this.gboxOpcoesFiltros.Text = "Pesquisar por";
            // 
            // chboxEmail
            // 
            this.chboxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chboxEmail.AutoSize = true;
            this.chboxEmail.Location = new System.Drawing.Point(272, 35);
            this.chboxEmail.Name = "chboxEmail";
            this.chboxEmail.Size = new System.Drawing.Size(51, 17);
            this.chboxEmail.TabIndex = 0;
            this.chboxEmail.Text = "Email";
            this.chboxEmail.UseVisualStyleBackColor = true;
            // 
            // chboxChaave
            // 
            this.chboxChaave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chboxChaave.AutoSize = true;
            this.chboxChaave.Location = new System.Drawing.Point(187, 35);
            this.chboxChaave.Name = "chboxChaave";
            this.chboxChaave.Size = new System.Drawing.Size(57, 17);
            this.chboxChaave.TabIndex = 0;
            this.chboxChaave.Text = "Chave";
            this.chboxChaave.UseVisualStyleBackColor = true;
            this.chboxChaave.CheckedChanged += new System.EventHandler(this.chboxChaave_CheckedChanged);
            // 
            // chboxCodigo
            // 
            this.chboxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chboxCodigo.AutoSize = true;
            this.chboxCodigo.Location = new System.Drawing.Point(100, 35);
            this.chboxCodigo.Name = "chboxCodigo";
            this.chboxCodigo.Size = new System.Drawing.Size(59, 17);
            this.chboxCodigo.TabIndex = 0;
            this.chboxCodigo.Text = "Código";
            this.chboxCodigo.UseVisualStyleBackColor = true;
            // 
            // gboxData
            // 
            this.gboxData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxData.Controls.Add(this.chboxPermiteData);
            this.gboxData.Controls.Add(this.lblInicio);
            this.gboxData.Controls.Add(this.lblFim);
            this.gboxData.Controls.Add(this.dtpInicio);
            this.gboxData.Controls.Add(this.dtpFim);
            this.gboxData.Location = new System.Drawing.Point(343, 0);
            this.gboxData.Name = "gboxData";
            this.gboxData.Size = new System.Drawing.Size(435, 70);
            this.gboxData.TabIndex = 1;
            this.gboxData.TabStop = false;
            // 
            // chboxPermiteData
            // 
            this.chboxPermiteData.AutoSize = true;
            this.chboxPermiteData.Location = new System.Drawing.Point(8, 0);
            this.chboxPermiteData.Name = "chboxPermiteData";
            this.chboxPermiteData.Size = new System.Drawing.Size(82, 17);
            this.chboxPermiteData.TabIndex = 10;
            this.chboxPermiteData.Text = "Por período";
            this.chboxPermiteData.UseVisualStyleBackColor = true;
            this.chboxPermiteData.CheckedChanged += new System.EventHandler(this.chboxPermiteData_CheckedChanged);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(20, 34);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(34, 13);
            this.lblInicio.TabIndex = 8;
            this.lblInicio.Text = "Início";
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFim.Location = new System.Drawing.Point(231, 34);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(23, 13);
            this.lblFim.TabIndex = 9;
            this.lblFim.Text = "Fim";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(60, 30);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(158, 20);
            this.dtpInicio.TabIndex = 0;
            // 
            // dtpFim
            // 
            this.dtpFim.Location = new System.Drawing.Point(260, 30);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(158, 20);
            this.dtpFim.TabIndex = 1;
            // 
            // chboxNome
            // 
            this.chboxNome.AutoSize = true;
            this.chboxNome.Location = new System.Drawing.Point(18, 35);
            this.chboxNome.Name = "chboxNome";
            this.chboxNome.Size = new System.Drawing.Size(54, 17);
            this.chboxNome.TabIndex = 0;
            this.chboxNome.Text = "Nome";
            this.chboxNome.UseVisualStyleBackColor = true;
            // 
            // rvEventos
            // 
            this.rvEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSetUsuarios";
            reportDataSource2.Value = this.usuariosBindingSource1;
            this.rvEventos.LocalReport.DataSources.Add(reportDataSource2);
            this.rvEventos.LocalReport.ReportEmbeddedResource = "ControleDeAcesso.report.Relatorio-Usuarios.rdlc";
            this.rvEventos.Location = new System.Drawing.Point(12, 219);
            this.rvEventos.Name = "rvEventos";
            this.rvEventos.ServerReport.BearerToken = null;
            this.rvEventos.Size = new System.Drawing.Size(795, 298);
            this.rvEventos.TabIndex = 1;
            // 
            // panelFundo
            // 
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(820, 529);
            this.panelFundo.TabIndex = 11;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "usuarios";
            this.usuariosBindingSource1.DataSource = this.controledeacessocfoDataSet;
            // 
            // controledeacessocfoDataSet
            // 
            this.controledeacessocfoDataSet.DataSetName = "controledeacessocfoDataSet";
            this.controledeacessocfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "eventos";
            this.eventosBindingSource.DataSource = this.controledeacessocfoDataSet;
            // 
            // eventosTableAdapter
            // 
            this.eventosTableAdapter.ClearBeforeFill = true;
            // 
            // categoriasBindingSource1
            // 
            this.categoriasBindingSource1.DataMember = "categorias";
            this.categoriasBindingSource1.DataSource = this.controledeacessocfoDataSet;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // configuracoes_de_sistemaBindingSource
            // 
            this.configuracoes_de_sistemaBindingSource.DataMember = "configuracoes_de_sistema";
            this.configuracoes_de_sistemaBindingSource.DataSource = this.controledeacessocfoDataSet;
            // 
            // configuracoesdesistemaBindingSource
            // 
            this.configuracoesdesistemaBindingSource.DataMember = "configuracoes_de_sistema";
            this.configuracoesdesistemaBindingSource.DataSource = this.controledeacessocfoDataSet;
            // 
            // configuracoes_de_sistemaTableAdapter
            // 
            this.configuracoes_de_sistemaTableAdapter.ClearBeforeFill = true;
            // 
            // ingressosBindingSource1
            // 
            this.ingressosBindingSource1.DataMember = "ingressos";
            this.ingressosBindingSource1.DataSource = this.controledeacessocfoDataSet;
            // 
            // ingressosTableAdapter
            // 
            this.ingressosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorios
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 529);
            this.Controls.Add(this.gboxPreferenciaRelatorio);
            this.Controls.Add(this.rvEventos);
            this.Controls.Add(this.panelFundo);
            this.Name = "FrmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            this.Resize += new System.EventHandler(this.FrmRelatorios_Resize);
            this.gboxPreferenciaRelatorio.ResumeLayout(false);
            this.gboxPreferenciaRelatorio.PerformLayout();
            this.gboxOpcoesFiltros.ResumeLayout(false);
            this.gboxOpcoesFiltros.PerformLayout();
            this.gboxData.ResumeLayout(false);
            this.gboxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controledeacessocfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracoes_de_sistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configuracoesdesistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingressosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxPreferenciaRelatorio;
        private System.Windows.Forms.Label lblTipoVisualizacao;
        private System.Windows.Forms.ComboBox cboxTipoVisualizacao;
        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.ComboBox cboxRelatorios;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.GroupBox gboxOpcoesFiltros;
        private System.Windows.Forms.Button btnPesquisarRelatorio;
        private System.Windows.Forms.GroupBox gboxData;
        private System.Windows.Forms.CheckBox chboxPermiteData;
        private System.Windows.Forms.CheckBox chboxEmail;
        private System.Windows.Forms.CheckBox chboxChaave;
        private System.Windows.Forms.CheckBox chboxCodigo;
        private System.Windows.Forms.CheckBox chboxNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.Label lblNome;
        private Microsoft.Reporting.WinForms.ReportViewer rvEventos;
        private controledeacessocfoDataSet controledeacessocfoDataSet;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private controledeacessocfoDataSetTableAdapters.eventosTableAdapter eventosTableAdapter;
        private System.Windows.Forms.BindingSource categoriasBindingSource1;
        private controledeacessocfoDataSetTableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.BindingSource configuracoes_de_sistemaBindingSource;
        private System.Windows.Forms.BindingSource configuracoesdesistemaBindingSource;
        private controledeacessocfoDataSetTableAdapters.configuracoes_de_sistemaTableAdapter configuracoes_de_sistemaTableAdapter;
        private System.Windows.Forms.BindingSource ingressosBindingSource1;
        private controledeacessocfoDataSetTableAdapters.ingressosTableAdapter ingressosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private controledeacessocfoDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel panelFundo;
    }
}