namespace VendasJa
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMenuCliente = new Button();
            gbMenu = new GroupBox();
            btnRelatorioProdutos = new Button();
            btnRelatorioClientes = new Button();
            pictureLogo = new PictureBox();
            btnProdutos = new Button();
            lblMenu = new Label();
            gbIndexClientes = new GroupBox();
            lblIndexClienteValue = new Label();
            lblIndexCliente = new Label();
            gbIndices = new GroupBox();
            groupBox3 = new GroupBox();
            lblFaturamentoMensalValor = new Label();
            lblFaturamentoMensal = new Label();
            gbTotalVendas = new GroupBox();
            lblTotalVendasValor = new Label();
            lblTotalVendas = new Label();
            groupBox1 = new GroupBox();
            lblTotalProdutoValue = new Label();
            lblIndiceProdutos = new Label();
            label1 = new Label();
            btnNovaVenda = new Button();
            btnRelatorioVenda = new Button();
            gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            gbIndexClientes.SuspendLayout();
            gbIndices.SuspendLayout();
            groupBox3.SuspendLayout();
            gbTotalVendas.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenuCliente
            // 
            btnMenuCliente.BackColor = SystemColors.ButtonFace;
            btnMenuCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuCliente.Location = new Point(13, 130);
            btnMenuCliente.Margin = new Padding(3, 2, 3, 2);
            btnMenuCliente.Name = "btnMenuCliente";
            btnMenuCliente.Size = new Size(154, 26);
            btnMenuCliente.TabIndex = 0;
            btnMenuCliente.Text = "Clientes";
            btnMenuCliente.UseVisualStyleBackColor = false;
            btnMenuCliente.Click += btnMenuCliente_Click;
            // 
            // gbMenu
            // 
            gbMenu.BackColor = SystemColors.GradientActiveCaption;
            gbMenu.Controls.Add(btnRelatorioProdutos);
            gbMenu.Controls.Add(btnRelatorioClientes);
            gbMenu.Controls.Add(pictureLogo);
            gbMenu.Controls.Add(btnProdutos);
            gbMenu.Controls.Add(btnMenuCliente);
            gbMenu.Location = new Point(-1, -14);
            gbMenu.Margin = new Padding(3, 2, 3, 2);
            gbMenu.Name = "gbMenu";
            gbMenu.Padding = new Padding(3, 2, 3, 2);
            gbMenu.Size = new Size(183, 458);
            gbMenu.TabIndex = 1;
            gbMenu.TabStop = false;
            // 
            // btnRelatorioProdutos
            // 
            btnRelatorioProdutos.Location = new Point(13, 233);
            btnRelatorioProdutos.Name = "btnRelatorioProdutos";
            btnRelatorioProdutos.Size = new Size(121, 23);
            btnRelatorioProdutos.TabIndex = 4;
            btnRelatorioProdutos.Text = "Relatório Produtos";
            btnRelatorioProdutos.UseVisualStyleBackColor = true;
            btnRelatorioProdutos.Click += btnRelatorioProdutos_Click;
            // 
            // btnRelatorioClientes
            // 
            btnRelatorioClientes.Location = new Point(13, 161);
            btnRelatorioClientes.Name = "btnRelatorioClientes";
            btnRelatorioClientes.Size = new Size(121, 23);
            btnRelatorioClientes.TabIndex = 3;
            btnRelatorioClientes.Text = "Relatório Clientes";
            btnRelatorioClientes.UseVisualStyleBackColor = true;
            btnRelatorioClientes.Click += btnRelatorioClientes_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = Properties.Resources.logo;
            pictureLogo.Location = new Point(23, 35);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(134, 76);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 2;
            pictureLogo.TabStop = false;
            // 
            // btnProdutos
            // 
            btnProdutos.BackColor = SystemColors.ButtonFace;
            btnProdutos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProdutos.Location = new Point(13, 201);
            btnProdutos.Margin = new Padding(3, 2, 3, 2);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(154, 26);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = false;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Sans Serif Collection", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(203, 21);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(163, 35);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Painel Inicial";
            // 
            // gbIndexClientes
            // 
            gbIndexClientes.BackColor = Color.SteelBlue;
            gbIndexClientes.Controls.Add(lblIndexClienteValue);
            gbIndexClientes.Controls.Add(lblIndexCliente);
            gbIndexClientes.Location = new Point(29, 20);
            gbIndexClientes.Margin = new Padding(3, 2, 3, 2);
            gbIndexClientes.Name = "gbIndexClientes";
            gbIndexClientes.Padding = new Padding(3, 2, 3, 2);
            gbIndexClientes.Size = new Size(134, 59);
            gbIndexClientes.TabIndex = 2;
            gbIndexClientes.TabStop = false;
            // 
            // lblIndexClienteValue
            // 
            lblIndexClienteValue.AutoSize = true;
            lblIndexClienteValue.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIndexClienteValue.ForeColor = Color.White;
            lblIndexClienteValue.Location = new Point(52, 25);
            lblIndexClienteValue.Name = "lblIndexClienteValue";
            lblIndexClienteValue.Size = new Size(25, 30);
            lblIndexClienteValue.TabIndex = 1;
            lblIndexClienteValue.Text = "0";
            // 
            // lblIndexCliente
            // 
            lblIndexCliente.AutoSize = true;
            lblIndexCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIndexCliente.ForeColor = Color.White;
            lblIndexCliente.Location = new Point(5, 10);
            lblIndexCliente.Name = "lblIndexCliente";
            lblIndexCliente.Size = new Size(101, 15);
            lblIndexCliente.TabIndex = 0;
            lblIndexCliente.Text = "Total de Clientes:";
            // 
            // gbIndices
            // 
            gbIndices.BackColor = SystemColors.Control;
            gbIndices.Controls.Add(groupBox3);
            gbIndices.Controls.Add(gbTotalVendas);
            gbIndices.Controls.Add(groupBox1);
            gbIndices.Controls.Add(gbIndexClientes);
            gbIndices.Location = new Point(203, 63);
            gbIndices.Margin = new Padding(3, 2, 3, 2);
            gbIndices.Name = "gbIndices";
            gbIndices.Padding = new Padding(3, 2, 3, 2);
            gbIndices.Size = new Size(718, 94);
            gbIndices.TabIndex = 3;
            gbIndices.TabStop = false;
            gbIndices.Text = "Indices do sistema:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Lavender;
            groupBox3.Controls.Add(lblFaturamentoMensalValor);
            groupBox3.Controls.Add(lblFaturamentoMensal);
            groupBox3.Location = new Point(551, 20);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(134, 59);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // lblFaturamentoMensalValor
            // 
            lblFaturamentoMensalValor.AutoSize = true;
            lblFaturamentoMensalValor.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFaturamentoMensalValor.Location = new Point(34, 23);
            lblFaturamentoMensalValor.Name = "lblFaturamentoMensalValor";
            lblFaturamentoMensalValor.Size = new Size(25, 30);
            lblFaturamentoMensalValor.TabIndex = 1;
            lblFaturamentoMensalValor.Text = "0";
            // 
            // lblFaturamentoMensal
            // 
            lblFaturamentoMensal.AutoSize = true;
            lblFaturamentoMensal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFaturamentoMensal.Location = new Point(5, 8);
            lblFaturamentoMensal.Name = "lblFaturamentoMensal";
            lblFaturamentoMensal.Size = new Size(121, 15);
            lblFaturamentoMensal.TabIndex = 0;
            lblFaturamentoMensal.Text = "Faturamento Mensal";
            // 
            // gbTotalVendas
            // 
            gbTotalVendas.BackColor = Color.SteelBlue;
            gbTotalVendas.Controls.Add(lblTotalVendasValor);
            gbTotalVendas.Controls.Add(lblTotalVendas);
            gbTotalVendas.Location = new Point(382, 20);
            gbTotalVendas.Margin = new Padding(3, 2, 3, 2);
            gbTotalVendas.Name = "gbTotalVendas";
            gbTotalVendas.Padding = new Padding(3, 2, 3, 2);
            gbTotalVendas.Size = new Size(134, 59);
            gbTotalVendas.TabIndex = 4;
            gbTotalVendas.TabStop = false;
            // 
            // lblTotalVendasValor
            // 
            lblTotalVendasValor.AutoSize = true;
            lblTotalVendasValor.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVendasValor.ForeColor = Color.White;
            lblTotalVendasValor.Location = new Point(52, 24);
            lblTotalVendasValor.Name = "lblTotalVendasValor";
            lblTotalVendasValor.Size = new Size(25, 30);
            lblTotalVendasValor.TabIndex = 1;
            lblTotalVendasValor.Text = "0";
            // 
            // lblTotalVendas
            // 
            lblTotalVendas.AutoSize = true;
            lblTotalVendas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVendas.ForeColor = Color.White;
            lblTotalVendas.Location = new Point(5, 9);
            lblTotalVendas.Name = "lblTotalVendas";
            lblTotalVendas.Size = new Size(93, 15);
            lblTotalVendas.TabIndex = 0;
            lblTotalVendas.Text = "Total de vendas";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Lavender;
            groupBox1.Controls.Add(lblTotalProdutoValue);
            groupBox1.Controls.Add(lblIndiceProdutos);
            groupBox1.Location = new Point(206, 20);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(134, 59);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // lblTotalProdutoValue
            // 
            lblTotalProdutoValue.AutoSize = true;
            lblTotalProdutoValue.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProdutoValue.Location = new Point(52, 25);
            lblTotalProdutoValue.Name = "lblTotalProdutoValue";
            lblTotalProdutoValue.Size = new Size(25, 30);
            lblTotalProdutoValue.TabIndex = 1;
            lblTotalProdutoValue.Text = "0";
            // 
            // lblIndiceProdutos
            // 
            lblIndiceProdutos.AutoSize = true;
            lblIndiceProdutos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIndiceProdutos.Location = new Point(5, 10);
            lblIndiceProdutos.Name = "lblIndiceProdutos";
            lblIndiceProdutos.Size = new Size(107, 15);
            lblIndiceProdutos.TabIndex = 0;
            lblIndiceProdutos.Text = "Total de Produtos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(405, 412);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 4;
            label1.Text = "By Pedro Henrique - 2024";
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.BackColor = Color.DarkSeaGreen;
            btnNovaVenda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovaVenda.ForeColor = SystemColors.ControlLightLight;
            btnNovaVenda.Location = new Point(203, 187);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.Size = new Size(348, 55);
            btnNovaVenda.TabIndex = 0;
            btnNovaVenda.Text = "Nova Venda (PDV)";
            btnNovaVenda.UseVisualStyleBackColor = false;
            btnNovaVenda.Click += btnNovaVenda_Click;
            // 
            // btnRelatorioVenda
            // 
            btnRelatorioVenda.BackColor = Color.SteelBlue;
            btnRelatorioVenda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorioVenda.ForeColor = SystemColors.ControlLightLight;
            btnRelatorioVenda.Location = new Point(589, 187);
            btnRelatorioVenda.Name = "btnRelatorioVenda";
            btnRelatorioVenda.Size = new Size(332, 55);
            btnRelatorioVenda.TabIndex = 5;
            btnRelatorioVenda.Text = "Relatório de Venda";
            btnRelatorioVenda.UseVisualStyleBackColor = false;
            btnRelatorioVenda.Click += btnRelatorioVenda_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(947, 438);
            Controls.Add(btnRelatorioVenda);
            Controls.Add(btnNovaVenda);
            Controls.Add(lblMenu);
            Controls.Add(label1);
            Controls.Add(gbIndices);
            Controls.Add(gbMenu);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema VendaJá";
            gbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            gbIndexClientes.ResumeLayout(false);
            gbIndexClientes.PerformLayout();
            gbIndices.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gbTotalVendas.ResumeLayout(false);
            gbTotalVendas.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenuCliente;
        private GroupBox gbMenu;
        private Label lblMenu;
        private GroupBox gbIndexClientes;
        private Label lblIndexClienteValue;
        private Label lblIndexCliente;
        private Button btnProdutos;
        private GroupBox gbIndices;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblTotalProdutoValue;
        private Label lblIndiceProdutos;
        private Button btnNovaVenda;
        private PictureBox pictureLogo;
        private Button btnRelatorioVenda;
        private Button btnRelatorioProdutos;
        private Button btnRelatorioClientes;
        private GroupBox groupBox3;
        private Label lblFaturamentoMensalValor;
        private Label lblFaturamentoMensal;
        private GroupBox gbTotalVendas;
        private Label lblTotalVendasValor;
        private Label lblTotalVendas;
    }
}
