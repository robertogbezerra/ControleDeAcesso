using Devart.Data.MySql;
using System;
using System.Configuration;
using System.Data;

namespace ControleDeAcesso.db
{
    sealed class Conexao
    {
        // Conexão com porta TCP
        //private string string_conexao = "Server=http:\\127.0.0.1\\phpmyadmin;Port=8888;Database=xpanel_manager;Uid=root;Pwd=;";
        private string string_conexao = "Data Source=localhost;Initial Catalog=controledeacessocfo;User ID=root;Password=;Connection Timeout=45";
        // Conexão padrão
        public static MySqlConnection con = new MySqlConnection("Data Source = localhost; Initial Catalog = controledeacessocfo; User ID = root; Password=;Connection Timeout = 45; Charset=utf8;");
        public string query_string = "";

        public string String_conexao { get => string_conexao; set => string_conexao = value; }
        public MySqlConnection Con { get => con; set => con = value; }
        
        public Conexao() { }
        private static volatile MySqlConnection instance;
        public static MySqlConnection conexao
        {
            get
            {
                if (instance == null)
                {
                    return instance = con;
                   // return instance = new MySqlConnection(ConfigurationManager.ConnectionStrings["controledeacessocfoConnectionString"].ConnectionString);
                }
                else
                {
                    return instance;
                }
            }
        }
        // metodos //
        public MySqlDataReader mysql_data_reader()
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = con.ConnectionString;
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = query_string;
                comando.Connection = conexao;
                
                MySqlDataReader reader = comando.ExecuteReader();

                return reader;
            }
            catch (Exception e )
            {
                throw e;
            }

        }

        public DataTable mysql_data_adapter()
        {
            DataTable dtb = new DataTable();

            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = this.String_conexao;
            try
            {
                conexao.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query_string, conexao);

                adapter.Fill(dtb);

                conexao.Dispose();
                adapter.Dispose();
            }
            catch
            {
               // MessageBox.Show(msgErro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dtb;
        }

        public bool execute_non_query()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection();
                conexao.ConnectionString = this.String_conexao;
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = query_string;
                comando.Connection = conexao;
                comando.ExecuteNonQuery();

                conexao.Dispose();
                comando.Dispose();
                return true;
            }
            catch
            {
                //MessageBox.Show(msgErro, "ERRO"  , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                throw;
                
            }
        }
    }
}
