namespace VendasJa.Cliente.Relatorio
{
    partial class RelatorioClientes
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
            txtCliente = new TextBox();
            btnFiltrar = new Button();
            txtDataFim = new TextBox();
            lblDataFim = new Label();
            txtDataInicio = new TextBox();
            lblDataInicio = new Label();
            lblCliente = new Label();
            rvRelatorioGeral = new Microsoft.Reporting.WinForms.ReportViewer();
            gbFiltroRelatorio.SuspendLayout();
            SuspendLayout();
            // 
            // calendarDataFiim
            // 
            calendarDataFiim.Location = new Point(502, 84);
            calendarDataFiim.Name = "calendarDataFiim";
            calendarDataFiim.TabIndex = 10;
            calendarDataFiim.Visible = false;
            // 
            // calendarDataInicio
            // 
            calendarDataInicio.Location = new Point(224, 84);
            calendarDataInicio.Name = "calendarDataInicio";
            calendarDataInicio.TabIndex = 9;
            calendarDataInicio.Visible = false;
            // 
            // gbFiltroRelatorio
            // 
            gbFiltroRelatorio.Controls.Add(txtCliente);
            gbFiltroRelatorio.Controls.Add(btnFiltrar);
            gbFiltroRelatorio.Controls.Add(txtDataFim);
            gbFiltroRelatorio.Controls.Add(lblDataFim);
            gbFiltroRelatorio.Controls.Add(txtDataInicio);
            gbFiltroRelatorio.Controls.Add(lblDataInicio);
            gbFiltroRelatorio.Controls.Add(lblCliente);
            gbFiltroRelatorio.Location = new Point(12, 12);
            gbFiltroRelatorio.Name = "gbFiltroRelatorio";
            gbFiltroRelatorio.Size = new Size(860, 74);
            gbFiltroRelatorio.TabIndex = 8;
            gbFiltroRelatorio.TabStop = false;
            gbFiltroRelatorio.Text = "Filtro de relatório";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(26, 37);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(174, 23);
            txtCliente.TabIndex = 7;
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
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(16, 19);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // rvRelatorioGeral
            // 
            rvRelatorioGeral.Location = new Point(10, 110);
            rvRelatorioGeral.Name = "ReportViewer";
            rvRelatorioGeral.ServerReport.BearerToken = null;
            rvRelatorioGeral.Size = new Size(860, 450);
            rvRelatorioGeral.TabIndex = 0;
            // 
            // RelatorioClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(calendarDataFiim);
            Controls.Add(calendarDataInicio);
            Controls.Add(gbFiltroRelatorio);
            Controls.Add(rvRelatorioGeral);
            Name = "RelatorioClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RelatorioClientes";
            gbFiltroRelatorio.ResumeLayout(false);
            gbFiltroRelatorio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar calendarDataFiim;
        private MonthCalendar calendarDataInicio;
        private GroupBox gbFiltroRelatorio;
        private TextBox txtCliente;
        private Button btnFiltrar;
        private TextBox txtDataFim;
        private Label lblDataFim;
        private TextBox txtDataInicio;
        private Label lblDataInicio;
        private Label lblCliente;
        private Microsoft.Reporting.WinForms.ReportViewer rvRelatorioGeral;
    }
}