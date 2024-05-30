namespace VendasJa.Produto
{
    partial class EdicaoProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProduto = new TextBox();
            lblProduto = new Label();
            label1 = new Label();
            gpAcoes = new GroupBox();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnAtualizar = new Button();
            lblTitulo = new Label();
            txtPreco = new TextBox();
            lblPreco = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            gbImagemAtual = new GroupBox();
            pictureImgAtual = new PictureBox();
            lblUpload = new Label();
            lblUploadAcompanhamento = new Label();
            btnUpload = new Button();
            lblEstoque = new Label();
            lblEstoqueValue = new Label();
            gbVisualizacao = new GroupBox();
            pictureVisualizacao = new PictureBox();
            gpAcoes.SuspendLayout();
            gbImagemAtual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureImgAtual).BeginInit();
            gbVisualizacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureVisualizacao).BeginInit();
            SuspendLayout();
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(41, 130);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(247, 27);
            txtProduto.TabIndex = 47;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduto.Location = new Point(26, 104);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(83, 23);
            lblProduto.TabIndex = 46;
            lblProduto.Text = "*Produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(21, 53);
            label1.Name = "label1";
            label1.Size = new Size(278, 20);
            label1.TabIndex = 45;
            label1.Text = "Todos os campos com (*) são obrigatórios";
            // 
            // gpAcoes
            // 
            gpAcoes.BackColor = SystemColors.GradientInactiveCaption;
            gpAcoes.Controls.Add(btnExcluir);
            gpAcoes.Controls.Add(btnCancelar);
            gpAcoes.Controls.Add(btnAtualizar);
            gpAcoes.Location = new Point(0, 499);
            gpAcoes.Name = "gpAcoes";
            gpAcoes.Size = new Size(882, 55);
            gpAcoes.TabIndex = 44;
            gpAcoes.TabStop = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = SystemColors.ButtonHighlight;
            btnExcluir.Location = new Point(361, 13);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(162, 29);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gainsboro;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(12, 11);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Honeydew;
            btnAtualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(708, 11);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(162, 29);
            btnAtualizar.TabIndex = 0;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(265, 44);
            lblTitulo.TabIndex = 43;
            lblTitulo.Text = "Edição de produto";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(41, 214);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(247, 27);
            txtPreco.TabIndex = 51;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(26, 188);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(53, 23);
            lblPreco.TabIndex = 50;
            lblPreco.Text = "Preço";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(41, 303);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(247, 116);
            txtDescricao.TabIndex = 49;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(26, 277);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(87, 23);
            lblDescricao.TabIndex = 48;
            lblDescricao.Text = "Descrição:";
            // 
            // gbImagemAtual
            // 
            gbImagemAtual.Controls.Add(pictureImgAtual);
            gbImagemAtual.Location = new Point(410, 188);
            gbImagemAtual.Name = "gbImagemAtual";
            gbImagemAtual.Size = new Size(221, 173);
            gbImagemAtual.TabIndex = 57;
            gbImagemAtual.TabStop = false;
            gbImagemAtual.Text = "Imagem Atual";
            // 
            // pictureImgAtual
            // 
            pictureImgAtual.Location = new Point(7, 26);
            pictureImgAtual.Name = "pictureImgAtual";
            pictureImgAtual.Size = new Size(204, 137);
            pictureImgAtual.SizeMode = PictureBoxSizeMode.Zoom;
            pictureImgAtual.TabIndex = 40;
            pictureImgAtual.TabStop = false;
            // 
            // lblUpload
            // 
            lblUpload.AutoSize = true;
            lblUpload.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpload.Location = new Point(410, 104);
            lblUpload.Name = "lblUpload";
            lblUpload.Size = new Size(141, 23);
            lblUpload.TabIndex = 56;
            lblUpload.Text = "Foto do Produto:";
            // 
            // lblUploadAcompanhamento
            // 
            lblUploadAcompanhamento.AutoEllipsis = true;
            lblUploadAcompanhamento.Location = new Point(557, 106);
            lblUploadAcompanhamento.Name = "lblUploadAcompanhamento";
            lblUploadAcompanhamento.Size = new Size(322, 20);
            lblUploadAcompanhamento.TabIndex = 55;
            lblUploadAcompanhamento.Text = "Nenhum arquivo selecionado";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(425, 133);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(94, 29);
            btnUpload.TabIndex = 54;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(26, 440);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(120, 23);
            lblEstoque.TabIndex = 52;
            lblEstoque.Text = "Estoque Atual:";
            // 
            // lblEstoqueValue
            // 
            lblEstoqueValue.AutoSize = true;
            lblEstoqueValue.Location = new Point(152, 443);
            lblEstoqueValue.Name = "lblEstoqueValue";
            lblEstoqueValue.Size = new Size(17, 20);
            lblEstoqueValue.TabIndex = 58;
            lblEstoqueValue.Text = "0";
            // 
            // gbVisualizacao
            // 
            gbVisualizacao.Controls.Add(pictureVisualizacao);
            gbVisualizacao.Location = new Point(649, 188);
            gbVisualizacao.Name = "gbVisualizacao";
            gbVisualizacao.Size = new Size(221, 173);
            gbVisualizacao.TabIndex = 58;
            gbVisualizacao.TabStop = false;
            gbVisualizacao.Text = "Visualização Prévia";
            gbVisualizacao.Visible = false;
            // 
            // pictureVisualizacao
            // 
            pictureVisualizacao.Location = new Point(7, 26);
            pictureVisualizacao.Name = "pictureVisualizacao";
            pictureVisualizacao.Size = new Size(204, 137);
            pictureVisualizacao.SizeMode = PictureBoxSizeMode.Zoom;
            pictureVisualizacao.TabIndex = 40;
            pictureVisualizacao.TabStop = false;
            // 
            // EdicaoProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 553);
            Controls.Add(gbVisualizacao);
            Controls.Add(lblEstoqueValue);
            Controls.Add(gbImagemAtual);
            Controls.Add(lblUpload);
            Controls.Add(lblUploadAcompanhamento);
            Controls.Add(btnUpload);
            Controls.Add(lblEstoque);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtProduto);
            Controls.Add(lblProduto);
            Controls.Add(label1);
            Controls.Add(gpAcoes);
            Controls.Add(lblTitulo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EdicaoProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EdicaoProduto";
            gpAcoes.ResumeLayout(false);
            gbImagemAtual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureImgAtual).EndInit();
            gbVisualizacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureVisualizacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtProduto;
        private Label lblProduto;
        private Label label1;
        private GroupBox gpAcoes;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnAtualizar;
        private Label lblTitulo;
        private TextBox txtPreco;
        private Label lblPreco;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private GroupBox gbImagemAtual;
        private PictureBox pictureImgAtual;
        private Label lblUpload;
        private Label lblUploadAcompanhamento;
        private Button btnUpload;
        private Label lblEstoque;
        private Label lblEstoqueValue;
        private GroupBox gbVisualizacao;
        private PictureBox pictureVisualizacao;
    }
}