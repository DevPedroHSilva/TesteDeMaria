namespace VendasJa.Produto.Relatorio
{
    partial class RelatorioProdutos
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
            calendarDataFiim = new MonthCalendar();
            calendarDataInicio = new MonthCalendar();
            gbFiltroRelatorio = new GroupBox();
            txtProduto = new TextBox();
            btnFiltrar = new Button();
            txtDataFim = new TextBox();
            lblDataFim = new Label();
            txtDataInicio = new TextBox();
            lblDataInicio = new Label();
            lblProduto = new Label();
            rvRelatorioGeral = new Microsoft.Reporting.WinForms.ReportViewer();
            gbFiltroRelatorio.SuspendLayout();
            SuspendLayout();
            // 
            // calendarDataFiim
            // 
            calendarDataFiim.Location = new Point(502, 84);
            calendarDataFiim.Name = "calendarDataFiim";
            calendarDataFiim.TabIndex = 7;
            calendarDataFiim.Visible = false;
            // 
            // calendarDataInicio
            // 
            calendarDataInicio.Location = new Point(224, 84);
            calendarDataInicio.Name = "calendarDataInicio";
            calendarDataInicio.TabIndex = 6;
            calendarDataInicio.Visible = false;
            // 
            // gbFiltroRelatorio
            // 
            gbFiltroRelatorio.Controls.Add(txtProduto);
            gbFiltroRelatorio.Controls.Add(btnFiltrar);
            gbFiltroRelatorio.Controls.Add(txtDataFim);
            gbFiltroRelatorio.Controls.Add(lblDataFim);
            gbFiltroRelatorio.Controls.Add(txtDataInicio);
            gbFiltroRelatorio.Controls.Add(lblDataInicio);
            gbFiltroRelatorio.Controls.Add(lblProduto);
            gbFiltroRelatorio.Location = new Point(12, 12);
            gbFiltroRelatorio.Name = "gbFiltroRelatorio";
            gbFiltroRelatorio.Size = new Size(860, 74);
            gbFiltroRelatorio.TabIndex = 5;
            gbFiltroRelatorio.TabStop = false;
            gbFiltroRelatorio.Text = "Filtro de relatório";
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(26, 37);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(174, 23);
            txtProduto.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(745, 35);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(109, 23);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtDataFim
            // 
            txtDataFim.Location = new Point(554, 37);
            txtDataFim.Name = "txtDataFim";
            txtDataFim.Size = new Size(163, 23);
            txtDataFim.TabIndex = 5;
            // 
            // lblDataFim
            // 
            lblDataFim.AutoSize = true;
            lblDataFim.Location = new Point(526, 19);
            lblDataFim.Name = "lblDataFim";
            lblDataFim.Size = new Size(92, 15);
            lblDataFim.TabIndex = 4;
            lblDataFim.Text = "Data de término";
            // 
            // txtDataInicio
            // 
            txtDataInicio.Location = new Point(274, 37);
            txtDataInicio.Name = "txtDataInicio";
            txtDataInicio.Size = new Size(163, 23);
            txtDataInicio.TabIndex = 3;
            // 
            // lblDataInicio
            // 
            lblDataInicio.AutoSize = true;
            lblDataInicio.Location = new Point(246, 19);
            lblDataInicio.Name = "lblDataInicio";
            lblDataInicio.Size = new Size(79, 15);
            lblDataInicio.TabIndex = 2;
            lblDataInicio.Text = "Data de Inicio";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(16, 19);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(53, 15);
            lblProduto.TabIndex = 0;
            lblProduto.Text = "Produto:";
            // 
            // rvRelatorioGeral
            // 
            rvRelatorioGeral.Location = new Point(10, 110);
            rvRelatorioGeral.Name = "ReportViewer";
            rvRelatorioGeral.ServerReport.BearerToken = null;
            rvRelatorioGeral.Size = new Size(860, 450);
            rvRelatorioGeral.TabIndex = 0;
            // 
            // RelatorioProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(884, 561);
            Controls.Add(calendarDataFiim);
            Controls.Add(calendarDataInicio);
            Controls.Add(gbFiltroRelatorio);
            Controls.Add(rvRelatorioGeral);
            Name = "RelatorioProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RelatorioProdutos";
            gbFiltroRelatorio.ResumeLayout(false);
            gbFiltroRelatorio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar calendarDataFiim;
        private MonthCalendar calendarDataInicio;
        private GroupBox gbFiltroRelatorio;
        private Button btnFiltrar;
        private TextBox txtDataFim;
        private Label lblDataFim;
        private TextBox txtDataInicio;
        private Label lblDataInicio;
        private Label lblProduto;
        private TextBox txtProduto;
        private Microsoft.Reporting.WinForms.ReportViewer rvRelatorioGeral;
    }
}