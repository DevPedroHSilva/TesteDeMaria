namespace VendasJa.Produto
{
    partial class PesquisaProduto
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
            lblTitulo = new Label();
            btnAdicionar = new Button();
            lblFiltroNegativo = new Label();
            gridResultadoPesquisa = new DataGridView();
            gpPesquisa = new GroupBox();
            lblLimparFiltro = new Button();
            btnPesquisar = new Button();
            lblDica = new Label();
            lblPesquisaNome = new Label();
            txtPesquisaNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridResultadoPesquisa).BeginInit();
            gpPesquisa.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(329, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 44);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "Tela de Produtos";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.WhiteSmoke;
            btnAdicionar.Location = new Point(708, 22);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(158, 29);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "Novo Produto";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblFiltroNegativo
            // 
            lblFiltroNegativo.AutoSize = true;
            lblFiltroNegativo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltroNegativo.Location = new Point(18, 239);
            lblFiltroNegativo.Name = "lblFiltroNegativo";
            lblFiltroNegativo.Size = new Size(340, 20);
            lblFiltroNegativo.TabIndex = 7;
            lblFiltroNegativo.Text = "Nenhum Resultado encontrado com esse filtro!";
            lblFiltroNegativo.Visible = false;
            // 
            // gridResultadoPesquisa
            // 
            gridResultadoPesquisa.BackgroundColor = SystemColors.ButtonHighlight;
            gridResultadoPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridResultadoPesquisa.Location = new Point(17, 273);
            gridResultadoPesquisa.Name = "gridResultadoPesquisa";
            gridResultadoPesquisa.RowHeadersWidth = 51;
            gridResultadoPesquisa.Size = new Size(849, 264);
            gridResultadoPesquisa.TabIndex = 6;
            gridResultadoPesquisa.Visible = false;
            // 
            // gpPesquisa
            // 
            gpPesquisa.Controls.Add(lblLimparFiltro);
            gpPesquisa.Controls.Add(btnPesquisar);
            gpPesquisa.Controls.Add(lblDica);
            gpPesquisa.Controls.Add(lblPesquisaNome);
            gpPesquisa.Controls.Add(txtPesquisaNome);
            gpPesquisa.Location = new Point(17, 57);
            gpPesquisa.Name = "gpPesquisa";
            gpPesquisa.Size = new Size(849, 179);
            gpPesquisa.TabIndex = 5;
            gpPesquisa.TabStop = false;
            gpPesquisa.Text = "Filtro";
            // 
            // lblLimparFiltro
            // 
            lblLimparFiltro.BackColor = Color.WhiteSmoke;
            lblLimparFiltro.Location = new Point(649, 122);
            lblLimparFiltro.Name = "lblLimparFiltro";
            lblLimparFiltro.Size = new Size(94, 29);
            lblLimparFiltro.TabIndex = 4;
            lblLimparFiltro.Text = "Limpar";
            lblLimparFiltro.UseVisualStyleBackColor = false;
            lblLimparFiltro.Click += lblLimparFiltro_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.WhiteSmoke;
            btnPesquisar.Location = new Point(749, 122);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // lblDica
            // 
            lblDica.AutoSize = true;
            lblDica.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDica.ForeColor = SystemColors.ActiveBorder;
            lblDica.Location = new Point(6, 134);
            lblDica.Name = "lblDica";
            lblDica.Size = new Size(338, 20);
            lblDica.TabIndex = 2;
            lblDica.Text = "Campos abertos são pesquisados por aproximação!";
            lblDica.UseWaitCursor = true;
            // 
            // lblPesquisaNome
            // 
            lblPesquisaNome.AutoSize = true;
            lblPesquisaNome.Location = new Point(7, 37);
            lblPesquisaNome.Name = "lblPesquisaNome";
            lblPesquisaNome.Size = new Size(69, 20);
            lblPesquisaNome.TabIndex = 1;
            lblPesquisaNome.Text = "Produto: ";
            // 
            // txtPesquisaNome
            // 
            txtPesquisaNome.Location = new Point(73, 34);
            txtPesquisaNome.Name = "txtPesquisaNome";
            txtPesquisaNome.PlaceholderText = "Digite um nome aqui...";
            txtPesquisaNome.Size = new Size(206, 27);
            txtPesquisaNome.TabIndex = 0;
            // 
            // PesquisaProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 553);
            Controls.Add(lblTitulo);
            Controls.Add(btnAdicionar);
            Controls.Add(lblFiltroNegativo);
            Controls.Add(gridResultadoPesquisa);
            Controls.Add(gpPesquisa);
            Name = "PesquisaProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PesquisaProduto";
            ((System.ComponentModel.ISupportInitialize)gridResultadoPesquisa).EndInit();
            gpPesquisa.ResumeLayout(false);
            gpPesquisa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnAdicionar;
        private Label lblFiltroNegativo;
        private DataGridView gridResultadoPesquisa;
        private GroupBox gpPesquisa;
        private Button lblLimparFiltro;
        private Button btnPesquisar;
        private Label lblDica;
        private Label lblPesquisaNome;
        private TextBox txtPesquisaNome;
    }
}