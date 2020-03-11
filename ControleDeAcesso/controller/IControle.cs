using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Mvc;
using System.Windows.Forms;

namespace ControleDeAcesso.Controller
{
    interface IControle
    {
        ArrayList pesquisarVarios(string nome);
        object preencherDados();
    }
}
