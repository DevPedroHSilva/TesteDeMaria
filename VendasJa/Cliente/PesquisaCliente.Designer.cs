namespace VendasJa
{
    partial class PesquisaCliente
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
            components = new System.ComponentModel.Container();
            gpPesquisa = new GroupBox();
            lblLimparFiltro = new Button();
            btnPesquisar = new Button();
            lblDica = new Label();
            lblPesquisaNome = new Label();
            txtPesquisaNome = new TextBox();
            gridResultadoPesquisa = new DataGridView();
            conexaoBindingSource = new BindingSource(components);
            lblFiltroNegativo = new Label();
            LayerPesquisar = new GroupBox();
            label1 = new Label();
            btnAdicionarCliente = new Button();
            gpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridResultadoPesquisa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).BeginInit();
            LayerPesquisar.SuspendLayout();
            SuspendLayout();
            // 
            // gpPesquisa
            // 
            gpPesquisa.Controls.Add(lblLimparFiltro);
            gpPesquisa.Controls.Add(btnPesquisar);
            gpPesquisa.Controls.Add(lblDica);
            gpPesquisa.Controls.Add(lblPesquisaNome);
            gpPesquisa.Controls.Add(txtPesquisaNome);
            gpPesquisa.Location = new Point(15, 61);
            gpPesquisa.Name = "gpPesquisa";
            gpPesquisa.Size = new Size(849, 179);
            gpPesquisa.TabIndex = 0;
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
            lblPesquisaNome.Size = new Size(57, 20);
            lblPesquisaNome.TabIndex = 1;
            lblPesquisaNome.Text = "Nome: ";
            // 
            // txtPesquisaNome
            // 
            txtPesquisaNome.Location = new Point(63, 34);
            txtPesquisaNome.Name = "txtPesquisaNome";
            txtPesquisaNome.PlaceholderText = "Digite um nome aqui...";
            txtPesquisaNome.Size = new Size(165, 27);
            txtPesquisaNome.TabIndex = 0;
            // 
            // gridResultadoPesquisa
            // 
            gridResultadoPesquisa.BackgroundColor = SystemColors.ButtonHighlight;
            gridResultadoPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridResultadoPesquisa.Location = new Point(15, 277);
            gridResultadoPesquisa.Name = "gridResultadoPesquisa";
            gridResultadoPesquisa.RowHeadersWidth = 51;
            gridResultadoPesquisa.Size = new Size(849, 264);
            gridResultadoPesquisa.TabIndex = 1;
            gridResultadoPesquisa.Visible = false;
            // 
            // conexaoBindingSource
            // 
            conexaoBindingSource.DataSource = typeof(DataBase.Conexao);
            // 
            // lblFiltroNegativo
            // 
            lblFiltroNegativo.AutoSize = true;
            lblFiltroNegativo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltroNegativo.Location = new Point(16, 243);
            lblFiltroNegativo.Name = "lblFiltroNegativo";
            lblFiltroNegativo.Size = new Size(340, 20);
            lblFiltroNegativo.TabIndex = 2;
            lblFiltroNegativo.Text = "Nenhum Resultado encontrado com esse filtro!";
            lblFiltroNegativo.Visible = false;
            // 
            // LayerPesquisar
            // 
            LayerPesquisar.Controls.Add(label1);
            LayerPesquisar.Controls.Add(btnAdicionarCliente);
            LayerPesquisar.Controls.Add(lblFiltroNegativo);
            LayerPesquisar.Controls.Add(gridResultadoPesquisa);
            LayerPesquisar.Controls.Add(gpPesquisa);
            LayerPesquisar.Location = new Point(1, 0);
            LayerPesquisar.Name = "LayerPesquisar";
            LayerPesquisar.Size = new Size(880, 554);
            LayerPesquisar.TabIndex = 3;
            LayerPesquisar.TabStop = false;
            LayerPesquisar.Text = "Pesquisar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 20);
            label1.Name = "label1";
            label1.Size = new Size(240, 44);
            label1.TabIndex = 4;
            label1.Text = "Tela de Clientes";
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.BackColor = Color.WhiteSmoke;
            btnAdicionarCliente.Location = new Point(706, 26);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(158, 29);
            btnAdicionarCliente.TabIndex = 3;
            btnAdicionarCliente.Text = "Novo Cliente";
            btnAdicionarCliente.UseVisualStyleBackColor = false;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // PesquisaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 553);
            Controls.Add(LayerPesquisar);
            Name = "PesquisaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            gpPesquisa.ResumeLayout(false);
            gpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridResultadoPesquisa).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).EndInit();
            LayerPesquisar.ResumeLayout(false);
            LayerPesquisar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpPesquisa;
        private Label lblDica;
        private Label lblPesquisaNome;
        private TextBox txtPesquisaNome;
        private Button btnPesquisar;
        private DataGridView gridResultadoPesquisa;
        private BindingSource conexaoBindingSource;
        private Label lblFiltroNegativo;
        private Button lblLimparFiltro;
        private GroupBox LayerPesquisar;
        private Button btnAdicionarCliente;
        private Label label1;
    }
}