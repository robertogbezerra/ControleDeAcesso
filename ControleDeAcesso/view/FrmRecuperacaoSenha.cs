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
    public partial class FrmRecuperacaoSenha : Form
    {
        private Usuario usuario = new Usuario();
        private CrudUsuario controleUsuario = new CrudUsuario();
        private FrmLogin login;
        private int codigoVerificacao = 0;
        const string melhorAmigo = "Qual o nome do seu melhor amigo";
        const string cidadeNatal = "Qual a cidade que você nasceu";
        const string nomeDoAvo = "Qual o nome do seu avô";
        const string segundoNomeDaMae = "Qual o segundo nome da sua mãe";
        const string nomeDaNamorada = "Qual o segundo nome da sua primeira namorada";

        public FrmRecuperacaoSenha()
        {
            InitializeComponent();
        }

        public FrmRecuperacaoSenha(Usuario usuario, FrmLogin login)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.login = login;
        }
        private void frmRecuperacaoSenha_Load(object sender, EventArgs e)
        {
            listarPerguntas();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }
        public static string gerarCodigo()
        {
            string guid = Guid.NewGuid().ToString().Replace("-", "");
            string letras = "abcdefghijklmnopqrstuvwxyz";
            Random numAleatorio = new Random();
            Int32 tamanhoSenha = numAleatorio.Next(8);

            string senha = "";
            string temp = "";
            while (senha.Length < 8)
            {
                for (Int32 i = 0; i <= 8; i++)
                {
                    temp = guid.Substring(numAleatorio.Next(1, guid.Length), 1);
                    for (int j = 0; j < letras.Length; j++)
                    {
                        if (temp == letras[j].ToString())
                        {
                            temp = "";
                        }
                    }
                    senha += temp;
                    if (senha.Length == 8)
                    {
                        break;
                    }
                }
            }
            return senha;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            usuario = (Usuario)controleUsuario.listarUmPorNome(usuario.UserName);
            codigoVerificacao = Int32.Parse(gerarCodigo());
            int tentativas = 0;
            if (tentativas < 3)
            {
                if (cboxPerguntas.Text.Length > 0 && cboxPerguntas.Text != "Selecione uma pergunta")
                {
                    if (txtResposta.Text.Length > 0)
                    {
                        if (txtResposta.Text == usuario.Resposta)
                        {
                            usuario.CodVerificacao = codigoVerificacao;
                            controleUsuario.atualizar(usuario, (int)usuario.Id);
                            Utilitaria.enviarEmailRecuperacao(usuario.Email, codigoVerificacao);
                            FrmRecuperacaoSenha2 recuparacao2 = new FrmRecuperacaoSenha2(usuario, codigoVerificacao, login);
                            this.Hide();
                            this.Dispose();
                            recuparacao2.ShowDialog();
                        }
                        else
                        {
                            tentativas++;
                            MessageBox.Show("A resposta não é essa. Você tem mais " + (3 - tentativas) + " tentativas. Digite a resposta de segurança correta", "Resposta incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            controleUsuario = new CrudUsuario();
                            txtResposta.Clear();
                            txtResposta.Select();
                        }

                    }
                    else
                    {
                        MessageBox.Show("O campo 'Resposta' não pode estar em branco", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        controleUsuario = new CrudUsuario();
                        txtResposta.Select();
                    }
                }
                else
                {
                    MessageBox.Show("Escolha a pergunta de segurança correta", "Escolha da pergunta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    controleUsuario = new CrudUsuario();
                    cboxPerguntas.Select();
                }
            }
            else
            {
                MessageBox.Show("Por questão de segurança seu acesso será bloqueado. Consulte o suporte para obter ajuda!", "Suas tentativas acabaram", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void listarPerguntas()
        {
            List<String> perguntas = new List<String>();
            perguntas.AddRange(new string[] { melhorAmigo, cidadeNatal, nomeDoAvo, nomeDaNamorada, segundoNomeDaMae });

            cboxPerguntas.Items.Add("Selecione uma pergunta");
            foreach (string pergunta in perguntas)
            {
                cboxPerguntas.Items.Add(pergunta);
                cboxPerguntas.SelectedItem = cboxPerguntas.Items[0];
            }
        }

        private void cboxPerguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
