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

namespace VendasJa.Venda
{
    public partial class VendaPDV : Form
    {
        private DataTable tbProduto;
        private List<object> list_itens_venda = new List<object>();

        Conexao c = new Conexao();

        //Métodos de pré init como configuração dos campos.

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas dígitos e teclas de controle (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a entrada de caracteres não numéricos
            }
        }

        public VendaPDV()
        {
            InitializeComponent();

            this.txtCodProduto.KeyPress += new KeyPressEventHandler(Number_KeyPress);
            this.txtQuantidade.KeyPress += new KeyPressEventHandler(Number_KeyPress);
            this.txtQuantidade.TextChanged += txtQuantidade_Changed;

            this.KeyPreview = true;

            this.KeyDown += new KeyEventHandler(VendaPDV_KeyDown);

            this.Activated += page_load;

            this.FormClosing += new FormClosingEventHandler(fecharFormulario);
        }

        private void fecharFormulario(object sender, FormClosingEventArgs e)
        {

        }

        private void page_load(object sender, EventArgs e)
        {
            //Inicialmente usado essa estratégia pela quantidade de produtos ser pequena
            //Então para evitar varios acessos ao banco ao longo do uso da tela é mais facil acessar a variavel.
            tbProduto = c.DataTable("select * from tbproduto where flo_estoque > 0 order by chr_produto");
            criarAuxiliadorDeCodigoDeProduto();

            //Carregar os clientes ao ComboBox
            Util.loadDDL(comboClientes, "select id_cliente, chr_cliente from tbcliente order by chr_cliente", true);

        }

