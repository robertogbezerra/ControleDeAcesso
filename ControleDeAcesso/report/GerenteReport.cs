using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeAcesso.report
{
    public class GerenteReport
    {
        private const string reportEventos = "Relatório de Eventos";
        private const string reportUsuarios = "Relatório de Usuários";
        private const string reportCategorias = "Relatório de Categroias";
        private const string reportConfiguracoes = "Relatório de Configurações";
        private const string reportIngressos = "Relatório de Ingressos";

        public IGerenteReport igerenteReport { get; set; }

        static string ReportEventos => reportEventos;

        static string ReportUsuarios => reportUsuarios;

        static string ReportCategorias => reportCategorias;

        static string ReportConfiguracoes => reportConfiguracoes;

        static string ReportIngressos => reportIngressos;
    }
}
