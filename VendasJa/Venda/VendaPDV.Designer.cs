namespace VendasJa.Venda
{
    partial class VendaPDV
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
            gbTituloPrincipal = new GroupBox();
            lblTituloPrincipal = new Label();
            pictureFoto = new PictureBox();
            txtCodProduto = new TextBox();
            gbCupom = new GroupBox();
            gridListagemCupom = new DataGridView();
            lblTituloCupom = new Label();
            lblTituloCodigoProduto = new Label();
            lblSubTotalValor = new Label();
            label2 = new Label();
            txtQuantidade = new TextBox();
            lblValorUnitario = new Label();
            txtValorUnitario = new TextBox();
            lblTotalProduto = new Label();
            txtValorTotalProduto = new TextBox();
            label5 = new Label();
            btnFinalizarVenda = new Button();
            lblCliente = new Label();
            comboClientes = new ComboBox();
            gbCodProdutoAuxilio = new GroupBox();
            btnFecharAuxiliadorCodigo = new Button();
            gridAuxilioCodigo = new DataGridView();
            gbFooter = new GroupBox();
            lblAuxiliadorCodProduto = new Label();
            gbTituloPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).BeginInit();
            gbCupom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridListagemCupom).BeginInit();
            gbCodProdutoAuxilio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAuxilioCodigo).BeginInit();
            gbFooter.SuspendLayout();
            SuspendLayout();
            // 
            // gbTituloPrincipal
            // 
            gbTituloPrincipal.Controls.Add(lblTituloPrincipal);
            gbTituloPrincipal.Location = new Point(32, 12);
            gbTituloPrincipal.Name = "gbTituloPrincipal";
            gbTituloPrincipal.Size = new Size(1190, 55);
            gbTituloPrincipal.TabIndex = 0;
            gbTituloPrincipal.TabStop = false;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPrincipal.Location = new Point(402, 10);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(403, 37);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "Digite o código de um produto!";
            // 
            // pictureFoto
            // 
            pictureFoto.Location = new Point(32, 183);
            pictureFoto.Name = "pictureFoto";
            pictureFoto.Size = new Size(347, 338);
            pictureFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFoto.TabIndex = 1;
            pictureFoto.TabStop = false;
            // 
            // txtCodProduto
            // 
            txtCodProduto.Location = new Point(422, 129);
            txtCodProduto.Name = "txtCodProduto";
            txtCodProduto.Size = new Size(322, 23);
            txtCodProduto.TabIndex = 1;
            // 
            // gbCupom
            // 
            gbCupom.Controls.Add(gridListagemCupom);
            gbCupom.Controls.Add(lblTituloCupom);
            gbCupom.Location = new Point(790, 84);
            gbCupom.Name = "gbCupom";
            gbCupom.Size = new Size(426, 433);
            gbCupom.TabIndex = 2;
            gbCupom.TabStop = false;
            // 
            // gridListagemCupom
            // 
            gridListagemCupom.BackgroundColor = Color.White;
            gridListagemCupom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridListagemCupom.Location = new Point(6, 45);
            gridListagemCupom.Name = "gridListagemCupom";
            gridListagemCupom.Size = new Size(414, 382);
            gridListagemCupom.TabIndex = 1;
            // 
            // lblTituloCupom
            // 
            lblTituloCupom.BackColor = SystemColors.ActiveCaption;
            lblTituloCupom.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCupom.ForeColor = Color.White;
            lblTituloCupom.Location = new Point(0, 10);
            lblTituloCupom.Name = "lblTituloCupom";
            lblTituloCupom.Size = new Size(426, 35);
            lblTituloCupom.TabIndex = 0;
            lblTituloCupom.Text = "Cupom";
            lblTituloCupom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloCodigoProduto
            // 
            lblTituloCodigoProduto.AutoSize = true;
            lblTituloCodigoProduto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCodigoProduto.Location = new Point(412, 101);
            lblTituloCodigoProduto.Name = "lblTituloCodigoProduto";
            lblTituloCodigoProduto.Size = new Size(225, 25);
            lblTituloCodigoProduto.TabIndex = 3;
            lblTituloCodigoProduto.Text = "Código do Produto - [F5]";
            // 
            // lblSubTotalValor
            // 
            lblSubTotalValor.BackColor = SystemColors.ActiveCaption;
            lblSubTotalValor.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotalValor.ForeColor = Color.White;
            lblSubTotalValor.Location = new Point(790, 514);
            lblSubTotalValor.Name = "lblSubTotalValor";
            lblSubTotalValor.Size = new Size(426, 35);
            lblSubTotalValor.TabIndex = 2;
            lblSubTotalValor.Text = "R$ 0,00";
            lblSubTotalValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(412, 183);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 6;
            label2.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(422, 211);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(322, 23);
            txtQuantidade.TabIndex = 5;
            // 
            // lblValorUnitario
            // 
            lblValorUnitario.AutoSize = true;
            lblValorUnitario.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorUnitario.Location = new Point(412, 268);
            lblValorUnitario.Name = "lblValorUnitario";
            lblValorUnitario.Size = new Size(130, 25);
            lblValorUnitario.TabIndex = 8;
            lblValorUnitario.Text = "Valor Unitário";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(422, 296);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.ReadOnly = true;
            txtValorUnitario.Size = new Size(322, 23);
            txtValorUnitario.TabIndex = 7;
            // 
            // lblTotalProduto
            // 
            lblTotalProduto.AutoSize = true;
            lblTotalProduto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProduto.Location = new Point(412, 356);
            lblTotalProduto.Name = "lblTotalProduto";
            lblTotalProduto.Size = new Size(203, 25);
            lblTotalProduto.TabIndex = 10;
            lblTotalProduto.Text = "Valor Total do Produto";
            // 
            // txtValorTotalProduto
            // 
            txtValorTotalProduto.Location = new Point(422, 384);
            txtValorTotalProduto.Name = "txtValorTotalProduto";
            txtValorTotalProduto.ReadOnly = true;
            txtValorTotalProduto.Size = new Size(322, 23);
            txtValorTotalProduto.TabIndex = 9;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(419, 491);
            label5.Name = "label5";
            label5.Size = new Size(325, 23);
            label5.TabIndex = 11;
            label5.Text = "**Clique na tecla [F10] para adicionar o item no cupom";
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.BackColor = Color.MintCream;
            btnFinalizarVenda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarVenda.Location = new Point(790, 563);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(426, 36);
            btnFinalizarVenda.TabIndex = 12;
            btnFinalizarVenda.Text = "Finalizar Venda";
            btnFinalizarVenda.UseVisualStyleBackColor = false;
            btnFinalizarVenda.Click += btnFinalizarVenda_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(32, 101);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(72, 25);
            lblCliente.TabIndex = 13;
            lblCliente.Text = "Cliente";
            // 
            // comboClientes
            // 
            comboClientes.FormattingEnabled = true;
            comboClientes.Location = new Point(49, 127);
            comboClientes.Name = "comboClientes";
            comboClientes.Size = new Size(309, 23);
            comboClientes.TabIndex = 14;
            // 
            // gbCodProdutoAuxilio
            // 
            gbCodProdutoAuxilio.Controls.Add(btnFecharAuxiliadorCodigo);
            gbCodProdutoAuxilio.Controls.Add(gridAuxilioCodigo);
            gbCodProdutoAuxilio.Location = new Point(12, 87);
            gbCodProdutoAuxilio.Name = "gbCodProdutoAuxilio";
            gbCodProdutoAuxilio.Size = new Size(367, 446);
            gbCodProdutoAuxilio.TabIndex = 15;
            gbCodProdutoAuxilio.TabStop = false;
            gbCodProdutoAuxilio.Text = "Produtos existentes";
            gbCodProdutoAuxilio.Visible = false;
            // 
            // btnFecharAuxiliadorCodigo
            // 
            btnFecharAuxiliadorCodigo.BackColor = Color.MistyRose;
            btnFecharAuxiliadorCodigo.Location = new Point(104, 404);
            btnFecharAuxiliadorCodigo.Name = "btnFecharAuxiliadorCodigo";
            btnFecharAuxiliadorCodigo.Size = new Size(146, 26);
            btnFecharAuxiliadorCodigo.TabIndex = 1;
            btnFecharAuxiliadorCodigo.Text = "Fechar";
            btnFecharAuxiliadorCodigo.UseVisualStyleBackColor = false;
            btnFecharAuxiliadorCodigo.Click += btnFecharAuxiliadorCodigo_Click;
            // 
            // gridAuxilioCodigo
            // 
            gridAuxilioCodigo.BackgroundColor = Color.White;
            gridAuxilioCodigo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAuxilioCodigo.Location = new Point(15, 26);
            gridAuxilioCodigo.Name = "gridAuxilioCodigo";
            gridAuxilioCodigo.Size = new Size(331, 368);
            gridAuxilioCodigo.TabIndex = 0;
            // 
            // gbFooter
            // 
            gbFooter.BackColor = SystemColors.ActiveCaption;
            gbFooter.Controls.Add(lblAuxiliadorCodProduto);
            gbFooter.Location = new Point(2, 625);
            gbFooter.Name = "gbFooter";
            gbFooter.Size = new Size(1263, 58);
            gbFooter.TabIndex = 16;
            gbFooter.TabStop = false;
            // 
            // lblAuxiliadorCodProduto
            // 
            lblAuxiliadorCodProduto.AutoSize = true;
            lblAuxiliadorCodProduto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuxiliadorCodProduto.ForeColor = Color.White;
            lblAuxiliadorCodProduto.Location = new Point(26, 20);
            lblAuxiliadorCodProduto.Name = "lblAuxiliadorCodProduto";
            lblAuxiliadorCodProduto.Size = new Size(249, 21);
            lblAuxiliadorCodProduto.TabIndex = 0;
            lblAuxiliadorCodProduto.Text = "Auxiliador de Cod_Produto - [F4]";
            // 
            // VendaPDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(gbFooter);
            Controls.Add(gbCodProdutoAuxilio);
            Controls.Add(comboClientes);
            Controls.Add(lblCliente);
            Controls.Add(btnFinalizarVenda);
            Controls.Add(label5);
            Controls.Add(lblTotalProduto);
            Controls.Add(txtValorTotalProduto);
            Controls.Add(lblValorUnitario);
            Controls.Add(txtValorUnitario);
            Controls.Add(label2);
            Controls.Add(txtQuantidade);
            Controls.Add(lblSubTotalValor);
            Controls.Add(lblTituloCodigoProduto);
            Controls.Add(txtCodProduto);
            Controls.Add(gbCupom);
            Controls.Add(pictureFoto);
            Controls.Add(gbTituloPrincipal);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VendaPDV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDV";
            gbTituloPrincipal.ResumeLayout(false);
            gbTituloPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureFoto).EndInit();
            gbCupom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridListagemCupom).EndInit();
            gbCodProdutoAuxilio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridAuxilioCodigo).EndInit();
            gbFooter.ResumeLayout(false);
            gbFooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbTituloPrincipal;
        private Label lblTituloPrincipal;
        private PictureBox pictureFoto;
        private TextBox txtCodProduto;
        private GroupBox gbCupom;
        private DataGridView gridListagemCupom;
        private Label lblTituloCupom;
        private Label lblTituloCodigoProduto;
        private Label lblSubTotalValor;
        private Label label2;
        private TextBox txtQuantidade;
        private Label lblValorUnitario;
        private TextBox txtValorUnitario;
        private Label lblTotalProduto;
        private TextBox txtValorTotalProduto;
        private Label label5;
        private Button btnFinalizarVenda;
        private Label lblCliente;
        private ComboBox comboClientes;
        private GroupBox gbCodProdutoAuxilio;
        private DataGridView gridAuxilioCodigo;
        private GroupBox gbFooter;
        private Label lblAuxiliadorCodProduto;
        private Button btnFecharAuxiliadorCodigo;
    }
}