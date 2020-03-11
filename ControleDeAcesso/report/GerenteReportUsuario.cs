using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeAcesso.report
{
    public class GerenteReportUsuario : GerenteReportImplement, IGerenteReport
    {
        public string ReportName()
        {
            return "Relatório de Usuários";
        }

        public void EscolherReportParaExibir(ReportViewer reportViwer, string relatorio, BindingSource bindingSource)
        {
            this.FillDataSource(reportViwer, bindingSource, "Relatorio-Usuarios");
        }
    }
}
