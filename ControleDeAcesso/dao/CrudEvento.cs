using ControleDeAcesso.model;
using Devart.Data.MySql;
using System;
using System.Collections;
using System.Windows.Forms;

namespace ControleDeAcesso.dao
{
    class CrudEvento : CrudImplement, ICrud
    {
        Evento eventoRetorno;
        Evento evento;

        public int inserir(object obj, string tableName, tipoConsulta tipoConsulta, MySqlParameter[] parametrosWhere)
        {
            evento = (Evento)obj;
            comando.Parameters.AddWithValue("@descricao", evento.Descricao);
            comando.Parameters.AddWithValue("@data", evento.Data);
            comando.Parameters.AddWithValue("@tipoDeEvento", evento.TipoDeEvento);
            comando.Parameters.AddWithValue("@qtdeTotalIngressos", evento.QtdeTotalIngressos);
            comando.Parameters.AddWithValue("@qtdeSocioTorcedor", evento.QtdeSocioTorcedor);
            comando.Parameters.AddWithValue("@qtdeCortesias", evento.QtdeCortesias);
            comando.Parameters.AddWithValue("@qtdeGratuidade", evento.QtdeGratuidade);
            comando.Parameters.AddWithValue("@qtdePorSupervisor", evento.QtdePorSupervisor);
            comando.Parameters.AddWithValue("@qtdeModoLivre", evento.QtdeModoLivre);
            comando.Parameters.AddWithValue("@capacidadePublico", evento.CapacidadePublico);
            con.query_string = "INSERT INTO eventos (descricao, tipoDeEvento, data, qtdeTotalIngressos, qtdeSocioTorcedor, " +
                        "qtdeCortesias, qtdeGratuidade, qtdePorSupervisor, qtdeModoLivre, capacidadePublico) VALUES ( " +
            " @descricao, " +
            " @tipoDeEvento, " +
            " @data, " +
            " @qtdeTotalIngressos, " +
            " @qtdeSocioTorcedor, " +
            " @qtdeCortesias, " +
            " @qtdeGratuidade, " +
            " @qtdePorSupervisor, " +
            " @qtdeModoLivre, " +
            " @capacidadePublico )";
            return ExecutarSemConsultar(comando);
        }
        public void atualizar(object obj, int id)
        {
            evento = (Evento)obj;
            comando.Parameters.AddWithValue("@id", evento.Id);
            comando.Parameters.AddWithValue("@descricao", evento.Descricao);
            comando.Parameters.AddWithValue("@data", evento.Data);
            comando.Parameters.AddWithValue("@tipoDeEvento", evento.TipoDeEvento);
            comando.Parameters.AddWithValue("@qtdeTotalIngressos", evento.QtdeTotalIngressos);
            comando.Parameters.AddWithValue("@qtdeSocioTorcedor", evento.QtdeSocioTorcedor);
            comando.Parameters.AddWithValue("@qtdeCortesias", evento.QtdeCortesias);
            comando.Parameters.AddWithValue("@qtdeGratuidade", evento.QtdeGratuidade);
            comando.Parameters.AddWithValue("@qtdePorSupervisor", evento.QtdePorSupervisor);
            comando.Parameters.AddWithValue("@qtdeModoLivre", evento.QtdeModoLivre);
            comando.Parameters.AddWithValue("@capacidadePublico", evento.CapacidadePublico);

            comando.CommandText = "UPDATE eventos SET "
            + " descricao = @descricao, "
            + " data = @data, "
            + " tipoDeEvento = @tipoDeEvento, "
            + " qtdeTotalIngressos = @qtdeTotalIngressos, "
            + " qtdeSocioTorcedor = @qtdeSocioTorcedor, "
            + " qtdeCortesias = @qtdeCortesias, "
            + " qtdeGratuidade = @qtdeGratuidade, "
            + " qtdePorSupervisor = @qtdePorSupervisor, "
            + " qtdeModoLivre = @qtdeModoLivre, "
            + " capacidadePublico = @capacidadePublico "
            + "WHERE id = @id";

            ExecutarSemConsultar(comando);
        }
        public void excluir(int id)
        {
            comando.Parameters.AddWithValue("@id", id);
            comando.CommandText = "DELETE FROM eventos WHERE id = @id";
            ExecutarSemConsultar(comando);
        }
        public ArrayList listarTodos()
        {
            comando.CommandText = "SELECT * FROM eventos";
            return lerPreencherLista(comando);
        }
        public object listarPorId(int id)
        {
            comando.Parameters.AddWithValue("@id", id);
            comando.CommandText = "SELECT * FROM eventos WHERE id = @id";
            return lerPreencherUm(comando);
        }
        public ArrayList listarPorNome(string nome)
        {
            comando.Parameters.AddWithValue("@nome", nome);
            comando.CommandText = "SELECT * FROM eventos WHERE evento LIKE '%'@nome'%'";
            return lerPreencherLista(comando);
        }
        public object listarUmPorNome(string nome)
        {
            comando.Parameters.AddWithValue("@nome", nome);
            comando.CommandText = "SELECT * FROM eventos WHERE evento = @nome";
            return lerPreencherUm(comando);
        }

