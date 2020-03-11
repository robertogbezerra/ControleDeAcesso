using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace ControleDeAcesso.report
{
    public class GerenteReportImplement
    {
        public const string reportEventos = "Relatório de Eventos";
        public const string reportUsuarios = "Relatório de Usuários";
        public const string reportCategorias = "Relatório de Categroias";
        public const string reportConfiguracoes = "Relatório de Configurações";
        public const string reportIngressos = "Relatório de Ingressos";

        public IGerenteReport igerenteReport { get; set; }
        /// <summary>
        /// Preenche o DataSource e o ReportSource do Relatório a ser exibido
        /// </summary>
        /// <param name="reportViwer"> Instância do ReportViwer que deve receber o Report para exibir</param>
        /// <param name="bindingSource"> Fonte de dados que será configurado no DataSource</param>
        /// <param name="reportName">nome do Report</param>
        protected void FillDataSource(ReportViewer reportViwer, BindingSource bindingSource, string reportName)
        {
            ReportDataSource dataSource = new ReportDataSource();
            reportName += reportName.Substring(0, 1).ToUpper().Substring(1);
            dataSource.Name = string.Format("DataSet{0}", extrairNomeReport(reportName)[1]);
            dataSource.Value = bindingSource;
            reportViwer.LocalReport.DataSources.Add(dataSource);
            reportViwer.LocalReport.ReportEmbeddedResource = "ControleDeAcesso.report." + reportName + ".rdlc";
            reportViwer.Anchor = AnchorStyles.Bottom;

            //string className();
        }

        /// <summary>
        /// Extrai o nome chave do report para indicar o DataSet correto.
        /// </summary>
        /// <param name="reportName"></param>
        /// <returns></returns>
        private string[] extrairNomeReport(string reportName)
        {
            string[] nomes = reportName.Split('-');
            return nomes;
        }

    }
}
