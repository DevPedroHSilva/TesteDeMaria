namespace VendasJa.Produto
{
    partial class CadastroProduto
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
            txtEstoqueInicial = new TextBox();
            lblEstoque = new Label();
            txtPreco = new TextBox();
            lblPreco = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtProduto = new TextBox();
            lblNome = new Label();
            label1 = new Label();
            gpAcoes = new GroupBox();
            btnCancelar = new Button();
            btnInserir = new Button();
            lblTitulo = new Label();
            btnUpload = new Button();
            lblUploadAcompanhamento = new Label();
            lblUpload = new Label();
            pictureVisualizacao = new PictureBox();
            gbVisualizacao = new GroupBox();
            gpAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureVisualizacao).BeginInit();
            gbVisualizacao.SuspendLayout();
            SuspendLayout();
            // 
            // txtEstoqueInicial
            // 
            txtEstoqueInicial.Location = new Point(381, 130);
            txtEstoqueInicial.Name = "txtEstoqueInicial";
            txtEstoqueInicial.PlaceholderText = "0";
            txtEstoqueInicial.Size = new Size(247, 27);
            txtEstoqueInicial.TabIndex = 36;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstoque.Location = new Point(366, 104);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(124, 23);
            lblEstoque.TabIndex = 35;
            lblEstoque.Text = "Estoque Inicial:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(41, 208);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(247, 27);
            txtPreco.TabIndex = 34;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(26, 182);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(53, 23);
            lblPreco.TabIndex = 33;
            lblPreco.Text = "Preço";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(41, 297);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(247, 116);
            txtDescricao.TabIndex = 30;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(26, 271);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(87, 23);
            lblDescricao.TabIndex = 29;
            lblDescricao.Text = "Descrição:";
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(41, 130);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(247, 27);
            txtProduto.TabIndex = 28;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(26, 104);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(160, 23);
            lblNome.TabIndex = 27;
            lblNome.Text = "*Nome do Produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(21, 53);
            label1.Name = "label1";
            label1.Size = new Size(278, 20);
            label1.TabIndex = 26;
            label1.Text = "Todos os campos com (*) são obrigatórios";
            // 
            // gpAcoes
            // 
            gpAcoes.BackColor = SystemColors.GradientInactiveCaption;
            gpAcoes.Controls.Add(btnCancelar);
            gpAcoes.Controls.Add(btnInserir);
            gpAcoes.Location = new Point(0, 499);
            gpAcoes.Name = "gpAcoes";
            gpAcoes.Size = new Size(882, 55);
            gpAcoes.TabIndex = 25;
            gpAcoes.TabStop = false;
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
            // btnInserir
            // 
            btnInserir.BackColor = Color.Honeydew;
            btnInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.Location = new Point(708, 11);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(162, 29);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(315, 44);
            lblTitulo.TabIndex = 24;
            lblTitulo.Text = "Cadastro de Produtos";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(381, 221);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(94, 29);
            btnUpload.TabIndex = 37;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // lblUploadAcompanhamento
            // 
            lblUploadAcompanhamento.AutoEllipsis = true;
            lblUploadAcompanhamento.Location = new Point(513, 194);
            lblUploadAcompanhamento.Name = "lblUploadAcompanhamento";
            lblUploadAcompanhamento.Size = new Size(322, 20);
            lblUploadAcompanhamento.TabIndex = 38;
            lblUploadAcompanhamento.Text = "Nenhum arquivo selecionado";
            // 
            // lblUpload
            // 
            lblUpload.AutoSize = true;
            lblUpload.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpload.Location = new Point(366, 192);
            lblUpload.Name = "lblUpload";
            lblUpload.Size = new Size(141, 23);
            lblUpload.TabIndex = 39;
            lblUpload.Text = "Foto do Produto:";
            // 
            // pictureVisualizacao
            // 
            pictureVisualizacao.Location = new Point(7, 26);
            pictureVisualizacao.Name = "pictureVisualizacao";
            pictureVisualizacao.Size = new Size(297, 192);
            pictureVisualizacao.SizeMode = PictureBoxSizeMode.Zoom;
            pictureVisualizacao.TabIndex = 40;
            pictureVisualizacao.TabStop = false;
            // 
            // gbVisualizacao
            // 
            gbVisualizacao.Controls.Add(pictureVisualizacao);
            gbVisualizacao.Location = new Point(374, 256);
            gbVisualizacao.Name = "gbVisualizacao";
            gbVisualizacao.Size = new Size(310, 224);
            gbVisualizacao.TabIndex = 41;
            gbVisualizacao.TabStop = false;
            gbVisualizacao.Text = "Visualização Prévia";
            gbVisualizacao.Visible = false;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 553);
            Controls.Add(gbVisualizacao);
            Controls.Add(lblUpload);
            Controls.Add(lblUploadAcompanhamento);
            Controls.Add(btnUpload);
            Controls.Add(txtEstoqueInicial);
            Controls.Add(lblEstoque);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtProduto);
            Controls.Add(lblNome);
            Controls.Add(label1);
            Controls.Add(gpAcoes);
            Controls.Add(lblTitulo);
            Name = "CadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroProduto";
            gpAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureVisualizacao).EndInit();
            gbVisualizacao.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEstoqueInicial;
        private Label lblEstoque;
        private TextBox txtPreco;
        private Label lblPreco;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtProduto;
        private Label lblNome;
        private Label label1;
        private GroupBox gpAcoes;
        private Button btnCancelar;
        private Button btnInserir;
        private Label lblTitulo;
        private Button btnUpload;
        private Label lblUploadAcompanhamento;
        private Label lblUpload;
        private PictureBox pictureVisualizacao;
        private GroupBox gbVisualizacao;
    }
}