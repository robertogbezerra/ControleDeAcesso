using ControleDeAcesso.model;
using Devart.Data.MySql;
using System;
using System.Collections;
using System.Windows.Forms;

namespace ControleDeAcesso.dao
{
    class CrudCategoria : CrudImplement, ICrud
    {
        Categoria categoriaRetorno;
        Categoria categoria;

        public int inserir(object obj, string tableName, tipoConsulta tipoConsulta, MySqlParameter[] parametrosWhere)
        {
            categoria = (Categoria)obj;
            comando.Parameters.AddWithValue("@userName", categoria.Nome);
            comando.CommandText = "INSERT INTO categorias (nome) VALUES (@userName)";
            return ExecutarSemConsultar(comando);
        }
        public void atualizar(object obj, int id)
        {
            categoria = (Categoria)obj;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@userName", categoria.Nome);
            comando.CommandText = "UPDATE categorias SET nome = @nome WHERE id = @id";
            ExecutarSemConsultar(comando);
        }
        public void excluir(int id)
        {
            comando.Parameters.AddWithValue("@id", id);
            comando.CommandText = "DELETE FROM categorias WHERE id = @id";
            ExecutarSemConsultar(comando);
        }

        public ArrayList listarTodos()
        {
            comando.CommandText = "SELECT * FROM categorias";
            return lerPreencherLista(comando);
        }
        public object listarPorId(int id)
        {
            comando.Parameters.AddWithValue("@id", id);
            comando.CommandText = "SELECT * FROM categorias WHERE id = @id";
            return lerPreencherUm(comando);
        }
        public ArrayList listarPorNome(string nome)
        {
            comando.Parameters.AddWithValue("@nome", nome);
            comando.CommandText = "SELECT * FROM categorias WHERE nome LIKE '%'@nome'%'";
            return lerPreencherLista(comando);
        }
        public object listarUmPorNome(string nome)
        {
            comando.Parameters.AddWithValue("@nome", nome);
            comando.CommandText = "SELECT * FROM categorias WHERE nome = @nome";
            return lerPreencherUm(comando);
        }

        public object lerPreencherUm(MySqlCommand comando)
        {
            categoriaRetorno = new Categoria();
            comando.Connection.Open();
            consulta = comando.ExecuteReader();
            try
            {
                if (consulta.HasRows) // caso haja algum registro no banco, o reader será chamado e mostrará, se não ele sai deste método e mostrará a mensagem de erro do bloco 'else'
                {
                    while (consulta.Read())
                    {
                        categoriaRetorno.Id = (int)consulta[consulta.GetName(0)];
                        categoriaRetorno.Nome = consulta[consulta.GetName(1)].ToString();
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
            return categoriaRetorno;
        }
        public ArrayList lerPreencherLista(MySqlCommand comando)
        {
            lista = new ArrayList();
            consulta = comando.ExecuteReader();
            try
            {
                if (consulta.HasRows) // caso haja algum registro no banco, o reader será chamado e mostrará, se não ele sai deste método e mostrará a mensagem de erro do bloco 'else'
                {
                    while (consulta.Read())
                    {
                        categoria = new Categoria();
                        categoriaRetorno.Id = (int)consulta[consulta.GetName(0)];
                        categoriaRetorno.Nome = consulta[consulta.GetName(1)].ToString();

                        lista.Add(categoria);
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