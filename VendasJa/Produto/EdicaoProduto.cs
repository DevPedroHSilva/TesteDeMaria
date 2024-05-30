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

namespace VendasJa.Produto
{
    public partial class EdicaoProduto : Form
    {
        //Todas as paginas filhas da pesquisa exceto a pagina de pesquisa tem que ter essa variavel!
        public string id_page;

        public EdicaoProduto()
        {
            InitializeComponent();

            this.Activated += page_load;
            this.FormClosing += new FormClosingEventHandler(fecharFormulario);
        }

        private void fecharFormulario(object sender, FormClosingEventArgs e)
        {
            Session.Instance.Remove("id"); //Remove a instancia para não haver conflito de dados.
            PesquisaProduto pesquisaProduto = new PesquisaProduto();
            pesquisaProduto.Show();
        }

        private void abrirFormularioPesquisa()
        {
            this.Hide();
            PesquisaProduto pesquisaProduto = new PesquisaProduto();
            pesquisaProduto.Show();
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

            lblTitulo.Text = "Editando os dados do Produto: " + id_page;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProduto.Text.Equals(""))
                {
                    MessageBox.Show("Os campos obrigatórios devem ser preenchidos!");
                }
                else
                {
                    string filePath = lblUploadAcompanhamento.Text;

                    TransactSQL uProduto = new TransactSQL();
                    uProduto.add("chr_produto", txtProduto.Text);
                    uProduto.add("chr_descricao", txtDescricao.Text);
                    uProduto.add("flo_preco", Double.Parse("0" + txtPreco.Text).ToString(), false);
                    if (!filePath.Equals("") && !filePath.Equals("Nenhum arquivo selecionado")) //Se for diferente de vazio ele esta salvando uma nova imagem!
                        uProduto.add("chr_path_foto", Util.salvarImagemComBaseId(id_page, filePath));
                    uProduto.where("id_produto", id_page);
                    uProduto.update("tbproduto");
                    uProduto.exec();

                    MessageBox.Show("Produto atualizado com sucesso!");
                    abrirFormularioPesquisa();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, problema inesperado ao atualizar este produto! entre em contato com a equipe de desnevolvimento!");
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir este registro?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TransactSQL eCliente = new TransactSQL();
                eCliente.where("id_produto", id_page);
                eCliente.delete("tbproduto");
                eCliente.exec();

                abrirFormularioPesquisa();
                MessageBox.Show("Registro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //sem ação definida
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            abrirFormularioPesquisa();
        }



        public void carregarDados()
        {
            Conexao c = new Conexao();
            DataRow rProduto = c.DataRow("select * from tbproduto where id_produto = " + id_page);
            if (rProduto != null)
            {
                txtProduto.Text = "" + rProduto["chr_produto"];
                txtDescricao.Text = "" + rProduto["chr_descricao"];
                txtPreco.Text = "" + rProduto["flo_preco"];
                lblEstoqueValue.Text = "" + rProduto["flo_estoque"];


                string chr_path_foto = "" + rProduto["chr_path_foto"];
                if (!chr_path_foto.Equals(""))
                {
                    Image image = Image.FromFile(chr_path_foto);
                    pictureImgAtual.Image = image;
                    pictureImgAtual.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    gbImagemAtual.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel encontrar esse registro!");
                abrirFormularioPesquisa();
            }
            c.encerrarConexao();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string filePath = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtenha o caminho completo do arquivo selecionado
                    filePath = openFileDialog.FileName;

                    // Mostre o caminho do arquivo em um label
                    lblUploadAcompanhamento.Text = filePath;

                    // Carregue a imagem no PictureBox
                    pictureVisualizacao.Image = Image.FromFile(filePath);

                    gbVisualizacao.Visible = true;
                }
            }
        }
    }
}
