using ControleDeAcesso.dao;
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
    public partial class FrmRecuperacaoSenha2 : Form
    {
        private Usuario usuario = new Usuario();
        private CrudUsuario controleUsuario = new CrudUsuario();
        private int codigoVerificacao = 0;
        private int tentativas = 0;
        private FrmLogin login;

        public FrmRecuperacaoSenha2(Usuario u, int codVerific, FrmLogin login)
        {
            InitializeComponent();
            usuario = u;
            codigoVerificacao = codVerific;
            this.login = login;
            MessageBox.Show("Um email foi enviado para " + usuario.Email + ". \n Copie o código enviado e cole no campo 'Código de Verificação' na próxima tela.", "Código enviado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public FrmRecuperacaoSenha2()
        {
            InitializeComponent();

        }

        private void FrmRecuperacaoSenha_Load(object sender, EventArgs e)
        {

        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private bool validaCampos()
        {
            bool retorno = false;
            foreach (Control tb in groupBox1.Controls)
            {
                if (tb is TextBox)
                {
                    if (tb.Text != "")
                    {
                        retorno = true;
                    }
                    else
                    {
                        MessageBox.Show("O campo '" + tb.AccessibleName + "' não pode estar em branco");
                        tb.Select();
                        retorno = false;
                        break;
                    }
                }
            }
            return retorno;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (tentativas < 3)
            {
                if (validaCampos())
                {
                    if (txtConfirma.Text == txtSenha.Text)
                    {
                        if (codigoVerificacao == Int32.Parse(txtCodVerificacao.Text))
                        {
                            if (txtCodVerificacao.Text == codigoVerificacao.ToString())
                            {
                                //frmLogin login = new frmLogin();
                                //usuario = GerenciadorDeAcesso.preencherUsuario(cliente);
                                usuario.Senha = Utilitaria.criptografarSenha(txtSenha.Text);
                                controleUsuario.atualizar(usuario, (int)usuario.Id);
                                //using (var login = new Login()){}                                
                                DialogResult resul = MessageBox.Show("Senha atualizada com sucesso!", "Atualização de senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (resul.Equals(DialogResult.OK))
                                {
                                    this.Dispose();
                                    login.txtSenha.Select();
                                    login.ShowDialog();
                                }

                            }
                            else
                            {
                                tentativas++;
                                MessageBox.Show("A resposta não é essa. Você tem mais " + (3 - tentativas) + " tentativas. Digite a resposta de segurança");
                                txtCodVerificacao.Select();
                            }
                        }
                        else
                        {
                            MessageBox.Show("O código de verificação está errado!");
                            txtConfirma.Select();
                        }
                    }
                    else
                    {
                        MessageBox.Show("As senhas são diferentes. Digite a mesma senha para confirmar");
                        txtConfirma.Select();
                    }
                }
            }

            else
            {
                MessageBox.Show("Consulte o Administrador do sistema para obter ajuda.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
