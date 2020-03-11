using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAcesso.model
{
    public class Categoria
    {
        int id;
        string nome;
        ConfiguracaoDeSistema configuracoes;

        public Categoria()
        {
        }

        public Categoria(int id, string nome, ConfiguracaoDeSistema config)
        {
            this.Id = id;
            this.Nome = nome;
            this.Configuracoes = config;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public ConfiguracaoDeSistema Configuracoes { get => configuracoes; set => configuracoes = value; }
    }
}
