using System.Configuration;
using System.Data.SqlClient;

namespace ControleDeAcesso.model
{
    public class ConfiguracaoDeSistema
    {
        private int id;
        private string descricao;
        private bool insereUsuarios, insereEventos, insereIngressos, insereConfiguracoes, insereCategorias, editaUsuarios, editaEventos, editaIngressos, 
            editaConfiguracoes, editaCategorias, excluiUsuarios, excluiEventos, excluiIngressos, excluiConfiguracoes, excluiCategorias, visualizaUsuarios, 
            visualizaEventos, visualizaIngressos, visualizaConfiguracoes, visualizaCategorias, visualizaGraficos, visualizaRelatorios, visualizaMonitor, 
            imprimeRelatorios;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public bool InsereUsuarios { get => insereUsuarios; set => insereUsuarios = value; }
        public bool InsereEventos { get => insereEventos; set => insereEventos = value; }
        public bool InsereIngressos { get => insereIngressos; set => insereIngressos = value; }
        public bool InsereConfiguracoes { get => insereConfiguracoes; set => insereConfiguracoes = value; }
        public bool InsereCategorias { get => insereCategorias; set => insereCategorias = value; }
        public bool EditaUsuarios { get => editaUsuarios; set => editaUsuarios = value; }
        public bool EditaEventos { get => editaEventos; set => editaEventos = value; }
        public bool EditaIngressos { get => editaIngressos; set => editaIngressos = value; }
        public bool EditaConfiguracoes { get => editaConfiguracoes; set => editaConfiguracoes = value; }
        public bool EditaCategorias { get => editaCategorias; set => editaCategorias = value; }
        public bool ExcluiUsuarios { get => excluiUsuarios; set => excluiUsuarios = value; }
        public bool ExcluiEventos { get => excluiEventos; set => excluiEventos = value; }
        public bool ExcluiIngressos { get => excluiIngressos; set => excluiIngressos = value; }
        public bool ExcluiConfiguracoes { get => excluiConfiguracoes; set => excluiConfiguracoes = value; }
        public bool ExcluiCategorias { get => excluiCategorias; set => excluiCategorias = value; }
        public bool VisualizaUsuarios { get => visualizaUsuarios; set => visualizaUsuarios = value; }
        public bool VisualizaEventos { get => visualizaEventos; set => visualizaEventos = value; }
        public bool VisualizaIngressos { get => visualizaIngressos; set => visualizaIngressos = value; }
        public bool VisualizaConfiguracoes { get => visualizaConfiguracoes; set => visualizaConfiguracoes = value; }
        public bool VisualizaCategorias { get => visualizaCategorias; set => visualizaCategorias = value; }
        public bool VisualizaGraficos { get => visualizaGraficos; set => visualizaGraficos = value; }
        public bool VisualizaRelatorios { get => visualizaRelatorios; set => visualizaRelatorios = value; }
        public bool VisualizaMonitor { get => visualizaMonitor; set => visualizaMonitor = value; }
        public bool ImprimeRelatorios { get => imprimeRelatorios; set => imprimeRelatorios = value; }

    }
}
