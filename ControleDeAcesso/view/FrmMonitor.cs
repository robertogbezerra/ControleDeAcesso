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
    public partial class FrmMonitor : Form
    {
        public FrmMonitor()
        {
            InitializeComponent();
        }

        private void FrmMonitor_Load(object sender, EventArgs e)
        {
            listarAnos();
        }

        private void listarAnos()
        {
            cboxAno.Items.Add("Selecione um ano");

            for (int i = 0; i < 20; i++)
            {
                cboxAno.Items.Add((DateTime.Now.Year + 10) + i);
            }
            cboxAno.SelectedItem = cboxAno.Items[0];
        }

        private void checkBoxPartidaAtual_CheckedChanged(object sender, EventArgs e)
        {
            habilitaDesabilitaPesquisa();
        }

        private void habilitaDesabilitaPesquisa()
        {

            foreach (Control item in gboxEvento.Controls)
            {
                if (item is ComboBox)
                {
                    if (item.Enabled)
                        item.Enabled = false;
                    else
                        item.Enabled = true;
                }

            }
        }

        private void pesquisarTorneio(int ano)
        {
            cboxTorneio.Items.Clear();
            cboxTorneio.Text = "";
            List<Evento> lista = Evento.listarEventos();
            foreach (var item in lista)
            {
                if (int.Parse(item.Data.Year.ToString()) == ano)
                {
                    cboxTorneio.Items.Add(item.Descricao);
                }
            }
        }

        private void pesquisarEvento(string descricao)
        {
            cboxEvento.Items.Clear();
            cboxEvento.Text = "";
            List<Evento> lista = Evento.listarEventos();
            foreach (var item in lista)
            {
                if (item.Descricao == descricao)
                {
                    cboxEvento.Items.Add(item.Descricao + " " + item.Data);
                }
            }
        }

        private void cboxTorneio_TextChanged(object sender, EventArgs e)
        {
            if (cboxTorneio.SelectedItem != "" && cboxTorneio.SelectedItem != null)
            {
                pesquisarEvento(cboxTorneio.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Escolha um Torneio");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            checarAno();
            this.pictureBoxMonitor.Image = global::ControleDeAcesso.Properties.Resources.monitor_sem_rel;
            this.dataGridAlarmes.Visible = true;
        }

        private void checarAno()
        {
            if (cboxAno.SelectedItem != "Selecione um ano" && cboxAno.SelectedItem != null)
            {
                pesquisarTorneio(int.Parse(cboxAno.SelectedItem.ToString()));
            }
            else
            {
                MessageBox.Show("Escolha um ano");
            }
        }
    }
}
