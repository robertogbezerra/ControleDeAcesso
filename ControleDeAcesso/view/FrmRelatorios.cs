using ControleDeAcesso.dao;
using ControleDeAcesso.model;
using ControleDeAcesso.report;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeAcesso.view
{
    public partial class FrmRelatorios : Form
    {
        private Usuario usuario = new Usuario();
        private int alturaReportViwer;
        private int larguraReportViwer;

        public Usuario Usuario { get => usuario; set => usuario = value; }

        public FrmRelatorios()
        {
            InitializeComponent();

        }
        public FrmRelatorios(Usuario usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
            alturaReportViwer = (this.Height - this.gboxPreferenciaRelatorio.Height) - 25;
            larguraReportViwer = rvEventos.LocalReport.GetDefaultPageSettings().PaperSize.Width;

        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controledeacessocfoDataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.controledeacessocfoDataSet.usuarios);
            // TODO: esta linha de código carrega dados na tabela 'controledeacessocfoDataSet.ingressos'. Você pode movê-la ou removê-la conforme necessário.
            this.ingressosTableAdapter.Fill(this.controledeacessocfoDataSet.ingressos);
            // TODO: esta linha de código carrega dados na tabela 'controledeacessocfoDataSet.configuracoes_de_sistema'. Você pode movê-la ou removê-la conforme necessário.
            this.configuracoes_de_sistemaTableAdapter.Fill(this.controledeacessocfoDataSet.configuracoes_de_sistema);
            // TODO: esta linha de código carrega dados na tabela 'controledeacessocfoDataSet.categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriasTableAdapter.Fill(this.controledeacessocfoDataSet.categorias);
            // TODO: esta linha de código carrega dados na tabela 'controledeacessocfoDataSet.eventos'. Você pode movê-la ou removê-la conforme necessário.
            this.eventosTableAdapter.Fill(this.controledeacessocfoDataSet.eventos);
            this.rvEventos.ZoomMode = ZoomMode.PageWidth;
            preencherCboxRelatorios();
            iniciarDAteTimePicker();
            habilitaDesabilitaDatas(chboxPermiteData);
            this.rvEventos.RefreshReport();
        }

        private void preencherCboxRelatorios()
        {
            this.cboxRelatorios.Items.Add(GerenteReportImplement.reportEventos);
            this.cboxRelatorios.Items.Add(GerenteReportImplement.reportCategorias);
            this.cboxRelatorios.Items.Add(GerenteReportImplement.reportConfiguracoes);
            this.cboxRelatorios.Items.Add(GerenteReportImplement.reportIngressos);
            this.cboxRelatorios.Items.Add(GerenteReportImplement.reportUsuarios);
        }

        private void iniciarDAteTimePicker()
        {
            dtpInicio.CustomFormat = "dd /MM / yyyy";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpFim.CustomFormat = "dd / MM / yyyy";
            dtpFim.Format = DateTimePickerFormat.Custom;
        }

        private void rvEventos_PageSettingsChanged(object sender, EventArgs e)
        {
            configurarVisualizacao();
        }

        private void configurarVisualizacao()
        {
            string report = this.rvEventos.LocalReport.ReportEmbeddedResource;
            this.rvEventos.ZoomMode = ZoomMode.PageWidth;
            if (this.rvEventos.PrinterSettings.DefaultPageSettings.Landscape)
            {
                this.rvEventos.ZoomMode = ZoomMode.Percent;
                this.rvEventos.ZoomPercent = 100;
                report = report.Replace(".rdlc", "Land.rdlc");
            }
            else if (this.rvEventos.DisplayMode == DisplayMode.PrintLayout)
            {
                this.rvEventos.ZoomMode = ZoomMode.Percent;
                this.rvEventos.ZoomPercent = 100;
                report = "ControleDeAcessoCFO.report.RelatorioEventos.rdlc";
            }
            else
            {
                this.rvEventos.ZoomMode = ZoomMode.Percent;
                this.rvEventos.ZoomPercent = 100;
                report = report.Replace(".rdlc", "Land.rdlc");
            }
            this.rvEventos.LocalReport.ReportEmbeddedResource = report;
            rvEventos.RefreshReport();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //selecionarRelatorio();
        }

        private ArrayList selecionarRelatorio(ICrud tabela, string relatorio)
        {
            return tabela.listarTodos();
            this.rvEventos.LocalReport.ReportEmbeddedResource = relatorio;
            this.rvEventos.ZoomMode = ZoomMode.PageWidth;
            rvEventos.RefreshReport();
        }

        private void EscolherRelatorio(string relatorio)
        {
            GerenteReportImplement gerenteReport = new GerenteReportImplement();
            switch (relatorio)
            {
                case GerenteReportImplement.reportEventos:
                    gerenteReport.igerenteReport = new GerenteReportEventos();
                    gerenteReport.igerenteReport.EscolherReportParaExibir(rvEventos, relatorio, this.eventosBindingSource);
                    break;
                case GerenteReportImplement.reportUsuarios:
                    gerenteReport.igerenteReport = new GerenteReportUsuario();
                    gerenteReport.igerenteReport.EscolherReportParaExibir(rvEventos, relatorio, this.usuariosBindingSource1);
                    break;
                case GerenteReportImplement.reportCategorias:
                    gerenteReport.igerenteReport = new GerenteReportCategoria();
                    gerenteReport.igerenteReport.EscolherReportParaExibir(rvEventos, relatorio, this.categoriasBindingSource1);
                    break;
                case GerenteReportImplement.reportConfiguracoes:
                    gerenteReport.igerenteReport = new GerenteReportConfiguracoes();
                    gerenteReport.igerenteReport.EscolherReportParaExibir(rvEventos, relatorio, this.configuracoes_de_sistemaBindingSource);
                    break;
                case GerenteReportImplement.reportIngressos:
                    gerenteReport.igerenteReport = new GerenteReportIngressos();
                    gerenteReport.igerenteReport.EscolherReportParaExibir(rvEventos, relatorio, this.ingressosBindingSource1);
                    break;
            }
            rvEventos.RefreshReport();
            CalcularTamanhoPosicaoReportViwer();
        }

        private void CalcularTamanhoPosicaoReportViwer()
        {
            this.rvEventos.Size = new System.Drawing.Size(larguraReportViwer, alturaReportViwer);
            this.rvEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            int pontoCentral = (this.Width - rvEventos.Width);
            rvEventos.Location = new System.Drawing.Point(pontoCentral / 2, gboxPreferenciaRelatorio.Height + 10);
        }

        private void habilitaDesabilitaDatas(object sender)
        {
            CheckBox checkBox = new CheckBox();
            checkBox = (CheckBox)sender;
            dtpInicio.Enabled = checkBox.Checked;
            dtpFim.Enabled = checkBox.Checked;
        }

        private void btnPesquisarRelatorio_Click(object sender, EventArgs e)
        {
            EscolherRelatorio(cboxRelatorios.Text);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void chboxPermiteData_CheckedChanged(object sender, EventArgs e)
        {
            habilitaDesabilitaDatas(sender);
        }

        private void chboxChaave_CheckedChanged(object sender, EventArgs e)
        {
            habilitaDesabilitaCheck(sender);
        }

        private void habilitaDesabilitaCheck(object sender)
        {
        }

        private void FrmRelatorios_Resize(object sender, EventArgs e)
        {
            CalcularTamanhoPosicaoReportViwer();
        }
    }
}
