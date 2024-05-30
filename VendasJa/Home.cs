using DataBase;
using System.Data;
using VendasJa.Cliente.Relatorio;
using VendasJa.Produto;
using VendasJa.Produto.Relatorio;
using VendasJa.Venda;

namespace VendasJa
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            this.Activated += page_load;
        }

        private void page_load(object sender, EventArgs e)
        {
            //Solução para index paleativa, se tiver tempo usarei uma view para trazer todos os resultados
            //em apenas uma consulta.

            Conexao c = new Conexao();
            lblIndexClienteValue.Text = "" + c.DataRow("select count(id_cliente) as int_total_cliente from tbcliente")["int_total_cliente"];
            lblTotalProdutoValue.Text = "" + c.DataRow("select count(id_produto) as int_total_produto from tbproduto")["int_total_produto"];

            DataRow rVendas = c.DataRow("select sum(flo_valor_total_venda) as flo_total_faturamento, count(id_venda) as int_total_vendas from vwvenda");
            lblFaturamentoMensalValor.Text = double.Parse("0" + rVendas["flo_total_faturamento"]).ToString("c");
            lblTotalVendasValor.Text = "" + rVendas["int_total_vendas"];
        }

        private void btnMenuCliente_Click(object sender, EventArgs e)
        {
            PesquisaCliente pesquisaCliente = new PesquisaCliente();
            pesquisaCliente.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            PesquisaProduto pesquisaProduto = new PesquisaProduto();
            pesquisaProduto.Show();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            VendaPDV vendaPDV = new VendaPDV();
            vendaPDV.Show();
        }

        private void btnRelatorioVenda_Click(object sender, EventArgs e)
        {
            RelatorioVendas relatorioVendas = new RelatorioVendas();
            relatorioVendas.Show();
        }

        private void btnRelatorioClientes_Click(object sender, EventArgs e)
        {
            RelatorioClientes relatorioClientes = new RelatorioClientes();
            relatorioClientes.Show();
        }

        private void btnRelatorioProdutos_Click(object sender, EventArgs e)
        {
            RelatorioProdutos relatorioProdutos = new RelatorioProdutos();
            relatorioProdutos.Show();
        }
    }
}
