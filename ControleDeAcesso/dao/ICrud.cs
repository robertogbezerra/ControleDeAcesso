using System;
using System.Collections;
using Devart.Data.MySql;

namespace ControleDeAcesso.dao
{
    interface ICrud
    {
        int inserir(object obj, string tableName, tipoConsulta tipoConsulta, MySqlParameter[] parametrosWhere);
        void atualizar(object obj, int id);
        void excluir(int id);
        ArrayList listarTodos();
        object listarPorId(int id);
        ArrayList listarPorNome(string nome);
        object listarUmPorNome(string nome);
        object lerPreencherUm(MySqlCommand comando);
        ArrayList lerPreencherLista(MySqlCommand comando);
    }

   enum tipoConsulta { INSERIR, DELETAR, EDITAR, LISTAR }
}

