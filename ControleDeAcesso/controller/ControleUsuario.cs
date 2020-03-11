using Devart.Data.MySql;
using System;
using System.Collections;
using ControleDeAcesso.dao;

namespace ControleDeAcesso.Controller
{
    class ControleUsuario :  IControle
    {
        private CrudUsuario crudUsuario = new CrudUsuario();

        private MySqlCommand comando = new MySqlCommand();

        public MySqlCommand Comando { get => comando; set => comando = value; }

        public void atualizar(object obj, int id)
        {
            crudUsuario.atualizar(obj, id);
        }

        public void excluir(int id)
        {
            crudUsuario.excluir(id);
        }

        public bool inserir(object obj)
        {
            return false;// crudUsuario.inserir(obj);
        }

        public ArrayList lerPreencherLista(MySqlCommand comando)
        {
            return crudUsuario.lerPreencherLista(comando);
        }

        public object lerPreencherUm(MySqlCommand comando)
        {
            return lerPreencherUm(comando);
        }

        public object listarPorId(int id)
        {
            //crudUsuario = new CrudUsuario();
            return crudUsuario.listarPorId(id);
        }

        public ArrayList listarPorNome(string nome)
        {
            //crudUsuario = new CrudUsuario();
            return crudUsuario.listarPorNome(nome);
        }

        public ArrayList listarTodos()
        {
            //crudUsuario = new CrudUsuario();
            return crudUsuario.listarTodos();
        }

        public object listarUmPorNome(string nome)
        {
            //crudUsuario = new CrudUsuario();
            return crudUsuario.listarUmPorNome(nome);
        }

        public ArrayList pesquisarVarios(string nome)
        {
            //crudUsuario = new CrudUsuario();
            return crudUsuario.listarPorNome(nome);
        }

        object IControle.preencherDados()
        {
            throw new NotImplementedException();
        }
    }
}
