using ControleDeAcesso.dao;
using ControleDeAcesso.model;
using System;
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
    public partial class FrmInicio : Form
    {
        Usuario usuarioDoSistema;

        public FrmInicio() { }

        public FrmInicio(Usuario user)
        {
            InitializeComponent();
            usuarioDoSistema = user;
        }

        private void tsMenuSobreIcones_Click(object sender, EventArgs e)
        {
            FrmSobreIcones sobreIcones = new FrmSobreIcones();
            sobreIcones.ShowDialog();
        }

        private void tsMenuMonitorEvento_Click(object sender, EventArgs e)
        {
            FrmMonitor monitor = new FrmMonitor();
            monitor.ShowDialog();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorios frmRelatorioEventos = new FrmRelatorios(this.usuarioDoSistema);
            frmRelatorioEventos.ShowDialog();
        }

        private void tsMenuRelatorioEventos_Click(object sender, EventArgs e)
        {
            FrmRelatorios frmRelatorioEventos = new FrmRelatorios(this.usuarioDoSistema);
            frmRelatorioEventos.ShowDialog();
        }

        private void tsMenuConfig_Click(object sender, EventArgs e)
        {
            FrmConfiguracaoSistema frmConfiguracao = new FrmConfiguracaoSistema();
            frmConfiguracao.ShowDialog();
        }

        private void tsMenuGrafIngressosPorEvento_Click(object sender, EventArgs e)
        {
            using (FrmGraficoEventos graficoPublico = new FrmGraficoEventos())
            {
                graficoPublico.ShowDialog();
            }

        }

        private void frmGestorDeEventos_Load(object sender, EventArgs e)
        {
            CrudEvento eventos = new CrudEvento();
            this.status.Text += usuarioDoSistema.UserName;
            //CrudUsuario c = new CrudUsuario();
            //usuarioDoSistema = (Usuario) c.listarPorId(1);
            //Usuario usuarioTeste = c.inserir(usuarioDoSistema);
        }

        private void tsMenuNovoUser_Click(object sender, EventArgs e)
        {
            using (FrmCadastroUsuario cadastroUsuario = new FrmCadastroUsuario())
            {
                cadastroUsuario.ShowDialog();
            }
        }
    }
}
