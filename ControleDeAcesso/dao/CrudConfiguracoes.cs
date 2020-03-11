using ControleDeAcesso.model;
using Devart.Data.MySql;
using System;
using System.Collections;
using System.Text;

namespace ControleDeAcesso.dao
{
    class CrudConfiguracoes: CrudImplement, ICrud
    {
        ConfiguracaoDeSistema configuracao;
        ConfiguracaoDeSistema configuracaoRetorno = new ConfiguracaoDeSistema();

        public void atualizar(object obj, int id)
        {
            throw new NotImplementedException();
        }

        public void excluir(int id)
        {
            throw new NotImplementedException();
        }

        public int inserir(object obj, string tableName, tipoConsulta tipoConsulta, MySqlParameter[] parametrosWhere)
        {
            configuracao = (ConfiguracaoDeSistema)obj;
            ListarParams(configuracao);
            comando.CommandText = "INSERT INTO configuracaos (descricao, insereUsuarios, insereEventos, insereIngressos, insereConfiguracoes, editaUsuarios," +
                "config, editaEventos, editaIngressos, editaConfiguracoes, editaCategorias, excluiUsuarios, excluiEventos, excluiIngressos" +
                "excluiConfiguracoes, excluiCategorias, visualizaUsuarios, visualizaEventos, visualizaIngressos, visualizaConfiguracoes" +
                "visualizaCategorias, visualizaGraficos, visualizaRelatorios, visualizaMonitor, imprimeRelatorios) " +
                "VALUES (@descricao, @insereUsuarios, @insereEventos, @insereIngressos, @insereConfiguracoes, @insereCategorias, @editaUsuarios, " +
                "@editaEventos, @editaIngressos, @editaConfiguracoes, @editaCategorias, @excluiUsuarios, @excluiEventos, @excluiIngressos," +
                "@excluiConfiguracoes, @excluiCategorias, @visualizaUsuarios, @visualizaEventos, @visualizaIngressos, @visualizaConfiguracoes" +
                "@visualizaCategorias, @visualizaGraficos, @visualizaRelatorios, @visualizaMonitor, @imprimeRelatorios)";
            return ExecutarSemConsultar(comando);
        }

        public ArrayList lerPreencherLista(MySqlCommand comando)
        {
            throw new NotImplementedException();
        }

        public object lerPreencherUm(MySqlCommand comando)
        {
            throw new NotImplementedException();
        }

        public object listarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public ArrayList listarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public ArrayList listarTodos()
        {
            throw new NotImplementedException();
        }

        public object listarUmPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
