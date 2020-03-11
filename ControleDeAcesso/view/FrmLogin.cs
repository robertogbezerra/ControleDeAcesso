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
    public partial class FrmLogin : Form
    {
        private CrudUsuario crudUsuario = new CrudUsuario();
        Usuario usuarioBD;
        public FrmLogin()
        {
            InitializeComponent();
        }

        public void logar(string usuario, string senha)
        {
            usuarioBD = (Usuario)crudUsuario.listarUmPorNome(usuario);
            senha = util.Utilitaria.criptografarSenha(senha);
            if (usuario == usuarioBD.UserName && senha == usuarioBD.Senha)
            {
                FrmInicio inicio = new FrmInicio(usuarioBD);
                this.Hide();
                inicio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto, Por favor tente novamente!", "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
                txtUsuario.Select();
                crudUsuario = new CrudUsuario();
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            this.logar(txtUsuario.Text, txtSenha.Text);
        }

        private void lblEsqueceuSenha_Click(object sender, EventArgs e)
        {
            usuarioBD = (Usuario)crudUsuario.listarUmPorNome(txtUsuario.Text);
            if (usuarioBD.UserName.Length > 0)
            {
                using (var recuperacaoSenha = new FrmRecuperacaoSenha(usuarioBD, this))
                {
                    this.Hide();
                    recuperacaoSenha.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Informe um nome de usuário válido!", "Usuário inesistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                crudUsuario = new CrudUsuario();
            }
        }

        private void lblEsqueceuSenha_MouseMove(object sender, MouseEventArgs e)
        {
            mudaCorLink(Color.RoyalBlue, lblEsqueceuSenha);
        }

        private void mudaCorLink(Color cor, Control elemento)
        {
            elemento.ForeColor = cor;
        }

        private void lblEsqueceuSenha_MouseLeave(object sender, EventArgs e)
        {
            mudaCorLink(Color.Blue, lblEsqueceuSenha);
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtSenha.Text = "admin";
            txtUsuario.Text = "admin";
        }

    }

}
