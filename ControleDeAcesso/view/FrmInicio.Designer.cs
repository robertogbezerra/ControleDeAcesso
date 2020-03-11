namespace ControleDeAcesso.view
{ 
    partial class FrmInicio
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsMenuAplicacao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuDocumentacao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuNovoEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuNovoUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuNovoBilhete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuBuscaUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuBuscaEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAddEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuMonitorEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAtualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAtualizarUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAtualizarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuExcluirUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuExcluirEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuRelAvisos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuRelatorioEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuRelatorioIngressos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuRelIngressosPorMinuto = new System.Windows.Forms.ToolStripMenuItem();
            this.ingressosPorEventoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuRelIngressosPorTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.errosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuRelAvisosPorEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuRelAvisosPorTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuGraficos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuGrafIngressosPorMinutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuGrafIngressosPorEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuGrafIngressosPorTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSobreSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSobreIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuAplicacao,
            this.tsMenuNovo,
            this.tsMenuBuscar,
            this.tsMenuEvento,
            this.tsMenuAtualizar,
            this.tsMenuExcluir,
            this.tsMenuRelAvisos,
            this.tsMenuGraficos,
            this.tsMenuSobre});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1350, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // tsMenuAplicacao
            // 
            this.tsMenuAplicacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuConfig,
            this.tsMenuDocumentacao,
            this.tsMenuSair});
            this.tsMenuAplicacao.Name = "tsMenuAplicacao";
            this.tsMenuAplicacao.Size = new System.Drawing.Size(71, 20);
            this.tsMenuAplicacao.Text = "Aplicacao";
            // 
            // tsMenuConfig
            // 
            this.tsMenuConfig.Name = "tsMenuConfig";
            this.tsMenuConfig.Size = new System.Drawing.Size(155, 22);
            this.tsMenuConfig.Text = "Configuração";
            this.tsMenuConfig.Click += new System.EventHandler(this.tsMenuConfig_Click);
            // 
            // tsMenuDocumentacao
            // 
            this.tsMenuDocumentacao.Name = "tsMenuDocumentacao";
            this.tsMenuDocumentacao.Size = new System.Drawing.Size(155, 22);
            this.tsMenuDocumentacao.Text = "Documentação";
            // 
            // tsMenuSair
            // 
            this.tsMenuSair.Name = "tsMenuSair";
            this.tsMenuSair.Size = new System.Drawing.Size(155, 22);
            this.tsMenuSair.Text = "Sair";
            // 
            // tsMenuNovo
            // 
            this.tsMenuNovo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuNovoEvento,
            this.tsMenuNovoUser,
            this.tsMenuNovoBilhete});
            this.tsMenuNovo.Name = "tsMenuNovo";
            this.tsMenuNovo.Size = new System.Drawing.Size(48, 20);
            this.tsMenuNovo.Text = "Novo";
            // 
            // tsMenuNovoEvento
            // 
            this.tsMenuNovoEvento.Name = "tsMenuNovoEvento";
            this.tsMenuNovoEvento.Size = new System.Drawing.Size(180, 22);
            this.tsMenuNovoEvento.Text = "Evento";
            // 
            // tsMenuNovoUser
            // 
            this.tsMenuNovoUser.Name = "tsMenuNovoUser";
            this.tsMenuNovoUser.Size = new System.Drawing.Size(180, 22);
            this.tsMenuNovoUser.Text = "Usuário";
            this.tsMenuNovoUser.Click += new System.EventHandler(this.tsMenuNovoUser_Click);
            // 
            // tsMenuNovoBilhete
            // 
            this.tsMenuNovoBilhete.Name = "tsMenuNovoBilhete";
            this.tsMenuNovoBilhete.Size = new System.Drawing.Size(180, 22);
            this.tsMenuNovoBilhete.Text = "Bilhete";
            // 
            // tsMenuBuscar
            // 
            this.tsMenuBuscar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuBuscaUser,
            this.tsMenuBuscaEvento});
            this.tsMenuBuscar.Name = "tsMenuBuscar";
            this.tsMenuBuscar.Size = new System.Drawing.Size(54, 20);
            this.tsMenuBuscar.Text = "Buscar";
            // 
            // tsMenuBuscaUser
            // 
            this.tsMenuBuscaUser.Name = "tsMenuBuscaUser";
            this.tsMenuBuscaUser.Size = new System.Drawing.Size(114, 22);
            this.tsMenuBuscaUser.Text = "Usuário";
            // 
            // tsMenuBuscaEvento
            // 
            this.tsMenuBuscaEvento.Name = "tsMenuBuscaEvento";
            this.tsMenuBuscaEvento.Size = new System.Drawing.Size(114, 22);
            this.tsMenuBuscaEvento.Text = "Evento";
            // 
            // tsMenuEvento
            // 
            this.tsMenuEvento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuAddEvento,
            this.tsMenuMonitorEvento});
            this.tsMenuEvento.Name = "tsMenuEvento";
            this.tsMenuEvento.Size = new System.Drawing.Size(60, 20);
            this.tsMenuEvento.Text = "Eventos";
            // 
            // tsMenuAddEvento
            // 
            this.tsMenuAddEvento.Name = "tsMenuAddEvento";
            this.tsMenuAddEvento.Size = new System.Drawing.Size(166, 22);
            this.tsMenuAddEvento.Text = "Novo Evento";
            // 
            // tsMenuMonitorEvento
            // 
            this.tsMenuMonitorEvento.Name = "tsMenuMonitorEvento";
            this.tsMenuMonitorEvento.Size = new System.Drawing.Size(166, 22);
            this.tsMenuMonitorEvento.Text = "Monitorar Evento";
            this.tsMenuMonitorEvento.Click += new System.EventHandler(this.tsMenuMonitorEvento_Click);
            // 
            // tsMenuAtualizar
            // 
            this.tsMenuAtualizar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuAtualizarUser,
            this.tsMenuAtualizarEvento});
            this.tsMenuAtualizar.Name = "tsMenuAtualizar";
            this.tsMenuAtualizar.Size = new System.Drawing.Size(65, 20);
            this.tsMenuAtualizar.Text = "Atualizar";
            // 
            // tsMenuAtualizarUser
            // 
            this.tsMenuAtualizarUser.Name = "tsMenuAtualizarUser";
            this.tsMenuAtualizarUser.Size = new System.Drawing.Size(114, 22);
            this.tsMenuAtualizarUser.Text = "Usuário";
            // 
            // tsMenuAtualizarEvento
            // 
            this.tsMenuAtualizarEvento.Name = "tsMenuAtualizarEvento";
            this.tsMenuAtualizarEvento.Size = new System.Drawing.Size(114, 22);
            this.tsMenuAtualizarEvento.Text = "Evento";
            // 
            // tsMenuExcluir
            // 
            this.tsMenuExcluir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuExcluirUser,
            this.tsMenuExcluirEvento});
            this.tsMenuExcluir.Name = "tsMenuExcluir";
            this.tsMenuExcluir.Size = new System.Drawing.Size(54, 20);
            this.tsMenuExcluir.Text = "Excluir";
            // 
            // tsMenuExcluirUser
            // 
            this.tsMenuExcluirUser.Name = "tsMenuExcluirUser";
            this.tsMenuExcluirUser.Size = new System.Drawing.Size(114, 22);
            this.tsMenuExcluirUser.Text = "Usuário";
            // 
            // tsMenuExcluirEvento
            // 
            this.tsMenuExcluirEvento.Name = "tsMenuExcluirEvento";
            this.tsMenuExcluirEvento.Size = new System.Drawing.Size(114, 22);
            this.tsMenuExcluirEvento.Text = "Evento";
            // 
            // tsMenuRelAvisos
            // 
            this.tsMenuRelAvisos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuRelatorioEventos,
            this.tsMenuRelatorioIngressos,
            this.errosToolStripMenuItem});
            this.tsMenuRelAvisos.Name = "tsMenuRelAvisos";
            this.tsMenuRelAvisos.Size = new System.Drawing.Size(71, 20);
            this.tsMenuRelAvisos.Text = "Relatórios";
            // 
            // tsMenuRelatorioEventos
            // 
            this.tsMenuRelatorioEventos.Name = "tsMenuRelatorioEventos";
            this.tsMenuRelatorioEventos.Size = new System.Drawing.Size(123, 22);
            this.tsMenuRelatorioEventos.Text = "Eventos";
            this.tsMenuRelatorioEventos.Click += new System.EventHandler(this.tsMenuRelatorioEventos_Click);
            // 
            // tsMenuRelatorioIngressos
            // 
            this.tsMenuRelatorioIngressos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuRelIngressosPorMinuto,
            this.ingressosPorEventoToolStripMenuItem1,
            this.tsMenuRelIngressosPorTipo});
            this.tsMenuRelatorioIngressos.Name = "tsMenuRelatorioIngressos";
            this.tsMenuRelatorioIngressos.Size = new System.Drawing.Size(123, 22);
            this.tsMenuRelatorioIngressos.Text = "Ingressos";
            // 
            // tsMenuRelIngressosPorMinuto
            // 
            this.tsMenuRelIngressosPorMinuto.Name = "tsMenuRelIngressosPorMinuto";
            this.tsMenuRelIngressosPorMinuto.Size = new System.Drawing.Size(186, 22);
            this.tsMenuRelIngressosPorMinuto.Text = "Ingressos por Minuto";
            // 
            // ingressosPorEventoToolStripMenuItem1
            // 
            this.ingressosPorEventoToolStripMenuItem1.Name = "ingressosPorEventoToolStripMenuItem1";
            this.ingressosPorEventoToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.ingressosPorEventoToolStripMenuItem1.Text = "Ingressos por Evento";
            // 
            // tsMenuRelIngressosPorTipo
            // 
            this.tsMenuRelIngressosPorTipo.Name = "tsMenuRelIngressosPorTipo";
            this.tsMenuRelIngressosPorTipo.Size = new System.Drawing.Size(186, 22);
            this.tsMenuRelIngressosPorTipo.Text = "Ingressos por Tipo";
            // 
            // errosToolStripMenuItem
            // 
            this.errosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuRelAvisosPorEvento,
            this.tsMenuRelAvisosPorTipo});
            this.errosToolStripMenuItem.Name = "errosToolStripMenuItem";
            this.errosToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.errosToolStripMenuItem.Text = "Avisos";
            // 
            // tsMenuRelAvisosPorEvento
            // 
            this.tsMenuRelAvisosPorEvento.Name = "tsMenuRelAvisosPorEvento";
            this.tsMenuRelAvisosPorEvento.Size = new System.Drawing.Size(168, 22);
            this.tsMenuRelAvisosPorEvento.Text = "Avisos por Evento";
            // 
            // tsMenuRelAvisosPorTipo
            // 
            this.tsMenuRelAvisosPorTipo.Name = "tsMenuRelAvisosPorTipo";
            this.tsMenuRelAvisosPorTipo.Size = new System.Drawing.Size(168, 22);
            this.tsMenuRelAvisosPorTipo.Text = "Avisos por tipo";
            // 
            // tsMenuGraficos
            // 
            this.tsMenuGraficos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuGrafIngressosPorMinutos,
            this.tsMenuGrafIngressosPorEvento,
            this.tsMenuGrafIngressosPorTipo});
            this.tsMenuGraficos.Name = "tsMenuGraficos";
            this.tsMenuGraficos.Size = new System.Drawing.Size(62, 20);
            this.tsMenuGraficos.Text = "Gráficos";
            // 
            // tsMenuGrafIngressosPorMinutos
            // 
            this.tsMenuGrafIngressosPorMinutos.Name = "tsMenuGrafIngressosPorMinutos";
            this.tsMenuGrafIngressosPorMinutos.Size = new System.Drawing.Size(191, 22);
            this.tsMenuGrafIngressosPorMinutos.Text = "Ingressos por minutos";
            // 
            // tsMenuGrafIngressosPorEvento
            // 
            this.tsMenuGrafIngressosPorEvento.Name = "tsMenuGrafIngressosPorEvento";
            this.tsMenuGrafIngressosPorEvento.Size = new System.Drawing.Size(191, 22);
            this.tsMenuGrafIngressosPorEvento.Text = "Ingressos por Evento";
            this.tsMenuGrafIngressosPorEvento.Click += new System.EventHandler(this.tsMenuGrafIngressosPorEvento_Click);
            // 
            // tsMenuGrafIngressosPorTipo
            // 
            this.tsMenuGrafIngressosPorTipo.Name = "tsMenuGrafIngressosPorTipo";
            this.tsMenuGrafIngressosPorTipo.Size = new System.Drawing.Size(191, 22);
            this.tsMenuGrafIngressosPorTipo.Text = "Ingressos por Tipo";
            // 
            // tsMenuSobre
            // 
            this.tsMenuSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuSobreSistema,
            this.tsMenuSobreIcones});
            this.tsMenuSobre.Name = "tsMenuSobre";
            this.tsMenuSobre.Size = new System.Drawing.Size(49, 20);
            this.tsMenuSobre.Text = "Sobre";
            // 
            // tsMenuSobreSistema
            // 
            this.tsMenuSobreSistema.Name = "tsMenuSobreSistema";
            this.tsMenuSobreSistema.Size = new System.Drawing.Size(177, 22);
            this.tsMenuSobreSistema.Text = "Sistema";
            // 
            // tsMenuSobreIcones
            // 
            this.tsMenuSobreIcones.Name = "tsMenuSobreIcones";
            this.tsMenuSobreIcones.Size = new System.Drawing.Size(177, 22);
            this.tsMenuSobreIcones.Text = "Direitos de Imagem";
            this.tsMenuSobreIcones.Click += new System.EventHandler(this.tsMenuSobreIcones_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 17);
            this.status.Text = "Usuario: ";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.status.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ControleDeAcesso.Properties.Resources.monitor_opacity_50_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 705);
            this.panel1.TabIndex = 1;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPrincipal);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Eventos - CFO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGestorDeEventos_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAplicacao;
        private System.Windows.Forms.ToolStripMenuItem tsMenuConfig;
        private System.Windows.Forms.ToolStripMenuItem tsMenuDocumentacao;
        private System.Windows.Forms.ToolStripMenuItem tsMenuNovo;
        private System.Windows.Forms.ToolStripMenuItem tsMenuEvento;
        private System.Windows.Forms.ToolStripMenuItem tsMenuNovoEvento;
        private System.Windows.Forms.ToolStripMenuItem tsMenuNovoUser;
        private System.Windows.Forms.ToolStripMenuItem tsMenuMonitorEvento;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddEvento;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSair;
        private System.Windows.Forms.ToolStripMenuItem tsMenuNovoBilhete;
        private System.Windows.Forms.ToolStripMenuItem tsMenuBuscar;
        private System.Windows.Forms.ToolStripMenuItem tsMenuBuscaUser;
        private System.Windows.Forms.ToolStripMenuItem tsMenuBuscaEvento;
        private System.Windows.Forms.ToolStripMenuItem tsMenuExcluir;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAtualizar;
        private System.Windows.Forms.ToolStripMenuItem tsMenuExcluirUser;
        private System.Windows.Forms.ToolStripMenuItem tsMenuExcluirEvento;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAtualizarEvento;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAtualizarUser;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSobre;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSobreSistema;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSobreIcones;
        private System.Windows.Forms.ToolStripMenuItem tsMenuRelAvisos;
        private System.Windows.Forms.ToolStripMenuItem tsMenuRelatorioEventos;
        private System.Windows.Forms.ToolStripMenuItem tsMenuRelatorioIngressos;
        private System.Windows.Forms.ToolStripMenuItem tsMenuRelIngressosPorMinuto;
        private System.Windows.Forms.ToolStripMenuItem ingressosPorEventoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuGraficos;
        private System.Windows.Forms.ToolStripMenuItem tsMenuGrafIngressosPorMinutos;
        private System.Windows.Forms.ToolStripMenuItem tsMenuGrafIngressosPorEvento;
        private System.Windows.Forms.ToolStripMenuItem tsMenuGrafIngressosPorTipo;
        private System.Windows.Forms.ToolStripMenuItem tsMenuRelIngressosPorTipo;
        private System.Windows.Forms.ToolStripMenuItem errosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuRelAvisosPorEvento;
        private System.Windows.Forms.ToolStripMenuItem tsMenuRelAvisosPorTipo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Panel panel1;
    }
}