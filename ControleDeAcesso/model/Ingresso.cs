using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAcesso.model
{
    class Ingresso
    {
        long id, codigo, idEvento;
        string tipo;

        public long Id { get => id; set => id = value; }
        public long Codigo { get => codigo; set => codigo = value; }
        public long IdEvento { get => idEvento; set => idEvento = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
