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
    public partial class CadastroCliente : Form
    {
        string chr_cliente = "";
        string chr_email = "";
        string chr_fone = "";
        string chr_cep = "";
        string chr_endereco = "";
        string chr_bairro = "";
        string chr_complemento = "";
        string chr_numero = "";

        public CadastroCliente()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(fecharFormulario);

        }

        public void zerarCamposTela()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtFone.Text = "";
            txtCEP.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
            txtNumero.Text = "";
        }

        private void fecharFormulario(object sender, FormClosingEventArgs e)
        {
            PesquisaCliente pesquisaCliente = new PesquisaCliente();
            pesquisaCliente.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PesquisaCliente pesquisaCliente = new PesquisaCliente();
            pesquisaCliente.Show();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Carregando dados do formulário
            chr_cliente = txtNome.Text;
            chr_email = txtEmail.Text;
            chr_fone = txtFone.Text;
            chr_cep = txtCEP.Text;
            chr_endereco = txtEndereco.Text;
            chr_bairro = txtBairro.Text;
            chr_complemento = txtComplemento.Text;
            chr_numero = txtNumero.Text;


            //Validar os dados 

            if (chr_cliente.Equals("") || chr_fone.Equals(""))
            {
                MessageBox.Show("Os campos obrigatórios devem ser preenchidos!");
            }
            else
            {
                try
                {
                    TransactSQL iCliente = new TransactSQL();
                    iCliente.add("chr_cliente", chr_cliente);
                    iCliente.add("chr_email", chr_email);
                    iCliente.add("chr_fone", chr_fone);
                    iCliente.add("chr_cep", chr_cep);
                    iCliente.add("chr_endereco", chr_endereco);
                    iCliente.add("chr_bairro", chr_bairro);
                    iCliente.add("chr_numero", chr_numero);
                    iCliente.add("chr_complemento", chr_complemento);
                    iCliente.insert("tbcliente");
                    string id_cliente = iCliente.exec();
                    MessageBox.Show("Cliente inserido com sucesso!");
                    zerarCamposTela();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ouve um problema ao inserir, entre em contato com a equipe de desenvolvimento!");

                }


            }

        }
    }
}
