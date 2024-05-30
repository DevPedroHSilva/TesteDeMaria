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

namespace VendasJa.Produto.Relatorio
{
    public partial class RelatorioProdutos : Form
    {
        public RelatorioProdutos()
        {
            InitializeComponent();

            this.Activated += page_load;
        }

        private void page_load(object sender, EventArgs e)
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
            string chr_produto = txtProduto.Text;

            StringBuilder str_query = new StringBuilder();
            str_query.Append("select * from tbproduto where 1 = 1");

            if (!dt_inicio.Equals(""))
                str_query.AppendLine(" and dt_insert >= '" + dt_inicio + "' ");

            if (!dt_fim.Equals(""))
                str_query.AppendLine(" and dt_insert <= '" + dt_fim + "' ");

            if (!chr_produto.Equals(""))
            {
                c.prm("@chr_produto", chr_produto);
                str_query.AppendLine(" and lower(chr_produto) LIKE '%'|| Lower(@chr_produto) ||'%'");
            }

            str_query.AppendLine(" order by chr_produto");

            DataTable dataTable = c.DataTable(str_query.ToString());
            c.encerrarConexao();

            rvRelatorioGeral.LocalReport.DataSources.Clear();

            rvRelatorioGeral.LocalReport.ReportEmbeddedResource = "VendasJa.Produto.Relatorio.RelatProdutos.rdlc";
            rvRelatorioGeral.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetGeral", dataTable));
            rvRelatorioGeral.RefreshReport();

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            carregarRelatorio();
        }
    }
}
