using ControleDeAcesso.model;
using Devart.Data.MySql;
using System;
using System.Collections;
using System.Windows.Forms;

namespace ControleDeAcesso.dao
{
   
    class CrudUsuario : CrudImplement, ICrud
    {
        Usuario usuario;
        Usuario usuarioRetorno = new Usuario();
        public int inserir(object obj, string tableName, tipoConsulta tipoConsulta, MySqlParameter[] parametrosWhere)
        {
            usuario = (Usuario) obj;
            ListarParams(usuario);
            comando.CommandText = ContruirConsulta(usuario, "usuarios", tipoConsulta.INSERIR, parametrosWhere);
            return ExecutarSemConsultar(comando);            
        }
        public void atualizar(object obj, int id)
        {
            usuario = (Usuario)obj;
            ListarParams(usuario);
            comando.CommandText = "UPDATE usuarios SET userName = @userName, senha = @senha, categoria = @categoria, " +
            "email = @email, codVerificacao = @codVerificacao, pergunta = @pergunta, resposta = @resposta WHERE id = @id";
            ExecutarSemConsultar(comando);
        }

        public void excluir(int id)
        {
            comando.Parameters.AddWithValue("@id", id);
            comando.CommandText = "DELETE FROM usuarios WHERE id = @id";
            ExecutarSemConsultar(comando);
        }

        public ArrayList listarTodos()
        {
            comando.CommandText = "SELECT * FROM usuarios";
            return lerPreencherLista(comando);
        }
        public object listarPorId(int id)
        {
            comando.Parameters.AddWithValue("@id", id);
            comando.CommandText = "SELECT * FROM usuarios WHERE id = @id";
            return lerPreencherUm(comando);
        }
        public ArrayList listarPorNome(string nome)
        {
            comando.Parameters.AddWithValue("@nome", nome);
            comando.CommandText = "SELECT * FROM usuarios WHERE UserName LIKE '%'@nome'%'";
            return lerPreencherLista(comando);
        }
        public object listarUmPorNome(string nome)
        {
            comando.Parameters.AddWithValue("@nome", nome);
            comando.CommandText = "SELECT * FROM usuarios WHERE userName = @nome";
            return lerPreencherUm(comando);
        }
        public object listarUmPorCodVerificacao(int cod)
        {
            comando.Parameters.AddWithValue("@cod", cod);
            comando.CommandText = "SELECT * FROM usuarios WHERE codVerificacao = @cod";
            return lerPreencherUm(comando);
        }
        public object lerPreencherUm(MySqlCommand comando)
        {
            usuarioRetorno = new Usuario();            
            try
            {
                comando.Connection.Open();
                consulta = comando.ExecuteReader();
                if (consulta.HasRows)
                {
                    while (consulta.Read())
                    {
                        PreencherObjeto(usuarioRetorno);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.Insert(e.Message.Length, "\n\n\nLocal do erro\n\n\n" + e.StackTrace), "Erro de conexão com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            comando.Connection.Close();
            comando.Dispose();
            comando.Connection.Dispose();
            return usuarioRetorno;
        }

        public ArrayList lerPreencherLista(MySqlCommand comando)
        {
            lista = new ArrayList();
            try
            {
                consulta = comando.ExecuteReader();
                if (consulta.HasRows)
                {
                    while (consulta.Read())
                    {
                        usuario = new Usuario();
                        PreencherObjeto(usuario);
                        lista.Add(usuario);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro de conexão com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            comando.Connection.Close();
            comando.Dispose();
            comando.Connection.Dispose();
            return lista;
        }
    }
}
