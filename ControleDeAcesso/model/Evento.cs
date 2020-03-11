using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAcesso.model
{
    class Evento
    {
        long id;
        long idUsuario;
        String descricao;
        DateTime data;
        String tipoDeEvento;
        int qtdeTotalIngressos;
        int qtdeSocioTorcedor;
        int qtdeCortesias;
        int qtdeGratuidade;
        int qtdePorSupervisor;
        int qtdeModoLivre;
        int capacidadePublico;
        

        public Evento(long id, String descricao, DateTime data, String tipoDeEvento, int qtdeTotalIngressos, int qtdeSocio,
             int qtdeCortesias, int qtdeGratuidade, int qtdePorSupervisor, int qtdeModoLivre, int capacidadePublico)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Data = data;
            this.TipoDeEvento = tipoDeEvento;
            this.QtdeTotalIngressos = qtdeTotalIngressos;
            this.QtdeSocioTorcedor = qtdeSocio;
            this.QtdeCortesias = qtdeCortesias;
            this.QtdeGratuidade = qtdeGratuidade;
            this.QtdePorSupervisor = qtdePorSupervisor;
            this.QtdeModoLivre = qtdeModoLivre;
            this.CapacidadePublico = capacidadePublico;
        }

        public Evento()
        {
        }

        public static List<Evento> listarEventos()
        {
            List<Evento> lista = new List<Evento>();
            DateTime data = DateTime.Now;
            for (int i = 0; i < 20; i++)
            {
                data = data.AddMonths(5);
                Evento e = new Evento(1, "Time" + (i + 1) + "Time " + (i + 10), data,"Campeonato " + i,
                25000, 0, 200 + i, 150 + i, 280 + i, 0, 35000);
                lista.Add(e);

            }
            return lista;
        }

        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Data { get => data; set => data = value; }
        public int QtdeTotalIngressos { get => qtdeTotalIngressos; set => qtdeTotalIngressos = value; }
        public int QtdeCortesias { get => qtdeCortesias; set => qtdeCortesias = value; }
        public int QtdeGratuidade { get => qtdeGratuidade; set => qtdeGratuidade = value; }
        public int QtdePorSupervisor { get => qtdePorSupervisor; set => qtdePorSupervisor = value; }
        public int CapacidadePublico { get => capacidadePublico; set => capacidadePublico = value; }
        public long Id { get => id; set => id = value; }
        public int QtdeModoLivre { get => qtdeModoLivre; set => qtdeModoLivre = value; }
        public int QtdeSocioTorcedor { get => qtdeSocioTorcedor; set => qtdeSocioTorcedor = value; }
        public string TipoDeEvento { get => tipoDeEvento; set => tipoDeEvento = value; }
        public long IdUsuario { get => idUsuario; set => idUsuario = value; }
    }


}