        private void VendaPDV_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F5)
            {
                //F5 para selecionar o item
                selecionarItem();
            }
            else if (e.KeyCode == Keys.F4)
            {
                //F4 para abrir o auxiliador de código de produtos
                gbCodProdutoAuxilio.Visible = true;
            }
            else if (e.KeyCode == Keys.F10)
            {
                //F10 para adicionar o item ao cupom
                adicionarItemNoCupom();
            }
        }

        private void txtQuantidade_Changed(object sender, EventArgs e)
        {
            //Calcular em tempo de seleção
            string txtValorUni = txtValorUnitario.Text;
            txtValorUni = txtValorUni.Replace("R$", "").Trim();
            double flo_quantidade = double.Parse("0" + txtQuantidade.Text);
            double flo_valor_unit = double.Parse("0" + txtValorUni);

            txtValorTotalProduto.Text = (flo_quantidade * flo_valor_unit).ToString("C");

        }

        private void criarAuxiliadorDeCodigoDeProduto()
        {
            gridAuxilioCodigo.Columns.Add("col_prod_cod", "Código");
            gridAuxilioCodigo.Columns.Add("col_prod_name", "Produto");
            gridAuxilioCodigo.Columns["col_prod_name"].Width = 180;

            gridAuxilioCodigo.Rows.Clear();

            string str_auxilio_cod = "";

            foreach (DataRow produto in tbProduto.Rows)
            {
                gridAuxilioCodigo.Rows.Add(produto["id_produto"], produto["chr_produto"]);
            }
        }

        private void zerarInformacoesProdutoSelecionado()
        {
            txtCodProduto.Text = "";
            txtQuantidade.Text = "";
            txtValorUnitario.Text = "";
            txtValorTotalProduto.Text = "";
            lblTituloPrincipal.Text = "Digite o código de um produto!";

            pictureFoto.Image = null;
        }

        private void selecionarItem()
        {
            string cod_produto = "" + txtCodProduto.Text;

            if (!cod_produto.Equals(""))
            {
                DataRow[] arr_produto = tbProduto.Select($"id_produto = {cod_produto}");
                if (arr_produto.Length > 0)
                {
                    zerarInformacoesProdutoSelecionado();
                    DataRow produto = arr_produto[0];

                    string chr_path_foto = "" + produto["chr_path_foto"];
                    if (!chr_path_foto.Equals(""))
                    {
                        Image image = Image.FromFile(chr_path_foto);
                        pictureFoto.Image = image;
                        pictureFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        //Sem ação para esse caso de uso!
                    }

                    lblTituloPrincipal.Text = "Produto: " + produto["chr_produto"];

                    txtCodProduto.Text = cod_produto;
                    txtQuantidade.Text = "1";
                    txtValorUnitario.Text = double.Parse("0" + produto["flo_preco"]).ToString("C");
                    txtValorTotalProduto.Text = txtValorUnitario.Text;
                }
                else
                {
                    MessageBox.Show("Não foi encontrado nenhum produto com esse código");
                }
            }
            else
            {
                MessageBox.Show("Digitar um código é obrigatório para selecionar um produto.");
            }

        }

        private void adicionarItemNoCupom()
        {
            string id_produto_select = txtCodProduto.Text;
            DataRow[] arr_produtos = tbProduto.Select($"id_produto = {id_produto_select}");
            if (arr_produtos.Length > 0)
            {
                DataRow produto = arr_produtos[0];

                if (double.Parse("0" + produto["flo_estoque"]) >= double.Parse(txtQuantidade.Text))
                {
                    list_itens_venda.Add(new
                    {
                        id_produto = id_produto_select,
                        flo_quantidade = txtQuantidade.Text,
                        flo_preco_log = "" + produto["flo_preco"],
                        chr_produto_log = "" + produto["chr_produto"]
                    });

                    listarItensCupom();
                }
                else
                {
                    MessageBox.Show("Não é possível adicionar essa quantidade seu estoque é de: " + produto["flo_estoque"] + " itens");
                }
            }
            else
            {
                MessageBox.Show("O produto não foi encontrado, tente novamente!");
            }
        }

        private void listarItensCupom()
        {

            if (list_itens_venda.Count > 0)
            {
                if (gridListagemCupom.Columns.Count == 0)
                {
                    gridListagemCupom.Columns.Add("cod_produto", "Cod Produto");
                    gridListagemCupom.Columns.Add("chr_produto", "Produto");
                    gridListagemCupom.Columns.Add("flo_qtd", "Quantidade");
                    gridListagemCupom.Columns.Add("flo_valor_unit", "Valor Unitario");
                    gridListagemCupom.Columns.Add("flo_valor_total", "Valor Total");


                    gridListagemCupom.Columns["cod_produto"].Width = 50;
                    gridListagemCupom.Columns["chr_produto"].Width = 100;
                    gridListagemCupom.Columns["flo_qtd"].Width = 50;
                }

                if (gridListagemCupom.Rows.Count > 0)
                    gridListagemCupom.Rows.Clear();

                double flo_sub_total = 0;

                foreach (dynamic item in list_itens_venda)
                {
                    string id_produto = item.id_produto;
                    string flo_quantidade = item.flo_quantidade;
                    string flo_preco_log = item.flo_preco_log;
                    string chr_produto_log = item.chr_produto_log;

                    double flo_valor_total = double.Parse(flo_quantidade) * double.Parse(flo_preco_log);

                    flo_sub_total += flo_valor_total;

                    flo_preco_log = double.Parse(flo_preco_log).ToString("c");
                    gridListagemCupom.Rows.Add(id_produto, chr_produto_log, flo_quantidade, flo_preco_log, flo_valor_total.ToString("c"));
                }

                lblSubTotalValor.Text = flo_sub_total.ToString("c");
            }
            else
            {
                MessageBox.Show("Não existe ainda nenhum produto adicionado a lista de cupons!");
            }

        }

        private void zerarTela()
        {
            gridListagemCupom.Rows.Clear();
            zerarInformacoesProdutoSelecionado();
            list_itens_venda = new List<object>();
        }

        private void btnFecharAuxiliadorCodigo_Click(object sender, EventArgs e)
        {
            gbCodProdutoAuxilio.Visible = false;
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (list_itens_venda.Count > 0)
            {

                string id_cliente = Util.retornaValorSelecionado(comboClientes).Value;

                if (!id_cliente.Equals("'"))
                {
                    //Insere a venda - INI
                    TransactSQL venda = new TransactSQL();
                    venda.add("id_cliente", id_cliente, false);
                    venda.add("chr_obs", "Venda inserida via sistema");
                    venda.add("dt_venda", DateTime.Now.ToString("yyyy-MM-dd"));
                    venda.insert("tbVenda");
                    string id_venda = "" + venda.exec();
                    //Insere a venda - FIM


                    //Insere itens da venda - INI
                    StringBuilder script_insert_itens = new StringBuilder();
                    script_insert_itens.Append("BEGIN;");

                    foreach (dynamic item in list_itens_venda)
                    {
                        string id_produto = item.id_produto;
                        string flo_quantidade = item.flo_quantidade;
                        string flo_preco_log = item.flo_preco_log;
                        string chr_produto_log = item.chr_produto_log;

                        TransactSQL Vendaitem = new TransactSQL();
                        Vendaitem.add("id_venda", id_venda, false);
                        Vendaitem.add("id_produto", id_produto, false);
                        Vendaitem.add("chr_produto_log", "'" + chr_produto_log + "'", false);
                        Vendaitem.add("flo_quantidade", flo_quantidade, false);
                        Vendaitem.add("flo_preco_log", flo_preco_log, false);
                        Vendaitem.insert("tbvendaitem", false);

                        script_insert_itens.AppendLine(Vendaitem.str_instrucao_sql + ";");
                    }

                    script_insert_itens.AppendLine("COMMIT;");


                    Conexao c = new Conexao();
                    NpgsqlDataReader ndr = c.Ndr(script_insert_itens.ToString());
                    if (ndr.Read() || ndr.Rows > 0)
                    {

                        MessageBox.Show("Venda realizada com sucesso!");
                        retirarItemEstoque();
                        zerarTela();
                    }
                    else
                    {
                        MessageBox.Show("Houve um problema para finalizar a venda, entre em contato com a equipe de desenvolvimento!");
                    }
                    c.encerrarConexao();
                    //Insere itens da venda - FIM

                }
                else
                {
                    MessageBox.Show("Para realizar uma venda é obrigatório escolher o cliente!");
                }


            }
            else
            {
                MessageBox.Show("Não existe ainda nenhum produto adicionado a lista de cupons!");
            }
        }













        //Métodos auxiliares que não são de responsabilidade do fluxo principal de vendas

        /// <summary>
        /// Esse método será responsavel por retirar a quantidade solicitada do estoque do produto.
        /// </summary>
        private void retirarItemEstoque()
        {
            //Como não existe nada especifico para o estoque então só uma retirada da tabela vai servir.
            //Para uma evolução se faz necessario alguma tabela de log para acompanhar as transações.
            StringBuilder script_insert_update = new StringBuilder();
            script_insert_update.Append("BEGIN;");
            foreach (dynamic item in list_itens_venda)
            {
                string id_produto = item.id_produto;
                string flo_quantidade = item.flo_quantidade;
                string flo_preco_log = item.flo_preco_log;
                string chr_produto_log = item.chr_produto_log;

                TransactSQL uProduto = new TransactSQL();
                uProduto.add("flo_estoque", "flo_estoque - " + flo_quantidade, false);
                uProduto.where("id_produto", id_produto);
                uProduto.update("tbproduto");
                script_insert_update.AppendLine(uProduto.str_instrucao_sql + ";");
            }

            script_insert_update.AppendLine("COMMIT;");


            Conexao c = new Conexao();
            NpgsqlDataReader ndr = c.Ndr(script_insert_update.ToString());
            if (ndr.Read() || ndr.Rows > 0)
            {

            }
            else
            {
                MessageBox.Show("Houve um problema para retirar itens em estoque, entre em contato com a equipe de desenvolvimento!");
            }
            c.encerrarConexao();

        }



    }
}
