using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;
using Npgsql;
using VendasJa.Cliente;

namespace VendasJa
{
    public partial class PesquisaCliente : Form
    {
        Base frmBase = new Base(); //FrameWork Base para funcionamento padrão das telas

        public PesquisaCliente()
        {
            frmBase.form_pesquisa = this;
            frmBase.form_cadastro = new CadastroCliente();
            frmBase.form_edicao = new EdicaoCliente();

            InitializeComponent();
        }


        public StringBuilder construirFiltroPesquisa()
        {
            StringBuilder filtro = new StringBuilder();
            if (!txtPesquisaNome.Text.Equals(""))
            {
                filtro.AppendLine(" and Lower(chr_cliente) Like '%'|| Lower(@chr_cliente) ||'%'");
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
                " id_cliente, " +
                " chr_cliente, " +
                " chr_email, " +
                " chr_fone, " +
                " chr_cep, " +
                " chr_endereco, " +
                " chr_bairro, " +
                " chr_complemento," +
                " chr_numero, " +
                " dt_insert as \"Data do registro\"" +
                " from tbcliente" +
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

        private void lblLimparFiltro_Click(object sender, EventArgs e)
        {
            txtPesquisaNome.Text = "";

            lblFiltroNegativo.Visible = false;
            gridResultadoPesquisa.Visible = false;

            gridResultadoPesquisa.Columns.Clear();
            gridResultadoPesquisa.Rows.Clear();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroCliente formCadastro = new CadastroCliente();
            formCadastro.Show();
        }

    }
}
