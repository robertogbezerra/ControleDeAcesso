using ControleDeAcesso.model;
using ControleDeAcesso.util;
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
    public partial class FrmConfiguracaoSistema : Form
    {
        ConfiguracaoDeSistema config = new ConfiguracaoDeSistema();
        private string estadoAtual;
        private Array estados = Enum.GetValues(typeof(Estados.EnumEstado));
        public FrmConfiguracaoSistema()
        {
            InitializeComponent();
            cboxMostrarEmArvores.Checked = true;
            treeViewEditar.ExpandAll();
            treeViewExcluir.ExpandAll();
            treeViewInserir.ExpandAll();
            treeViewListar.ExpandAll();
        }

        private void preencherConfiguracoes(Categoria categoria)
        {
            /*Edição
            this.cboxEditarCategorias.Checked = config.preencherConfiguracoesDoSistema(categoria).EditaCategorias;
            this.cboxEditarEventos.Checked = config.preencherConfiguracoesDoSistema(categoria).EditaEventos;
            this.cboxEditarUsuario.Checked = config.preencherConfiguracoesDoSistema(categoria).EditaUsuarios;
            this.cboxEditarConfig.Checked = config.preencherConfiguracoesDoSistema(categoria).EditaConfiguracoes;
            //Exclusão
            this.cboxExcluirCategorias.Checked = config.preencherConfiguracoesDoSistema(categoria).ExcluiCategorias;
            this.cboxExcluirConfig.Checked = config.preencherConfiguracoesDoSistema(categoria).ExcluiConfiguracoes;
            this.cboxExcluirEventos.Checked = config.preencherConfiguracoesDoSistema(categoria).ExcluiEventos;
            this.cboxExcluirUsuarios.Checked = config.preencherConfiguracoesDoSistema(categoria).ExcluiUsuarios;
            //Inserção
            this.cboxInserirCategoria.Checked = config.preencherConfiguracoesDoSistema(categoria).IncluiCategorias;
            this.cboxInserirEventos.Checked = config.preencherConfiguracoesDoSistema(categoria).IncluiEventos;
            this.cboxInserirUsuario.Checked = config.preencherConfiguracoesDoSistema(categoria).IncluiUsuarios;
            this.cboxInserirConfig.Checked = config.preencherConfiguracoesDoSistema(categoria).IncluiConfiguracoes;
            //Visualização
            this.cboxVisualizarCategoria.Checked = config.preencherConfiguracoesDoSistema(categoria).VisualizaCategorias;
            this.cboxVisualizarConfig.Checked = config.preencherConfiguracoesDoSistema(categoria).VisualizaConfiguracoes;
            this.cboxVisualizarEventos.Checked = config.preencherConfiguracoesDoSistema(categoria).VisualizaEventos;
            this.cboxVisualizarGraficos.Checked = config.preencherConfiguracoesDoSistema(categoria).VisualizaGraficos;
            this.cboxVisualizarRelatorios.Checked = config.preencherConfiguracoesDoSistema(categoria).VisualizaRelatorios;
            this.cboxVisualizarUsuarios.Checked = config.preencherConfiguracoesDoSistema(categoria).VisualizaUsuarios;
            */


        }

        private void marcarDesmarcarrNos(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode no in treeNode.Nodes)
            {
                no.Checked = nodeChecked;
                if (no.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.marcarDesmarcarrNos(no, nodeChecked);
                }
            }
        }

        private void treeViewInserir_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    this.marcarDesmarcarrNos(e.Node, e.Node.Checked);
                }
            }
        }

        private void cboxMostrarEmArvores_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxMostrarEmArvores.Checked)
            {
                exibeArvores(true, gboxVisualizar);
                exibeArvores(true, gboxEditar);
                exibeArvores(true, gboxExcluir);
                exibeArvores(true, gboxInserir);
            }
            else
            {
                exibeArvores(false, gboxVisualizar);
                exibeArvores(false, gboxEditar);
                exibeArvores(false, gboxExcluir);
                exibeArvores(false, gboxInserir);
            }
        }

        private void exibeArvores(bool exibe, Control gbox)
        {
            foreach (Control tv in gbox.Controls)
            {
                if (tv is TreeView)
                {
                    tv.Visible = exibe;
                }
            }
        }

        private void prepararParaIncluirEditar(string modo)
        {
            foreach (Enum acao in estados)
            {
                if (acao.ToString() == modo && estadoAtual != modo)
                {
                    estadoAtual = modo;
                }
            }
            btnAddConfig.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            prepararParaIncluirEditar(Estados.EnumEstado.Inserir.ToString());
        }

        static void printArray(string i)
        {
            Console.WriteLine(i);
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            habilitaDesabilitaAcoes(true);
            MessageBox.Show("Tem certeza que deseja " + estadoAtual + " estas configurações?", estadoAtual + " Configurações",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void habilitaDesabilitaAcoes(bool habilita)
        {
            foreach (Button botao in gboxAcoes.Controls)
            {
                botao.Enabled = habilita;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza que deseja CANCELAR esta operação?", "Cancelamento",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            estadoAtual = string.Empty;
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            prepararParaIncluirEditar(Estados.EnumEstado.Editar.ToString());
        }

        private void FrmConfiguracaoSistema_Load(object sender, EventArgs e)
        {

        }
    }
}