        public object lerPreencherUm(MySqlCommand comando)
        {
            eventoRetorno = new Evento();
            comando.Connection.Open();
            comando.Connection.Unicode = true;
            consulta = comando.ExecuteReader();
            try
            {
                if (consulta.FieldCount > 0) // caso haja algum registro no banco, o reader será chamado e mostrará, se não ele sai deste método e mostrará a mensagem de erro do bloco 'else'
                {
                    while (consulta.Read())
                    {
                        eventoRetorno.Id = (int)consulta[consulta.GetName(0)];
                        eventoRetorno.Descricao = consulta[consulta.GetName(1)].ToString();
                        eventoRetorno.TipoDeEvento = consulta[consulta.GetName(3)].ToString();
                        eventoRetorno.Data = (DateTime)consulta[consulta.GetName(2)];
                        eventoRetorno.CapacidadePublico = (int)consulta[consulta.GetName(4)];
                        eventoRetorno.QtdeTotalIngressos = (int)consulta[consulta.GetName(5)];
                        eventoRetorno.QtdeSocioTorcedor = (int)consulta[consulta.GetName(6)];
                        eventoRetorno.QtdeCortesias = (int)consulta[consulta.GetName(7)];
                        eventoRetorno.QtdeGratuidade = (int)consulta[consulta.GetName(8)];
                        eventoRetorno.QtdePorSupervisor = (int)consulta[consulta.GetName(9)];
                        eventoRetorno.QtdeModoLivre = (int)consulta[consulta.GetName(10)];
                    }
                }
                else
                {
                    MessageBox.Show("Náo foi encontrado nenhum registro no banco de dados referente a sua busca");
                }
            }
            catch (Exception)
            {
                throw;
            }
            comando.Connection.Close();
            return eventoRetorno;
        }
        public ArrayList lerPreencherLista(MySqlCommand comando)
        {
            lista = new ArrayList();
            comando.Connection.Open();
            comando.Connection.Unicode = true;
            consulta = comando.ExecuteReader();
            try
            {
                if (consulta.FieldCount > 0) // caso haja algum registro no banco, o reader será chamado e mostrará, se não ele sai deste método e mostrará a mensagem de erro do bloco 'else'
                {
                    while (consulta.Read())
                    {
                        eventoRetorno = new Evento();
                        eventoRetorno.Id = (long)consulta[consulta.GetName(0)];
                        eventoRetorno.Descricao = consulta[consulta.GetName(1)].ToString();
                        eventoRetorno.TipoDeEvento = consulta[consulta.GetName(2)].ToString();
                        eventoRetorno.Data = (DateTime) consulta.GetDateTime(consulta.GetName(3));
                        eventoRetorno.CapacidadePublico = (int)consulta[consulta.GetName(4)];
                        eventoRetorno.QtdeTotalIngressos = (int)consulta[consulta.GetName(5)];
                        eventoRetorno.QtdeSocioTorcedor = (int)consulta[consulta.GetName(6)];
                        eventoRetorno.QtdeCortesias = (int)consulta[consulta.GetName(7)];
                        eventoRetorno.QtdeGratuidade = (int)consulta[consulta.GetName(8)];
                        eventoRetorno.QtdePorSupervisor = (int)consulta[consulta.GetName(9)];
                        eventoRetorno.QtdeModoLivre = (int)consulta[consulta.GetName(10)];

                        lista.Add(eventoRetorno);
                    }
                }
                else
                {
                    MessageBox.Show("Náo foi encontrado nenhum registro no banco de dados referente a sua busca");
                }
            }
            catch (Exception)
            {
                throw;
            }
            comando.Connection.Close();
            return lista;
        }
    }
}