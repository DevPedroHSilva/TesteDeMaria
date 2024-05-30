namespace VendasJa.Cliente
{
    partial class EdicaoCliente
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
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtCEP = new TextBox();
            lblCEP = new Label();
            txtFone = new TextBox();
            lblFone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            label1 = new Label();
            gpAcoes = new GroupBox();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnAtualizar = new Button();
            lblTitulo = new Label();
            gpAcoes.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(693, 208);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "999";
            txtNumero.Size = new Size(83, 27);
            txtNumero.TabIndex = 42;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(678, 182);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(73, 23);
            lblNumero.TabIndex = 41;
            lblNumero.Text = "Número";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(415, 388);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Casa..";
            txtComplemento.Size = new Size(247, 27);
            txtComplemento.TabIndex = 40;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplemento.Location = new Point(400, 359);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(123, 23);
            lblComplemento.TabIndex = 39;
            lblComplemento.Text = "Complemento:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(415, 297);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "Bairro Local..";
            txtBairro.Size = new Size(247, 27);
            txtBairro.TabIndex = 38;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBairro.Location = new Point(400, 271);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(59, 23);
            lblBairro.TabIndex = 37;
            lblBairro.Text = "Bairro:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(415, 208);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Rua Endereço..";
            txtEndereco.Size = new Size(247, 27);
            txtEndereco.TabIndex = 36;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(400, 182);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(85, 23);
            lblEndereco.TabIndex = 35;
            lblEndereco.Text = "Endereço:";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(415, 130);
            txtCEP.Name = "txtCEP";
            txtCEP.PlaceholderText = "99999-999";
            txtCEP.Size = new Size(247, 27);
            txtCEP.TabIndex = 34;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCEP.Location = new Point(400, 104);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(44, 23);
            lblCEP.TabIndex = 33;
            lblCEP.Text = "CEP:";
            // 
            // txtFone
            // 
            txtFone.Location = new Point(41, 297);
            txtFone.Name = "txtFone";
            txtFone.PlaceholderText = "(99) 99999-9999";
            txtFone.Size = new Size(247, 27);
            txtFone.TabIndex = 32;
            // 
            // lblFone
            // 
            lblFone.AutoSize = true;
            lblFone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFone.Location = new Point(26, 271);
            lblFone.Name = "lblFone";
            lblFone.Size = new Size(59, 23);
            lblFone.TabIndex = 31;
            lblFone.Text = "*Fone:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 208);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email@mail.com";
            txtEmail.Size = new Size(247, 27);
            txtEmail.TabIndex = 30;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(26, 182);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 23);
            lblEmail.TabIndex = 29;
            lblEmail.Text = "E-mail:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(41, 130);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Fulano de tal..";
            txtNome.Size = new Size(247, 27);
            txtNome.TabIndex = 28;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(26, 104);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(68, 23);
            lblNome.TabIndex = 27;
            lblNome.Text = "*Nome:";
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
            gpAcoes.Controls.Add(btnExcluir);
            gpAcoes.Controls.Add(btnCancelar);
            gpAcoes.Controls.Add(btnAtualizar);
            gpAcoes.Location = new Point(0, 499);
            gpAcoes.Name = "gpAcoes";
            gpAcoes.Size = new Size(882, 55);
            gpAcoes.TabIndex = 25;
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
            lblTitulo.Size = new Size(252, 44);
            lblTitulo.TabIndex = 24;
            lblTitulo.Text = "Edição de cliente";
            // 
            // EdicaoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 553);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(txtCEP);
            Controls.Add(lblCEP);
            Controls.Add(txtFone);
            Controls.Add(lblFone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(label1);
            Controls.Add(gpAcoes);
            Controls.Add(lblTitulo);
            Name = "EdicaoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EdicaoCliente";
            gpAcoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label lblNumero;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtCEP;
        private Label lblCEP;
        private TextBox txtFone;
        private Label lblFone;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtNome;
        private Label lblNome;
        private Label label1;
        private GroupBox gpAcoes;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnAtualizar;
        private Label lblTitulo;
    }
}