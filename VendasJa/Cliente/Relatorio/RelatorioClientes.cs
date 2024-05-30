using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendasJa.Cliente.Relatorio
{
    public partial class RelatorioClientes : Form
    {
        public RelatorioClientes()
        {
            InitializeComponent();
            this.Activated += page_load;
        }

        private void page_load(object sender, EventArgs e)
        {
            carregarRelatorio();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            carregarRelatorio();
        }

        private void carregarRelatorio()
        {
            Conexao c = new Conexao();

            calendarDataInicio.Visible = false;
            calendarDataFiim.Visible = false;


            string dt_inicio = txtDataInicio.Text;
            string dt_fim = txtDataFim.Text;
            string chr_cliente = txtCliente.Text;

            StringBuilder str_query = new StringBuilder();
            str_query.Append("select * from tbcliente where 1 = 1");

            if (!dt_inicio.Equals(""))
                str_query.AppendLine(" and dt_insert >= '" + dt_inicio + "' ");

            if (!dt_fim.Equals(""))
                str_query.AppendLine(" and dt_insert <= '" + dt_fim + "' ");

            if (!chr_cliente.Equals(""))
            {
                c.prm("@chr_cliente", chr_cliente);
                str_query.AppendLine(" and lower(chr_cliente) LIKE '%'|| Lower(@chr_cliente) ||'%'");
            }

            str_query.AppendLine(" order by chr_cliente");

            DataTable dataTable = c.DataTable(str_query.ToString());
            c.encerrarConexao();

            rvRelatorioGeral.LocalReport.DataSources.Clear();

            rvRelatorioGeral.LocalReport.ReportEmbeddedResource = "VendasJa.Cliente.Relatorio.RelatClientes.rdlc";
            rvRelatorioGeral.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetGeral", dataTable));
            rvRelatorioGeral.RefreshReport();

        }
    }
}
