using System;

namespace ControleDeAcesso.model
{
    public class Usuario
    {
        private long? id = 0;
        private string userName = "";
        private string senha = "";
        private int categoria = 0;
        private string email = ""; 
        private int codVerificacao = 0;
        private string pergunta = "";
        private string resposta = "";

        public Usuario() { }

        public Usuario(long? id, string usuario, string senha, int categoria, string email, int codVerificacao, string pergunta, string resposta)
        {
            this.Id = id;
            this.UserName = usuario;
            this.Senha = senha;
            this.Email = email;
            this.Categoria = categoria;
            this.CodVerificacao = codVerificacao;
            this.Pergunta = pergunta;
            this.Resposta = resposta;
        }

        public long? Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public string Email { get => email; set => email = value; }
        public int CodVerificacao { get => codVerificacao; set => codVerificacao = value; }
        public string Pergunta { get => pergunta; set => pergunta = value; }
        public string Resposta { get => resposta; set => resposta = value; }
    }
}
