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

namespace VendasJa.Venda
{
    public partial class RelatorioVendas : Form
    {
        public RelatorioVendas()
        {
            InitializeComponent();

            this.Activated += page_load;
        }

        private void page_load(object sender, EventArgs e)
        {
            carregarRelatorio();
            //Carregar os clientes ao ComboBox
            Util.loadDDL(comboCliente, "select id_cliente, chr_cliente from tbcliente order by chr_cliente", false);
        }


        private void txtDataInicio_Click(object sender, EventArgs e)
        {
            calendarDataInicio.Visible = true;
        }

        private void txtDataFim_Click(object sender, EventArgs e)
        {
            calendarDataFiim.Visible = true;
        }

        private void calendarDataInicio_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDataInicio.Text = calendarDataInicio.SelectionStart.ToShortDateString();
            calendarDataInicio.Visible = false;
        }

        private void calendarDataFiim_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDataFim.Text = calendarDataFiim.SelectionStart.ToShortDateString();
            calendarDataFiim.Visible = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            carregarRelatorio();
        }

        private void carregarRelatorio()
        {
            calendarDataInicio.Visible = false;
            calendarDataFiim.Visible = false;


            string dt_inicio = txtDataInicio.Text;
            string dt_fim = txtDataFim.Text;
            string id_cliente = "" + Util.retornaValorSelecionado(comboCliente).Value;

            StringBuilder str_query = new StringBuilder();
            str_query.Append("select * from vwvenda where 1 = 1");

            if (!dt_inicio.Equals(""))
                str_query.AppendLine(" and dt_venda >= '" + dt_inicio + "' ");

            if (!dt_fim.Equals(""))
                str_query.AppendLine(" and dt_venda <= '" + dt_fim + "' ");

            if (!id_cliente.Equals(""))
                str_query.AppendLine(" and id_cliente = " + id_cliente);

            str_query.AppendLine(" order by dt_venda desc");



            Conexao c = new Conexao();
            DataTable dataTable = c.DataTable(str_query.ToString());
            c.encerrarConexao();

            rvRelatorioGeral.LocalReport.DataSources.Clear();

            rvRelatorioGeral.LocalReport.ReportEmbeddedResource = "VendasJa.Venda.Relatorio.RelatVendas.rdlc";
            rvRelatorioGeral.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetGeral", dataTable));
            rvRelatorioGeral.RefreshReport();

        }
    }
}
