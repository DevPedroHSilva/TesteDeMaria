namespace VendasJa.Cliente
{
    partial class CadastroCliente
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
            gpAcoes = new GroupBox();
            btnCancelar = new Button();
            btnInserir = new Button();
            label1 = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtFone = new TextBox();
            lblFone = new Label();
            txtCEP = new TextBox();
            lblCEP = new Label();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            gpAcoes.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(305, 44);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Cadastro de Clientes";
            // 
            // gpAcoes
            // 
            gpAcoes.BackColor = SystemColors.GradientInactiveCaption;
            gpAcoes.Controls.Add(btnCancelar);
            gpAcoes.Controls.Add(btnInserir);
            gpAcoes.Location = new Point(0, 501);
            gpAcoes.Name = "gpAcoes";
            gpAcoes.Size = new Size(882, 55);
            gpAcoes.TabIndex = 6;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(21, 55);
            label1.Name = "label1";
            label1.Size = new Size(278, 20);
            label1.TabIndex = 7;
            label1.Text = "Todos os campos com (*) são obrigatórios";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(26, 106);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(68, 23);
            lblNome.TabIndex = 8;
            lblNome.Text = "*Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(41, 132);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Fulano de tal..";
            txtNome.Size = new Size(247, 27);
            txtNome.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(41, 210);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email@mail.com";
            txtEmail.Size = new Size(247, 27);
            txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(26, 184);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 23);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "E-mail:";
            // 
            // txtFone
            // 
            txtFone.Location = new Point(41, 299);
            txtFone.Name = "txtFone";
            txtFone.PlaceholderText = "(99) 99999-9999";
            txtFone.Size = new Size(247, 27);
            txtFone.TabIndex = 13;
            // 
            // lblFone
            // 
            lblFone.AutoSize = true;
            lblFone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFone.Location = new Point(26, 273);
            lblFone.Name = "lblFone";
            lblFone.Size = new Size(59, 23);
            lblFone.TabIndex = 12;
            lblFone.Text = "*Fone:";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(415, 132);
            txtCEP.Name = "txtCEP";
            txtCEP.PlaceholderText = "99999-999";
            txtCEP.Size = new Size(247, 27);
            txtCEP.TabIndex = 15;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCEP.Location = new Point(400, 106);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(44, 23);
            lblCEP.TabIndex = 14;
            lblCEP.Text = "CEP:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(415, 210);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PlaceholderText = "Rua Endereço..";
            txtEndereco.Size = new Size(247, 27);
            txtEndereco.TabIndex = 17;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(400, 184);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(85, 23);
            lblEndereco.TabIndex = 16;
            lblEndereco.Text = "Endereço:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(415, 299);
            txtBairro.Name = "txtBairro";
            txtBairro.PlaceholderText = "Bairro Local..";
            txtBairro.Size = new Size(247, 27);
            txtBairro.TabIndex = 19;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBairro.Location = new Point(400, 273);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(59, 23);
            lblBairro.TabIndex = 18;
            lblBairro.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(415, 390);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Casa..";
            txtComplemento.Size = new Size(247, 27);
            txtComplemento.TabIndex = 21;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplemento.Location = new Point(400, 361);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(123, 23);
            lblComplemento.TabIndex = 20;
            lblComplemento.Text = "Complemento:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(693, 210);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "999";
            txtNumero.Size = new Size(83, 27);
            txtNumero.TabIndex = 23;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(678, 184);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(73, 23);
            lblNumero.TabIndex = 22;
            lblNumero.Text = "Número";
            // 
            // CadastroCliente
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
            Name = "CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroCliente";
            gpAcoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox gpAcoes;
        private Button btnInserir;
        private Button btnCancelar;
        private Label label1;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtFone;
        private Label lblFone;
        private TextBox txtCEP;
        private Label lblCEP;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private TextBox txtNumero;
        private Label lblNumero;
    }
}