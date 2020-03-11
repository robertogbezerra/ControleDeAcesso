using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeAcesso.report
{
    public interface IGerenteReport
    {
        string ReportName();
        void EscolherReportParaExibir(ReportViewer reportViwer, string relatorio, BindingSource bindingSource);


    }
}
