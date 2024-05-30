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

namespace VendasJa.Cliente
{
    public partial class EdicaoCliente : Form
    {
        //Todas as paginas filhas da pesquisa exceto a pagina de pesquisa tem que ter essa variavel!
        public string id_page;

        public EdicaoCliente()
        {
            InitializeComponent();

            this.Activated += page_load;
            this.FormClosing += new FormClosingEventHandler(fecharFormulario);
        }

        private void fecharFormulario(object sender, FormClosingEventArgs e)
        {
            Session.Instance.Remove("id"); //Remove a instancia para não haver conflito de dados.
            PesquisaCliente pesquisaCliente = new PesquisaCliente();
            pesquisaCliente.Show();
        }

        private void abrirFormularioPesquisa()
        {
            this.Hide();
            PesquisaCliente pesquisaCliente = new PesquisaCliente();
            pesquisaCliente.Show();
        }


        private void page_load(object sender, EventArgs e)
        {
            this.id_page = "" + Session.Instance["id"];//Recupera o valor da instancia pra ser usado novamente


            if (this.id_page.Equals(""))
            {
                MessageBox.Show("Não foi encontrado nenhum registro, tente novamente!");

                abrirFormularioPesquisa();
            }
            else
            {
                carregarDados();
            }

            lblTitulo.Text = "Editando os dados do cliente: " + id_page;
        }


        private void carregarDados()
        {
            Conexao c = new Conexao();
            DataRow rCliente = c.DataRow("select * from tbcliente where id_cliente = " + id_page);
            if (rCliente != null)
            {
                txtNome.Text = "" + rCliente["chr_cliente"];
                txtEmail.Text = "" + rCliente["chr_email"];
                txtFone.Text = "" + rCliente["chr_fone"];
                txtCEP.Text = "" + rCliente["chr_cep"];
                txtEndereco.Text = "" + rCliente["chr_endereco"];
                txtBairro.Text = "" + rCliente["chr_bairro"];
                txtComplemento.Text = "" + rCliente["chr_complemento"];
                txtNumero.Text = "" + rCliente["chr_numero"];
            }
            else
            {
                MessageBox.Show("Não foi possivel encontrar esse registro!");
                abrirFormularioPesquisa();
            }
            c.encerrarConexao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            abrirFormularioPesquisa();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TransactSQL eCliente = new TransactSQL();
                eCliente.where("id_cliente", id_page);
                eCliente.delete("tbcliente");
                eCliente.exec();

                abrirFormularioPesquisa();
                MessageBox.Show("Registro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //sem ação definida
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text.Equals("") || txtFone.Text.Equals(""))
                {
                    MessageBox.Show("Os campos obrigatórios devem ser preenchidos!");
                }
                else
                {

                    TransactSQL uCliente = new TransactSQL();
                    uCliente.add("chr_cliente", txtNome.Text);
                    uCliente.add("chr_email", txtEmail.Text);
                    uCliente.add("chr_fone", txtFone.Text);
                    uCliente.add("chr_cep", txtCEP.Text);
                    uCliente.add("chr_endereco", txtEndereco.Text);
                    uCliente.add("chr_bairro", txtBairro.Text);
                    uCliente.add("chr_numero", txtNumero.Text);
                    uCliente.add("chr_complemento", txtComplemento.Text);
                    uCliente.where("id_cliente", id_page);
                    uCliente.exec();

                    MessageBox.Show("Cliente atualizado com sucesso!");
                    abrirFormularioPesquisa();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, problema inesperado ao atualizar este produto! entre em contato com a equipe de desnevolvimento!");
            }
        }
    }
}
