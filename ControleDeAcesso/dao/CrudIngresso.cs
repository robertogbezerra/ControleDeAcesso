using ControleDeAcesso.dao;
using ControleDeAcesso.model;
using Devart.Data.MySql;
using System;
using System.Collections;
using System.Windows.Forms;

namespace ControleDeAcessoCFO.crud
{
    class CrudIngresso : CrudImplement, ICrud
    {
        Ingresso ingressoRetorno;
        Ingresso ingresso;

        public int inserir(object obj, string tableName, tipoConsulta tipoConsulta, MySqlParameter[] parametrosWhere)
        {
            ingresso = (Ingresso)obj;
            comando.Parameters.AddWithValue("@codigo", ingresso.Codigo);
            comando.Parameters.AddWithValue("@idEvento", ingresso.IdEvento);
            comando.Parameters.AddWithValue("@tipo", ingresso.Tipo);
            con.query_string = "INSERT INTO ingressos (codigo, idEvento, tipo) VALUES ('"
            + " @codigo, "
            + " @idEvento, "
            + " @tipo)";
            return ExecutarSemConsultar(comando);
        }
        public void atualizar(object obj, int id)
        {
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@codigo", ingresso.Codigo);
            comando.Parameters.AddWithValue("@idEvento", ingresso.IdEvento);
            comando.Parameters.AddWithValue("@tipo", ingresso.Tipo);
            ingresso = (Ingresso)obj;
            con.query_string = "UPDATE ingressos SET "
            + " codigo = @codigo "
            + " idEvento = @idEvento, "
            + " tipo = @tipo, "
            + "WHERE id = @id";
            con.execute_non_query();
        }
        public void excluir(int id)
        {
            comando.Parameters.AddWithValue("@id", id);
            comando.CommandText = "DELETE FROM ingressos WHERE id = @id";
            ExecutarSemConsultar(comando);
        }
        public ArrayList listarTodos()
        {
            comando.CommandText = "SELECT * FROM ingressos";
            return lerPreencherLista(comando);
        }
        public object listarPorId(int id)
        {
            comando.Parameters.AddWithValue("@id", id);
            comando.CommandText = "SELECT * FROM ingressos WHERE id = @id";
            return lerPreencherUm(comando);
        }
        public ArrayList listarPorNome(string tipo)
        {
            comando.Parameters.AddWithValue("@nome", tipo);
            comando.CommandText = "SELECT * FROM ingressos WHERE tipo LIKE '%'@tipo'%'";
            return lerPreencherLista(comando);
        }
        public object listarUmPorNome(string tipo)
        {
            comando.Parameters.AddWithValue("@nome", tipo);
            comando.CommandText = "SELECT * FROM ingressos WHERE tipo = @tipo";
            return lerPreencherUm(comando);
        }
        public object lerPreencherUm(MySqlCommand comando)
        {
            ingressoRetorno = new Ingresso();
            comando.Connection.Open();
            consulta = comando.ExecuteReader();
            try
            {
                if (consulta.FieldCount > 0) // caso haja algum registro no banco, o reader será chamado e mostrará, se não ele sai deste método e mostrará a mensagem de erro do bloco 'else'
                {
                    while (consulta.Read())
                    {
                        ingressoRetorno.Id = (long)consulta[consulta.GetName(0)];
                        ingressoRetorno.Codigo = (long) consulta[consulta.GetName(1)];
                        ingressoRetorno.IdEvento = (long) consulta[consulta.GetName(2)];
                        ingressoRetorno.Tipo = consulta[consulta.GetName(3)].ToString();
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
            return ingressoRetorno;
        }
        public ArrayList lerPreencherLista(MySqlCommand comando)
        {
            lista = new ArrayList();
            comando.Connection.Open();
            consulta = comando.ExecuteReader();
            try
            {
                if (consulta.FieldCount > 0) // caso haja algum registro no banco, o reader será chamado e mostrará, se não ele sai deste método e mostrará a mensagem de erro do bloco 'else'
                {
                    while (consulta.Read())
                    {
                        ingresso = new Ingresso();
                        ingressoRetorno.Id = (int) consulta[consulta.GetName(0)];
                        ingressoRetorno.Codigo = (long) consulta[consulta.GetName(1)];
                        ingressoRetorno.IdEvento = (long) consulta[consulta.GetName(2)];
                        ingressoRetorno.Tipo = consulta[consulta.GetName(3)].ToString();

                        lista.Add(ingresso);
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