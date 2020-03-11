using ControleDeAcesso.db;
using Devart.Data.MySql;
using System;
using System.Collections;
using System.Text;

namespace ControleDeAcesso.dao
{
    class CrudImplement
    {
        protected Conexao con = new Conexao();
        protected MySqlDataReader consulta;
        protected ArrayList lista = new ArrayList();
        protected MySqlCommand comando = new MySqlCommand();

        internal Conexao Con { get => con; set => con = value; }
        public MySqlDataReader Consulta { get => consulta; set => consulta = value; }
        public ArrayList Lista { get => lista; set => lista = value; }
        public MySqlCommand Comando { get => comando; set => comando = value; }

        public CrudImplement()
        {
            Comando.Connection = Con.Con;
        }

        protected void ListarParams(Object obj)
        {
            comando.Parameters.Clear();
            foreach (var prop in obj.GetType().GetProperties())
            {
                comando.Parameters.AddWithValue("@" + prop.Name.Substring(0, 1).ToLower() + prop.Name.Substring(1), prop.GetValue(obj));
            }
        }

        protected string ContruirConsulta(object obj, string nomeTabela, tipoConsulta operacao, MySqlParameter[] parametros)
        {
            StringBuilder campos = new StringBuilder();
            
            switch (operacao)
            {
                case tipoConsulta.INSERIR:
                    {
                        campos.AppendFormat("INSERT INTO {0} (", nomeTabela);

                        foreach (var prop in obj.GetType().GetProperties())
                        {
                            campos.AppendFormat("{0}, ", prop.Name.Substring(0, 1).ToLower() + prop.Name.Substring(1));
                        }
                        campos.Remove(campos.Length - 2, 2);
                        campos.Append(") VALUES (");
                        comando.Parameters[0].Value = "";
                        foreach (MySqlParameter param in comando.Parameters)
                        {
                            campos.AppendFormat("{0}, ", param.ToString());
                        }
                        campos.Remove(campos.Length - 2, 2);
                        campos.Append(")");
                    }
                    break;

                case tipoConsulta.DELETAR:
                    {
                        campos.AppendFormat("DELETE FROM {0} WHERE ", nomeTabela);
                        foreach (MySqlParameter param in comando.Parameters)
                        {                                
                            campos.AppendFormat("{0} = @{0} AND ", param.ToString().Remove(0,1));
                        }
                        campos.Remove(campos.Length - 5, 5);
                    }
                    break;
                case tipoConsulta.EDITAR:
                    {
                        campos.AppendFormat("UPDATE {0} SET ", nomeTabela);
                        foreach (MySqlParameter param in comando.Parameters)
                        {
                            campos.AppendFormat("{0} = @{0}, ", param.ToString().Remove(0, 1));
                        }
                        campos.Remove(campos.Length - 2, 2);
                        campos.AppendFormat("WHERE ");
                        foreach (MySqlParameter param in parametros)
                        {
                            campos.AppendFormat("{0} = @{0} AND ", param.ToString().Remove(0, 1));
                        }
                        campos.Remove(campos.Length - 5, 5);
                    }
                    break;
                case tipoConsulta.LISTAR:
                    {
                    campos.Append("SELECT ");
                        foreach (MySqlParameter param in comando.Parameters)
                        {
                            campos.AppendFormat("{0}, ", param.ToString().Remove(0, 1));
                        }
                        campos.Remove(campos.Length - 2, 2);
                        campos.AppendFormat(" FROM {0} ", nomeTabela);

                        if (parametros.Length > 0)
                        {
                            campos.AppendFormat("WHERE ");
                            for (int i = 0; i < parametros.Length; i++)
                            {
                                campos.AppendFormat("{0} = @{0} AND ", parametros[i].ToString().Remove(0, 1));
                            }
                            campos.Remove(campos.Length - 5, 5);
                        }
                    }
                    break;

            }
            
            return campos.ToString();
        }

        protected void PreencherObjeto(Object obj)
        {
            int i = 0;
            foreach (var prop in obj.GetType().GetProperties())
            {
                string paran = consulta[consulta.GetName(i)].ToString();
                prop.SetValue(obj, consulta[consulta.GetName(i)]);
                i++;
            }
        }



        protected int ExecutarSemConsultar(MySqlCommand comando)
        {
            int retorno;
            comando.Connection.Open();
            retorno = comando.ExecuteNonQuery();
            comando.Connection.Close();
            comando.Dispose();
            comando.Connection.Dispose();
            return retorno;
        }
    }
}
