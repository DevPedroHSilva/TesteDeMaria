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
using VendasJa.Cliente;

namespace VendasJa.Produto
{
    public partial class PesquisaProduto : Form
    {
        Base frmBase = new Base(); //FrameWork Base para funcionamento padrão das telas

        public PesquisaProduto()
        {
            frmBase.form_pesquisa = this;
            frmBase.form_cadastro = new CadastroProduto();
            frmBase.form_edicao = new EdicaoProduto();

            InitializeComponent();

            this.Activated += page_load;
        }

        private void page_load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.Show();
        }

        private void lblLimparFiltro_Click(object sender, EventArgs e)
        {
            txtPesquisaNome.Text = "";

            lblFiltroNegativo.Visible = false;
            gridResultadoPesquisa.Visible = false;

            gridResultadoPesquisa.Columns.Clear();
            gridResultadoPesquisa.Rows.Clear();
        }

        public StringBuilder construirFiltroPesquisa()
        {
            StringBuilder filtro = new StringBuilder();
            if (!txtPesquisaNome.Text.Equals(""))
            {
                filtro.AppendLine(" and Lower(chr_produto) Like '%'|| Lower(@chr_produto) ||'%'");
            }
            return filtro;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Conexao c = new Conexao();
            lblFiltroNegativo.Visible = false;
            gridResultadoPesquisa.Visible = false;
            gridResultadoPesquisa.Columns.Clear();
            gridResultadoPesquisa.Rows.Clear();


            //Simular pesquisa filtro
            if (!txtPesquisaNome.Text.Equals("")) c.prm("@chr_cliente", txtPesquisaNome.Text);
            string filtro = construirFiltroPesquisa().ToString();


            DataTable tbCliente = c.DataTable("select " +
                " id_produto, " +
                " chr_produto, " +
                " chr_descricao as \"Descrição\", " +
                " flo_preco as \"Preço\", " +
                " flo_estoque, " +
                " dt_insert as \"Data do registro\"" +
                " from tbproduto" +
                " where 1=1 " +
                filtro);

            //Só para garantir que foi finalizado mesmo a conexão e não exista nenhuma conexão aberta.
            c.encerrarConexao();


            //Se acaso não tiver resultado:
            if (tbCliente.Rows.Count == 0)
                lblFiltroNegativo.Visible = true;
            else
            {
                //Adiciona ao cabeçalho a coluna de ação para os registros 
                gridResultadoPesquisa = frmBase.adicionarColunasExtras(gridResultadoPesquisa);

                //Adiciona os cabeçalhos usando por base os headers do sql mas com modificações;
                gridResultadoPesquisa = frmBase.adicionarColunasGridViewPesquisar(tbCliente, gridResultadoPesquisa);

                //Adiciona os resultados da pesquisa.
                gridResultadoPesquisa = frmBase.adicionarLinhasGridViewPesquisar(tbCliente, gridResultadoPesquisa);

                //Torna o grid visivel.
                gridResultadoPesquisa.Visible = true;
            }

        }
    }
}
