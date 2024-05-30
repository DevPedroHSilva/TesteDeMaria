using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendasJa.Produto
{
    public partial class CadastroProduto : Form
    {
        string chr_produto = "";
        string flo_preco = "";
        string chr_descricao = "";
        string flo_estoque = "";

        public CadastroProduto()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(fecharFormulario);
            this.Activated += page_load;
        }

        private void page_load(object sender, EventArgs e)
        {

        }

        private void fecharFormulario(object sender, FormClosingEventArgs e)
        {
            PesquisaProduto pesquisaProduto = new PesquisaProduto();
            pesquisaProduto.Show();
        }

        private void zerarCamposTela()
        {
            txtProduto.Text = "";
            txtPreco.Text = "";
            txtDescricao.Text = "";
            txtEstoqueInicial.Text = "";

            lblUploadAcompanhamento.Text = "";
            gbVisualizacao.Visible = false;
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

        private void btnInserir_Click(object sender, EventArgs e)
        {

            chr_produto = txtProduto.Text;
            flo_preco = txtPreco.Text;
            chr_descricao = txtDescricao.Text;
            flo_estoque = txtEstoqueInicial.Text;

            if (chr_produto.Equals(""))
            {
                MessageBox.Show("Os campos obrigatórios devem ser preenchidos!");
            }
            else
            {
                TransactSQL iProduto = new TransactSQL();
                iProduto.add("chr_produto", chr_produto);
                iProduto.add("chr_descricao", chr_descricao);
                iProduto.add("flo_preco", double.Parse("0" + flo_preco).ToString(), false);
                iProduto.add("flo_estoque", double.Parse("0" + flo_estoque).ToString(), false);
                iProduto.insert("tbproduto");
                string id_produto = iProduto.exec();


                string chr_path_foto = Util.salvarImagemComBaseId(id_produto, lblUploadAcompanhamento.Text);

                if(!chr_path_foto.Equals(""))
                {
                    //Atualiza para adicionar o path ao produto
                    TransactSQL uProduto = new TransactSQL();
                    uProduto.add("chr_path_foto", chr_path_foto);
                    uProduto.where("id_produto", id_produto);
                    uProduto.update("tbproduto");
                    uProduto.exec();
                }

                MessageBox.Show("Produto inserido com sucesso!");
                zerarCamposTela();
                this.Hide();
                PesquisaProduto pesquisaProduto = new PesquisaProduto();
                pesquisaProduto.Show();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PesquisaProduto pesquisaProduto = new PesquisaProduto();
            pesquisaProduto.Show();
        }
    }
}
