namespace VendasJa.Venda
{
    partial class RelatorioVendas
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
            rvRelatorioGeral = new Microsoft.Reporting.WinForms.ReportViewer();
            gbFiltroRelatorio = new GroupBox();
            btnFiltrar = new Button();
            txtDataFim = new TextBox();
            lblDataFim = new Label();
            txtDataInicio = new TextBox();
            lblDataInicio = new Label();
            comboCliente = new ComboBox();
            lblCliente = new Label();
            calendarDataInicio = new MonthCalendar();
            calendarDataFiim = new MonthCalendar();
            gbFiltroRelatorio.SuspendLayout();
            SuspendLayout();
            // 
            // rvRelatorioGeral
            // 
            rvRelatorioGeral.Location = new Point(10, 110);
            rvRelatorioGeral.Name = "ReportViewer";
            rvRelatorioGeral.ServerReport.BearerToken = null;
            rvRelatorioGeral.Size = new Size(860, 445);
            rvRelatorioGeral.TabIndex = 0;
            // 
            // gbFiltroRelatorio
            // 
            gbFiltroRelatorio.Controls.Add(btnFiltrar);
            gbFiltroRelatorio.Controls.Add(txtDataFim);
            gbFiltroRelatorio.Controls.Add(lblDataFim);
            gbFiltroRelatorio.Controls.Add(txtDataInicio);
            gbFiltroRelatorio.Controls.Add(lblDataInicio);
            gbFiltroRelatorio.Controls.Add(comboCliente);
            gbFiltroRelatorio.Controls.Add(lblCliente);
            gbFiltroRelatorio.Location = new Point(12, 12);
            gbFiltroRelatorio.Name = "gbFiltroRelatorio";
            gbFiltroRelatorio.Size = new Size(860, 74);
            gbFiltroRelatorio.TabIndex = 1;
            gbFiltroRelatorio.TabStop = false;
            gbFiltroRelatorio.Text = "Filtro de relatório";
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
            txtDataFim.Click += txtDataFim_Click;
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
            txtDataInicio.Click += txtDataInicio_Click;
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
            // comboCliente
            // 
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(32, 37);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(177, 23);
            comboCliente.TabIndex = 1;
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
            // calendarDataInicio
            // 
            calendarDataInicio.Location = new Point(224, 84);
            calendarDataInicio.Name = "calendarDataInicio";
            calendarDataInicio.TabIndex = 3;
            calendarDataInicio.Visible = false;
            calendarDataInicio.DateChanged += calendarDataInicio_DateChanged;
            // 
            // calendarDataFiim
            // 
            calendarDataFiim.Location = new Point(502, 84);
            calendarDataFiim.Name = "calendarDataFiim";
            calendarDataFiim.TabIndex = 4;
            calendarDataFiim.Visible = false;
            calendarDataFiim.DateChanged += calendarDataFiim_DateChanged;
            // 
            // RelatorioVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(calendarDataFiim);
            Controls.Add(calendarDataInicio);
            Controls.Add(gbFiltroRelatorio);
            Controls.Add(rvRelatorioGeral);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RelatorioVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RelatorioVendas";
            gbFiltroRelatorio.ResumeLayout(false);
            gbFiltroRelatorio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvRelatorioGeral;
        private GroupBox gbFiltroRelatorio;
        private Label lblDataInicio;
        private ComboBox comboCliente;
        private Label lblCliente;
        private MonthCalendar calendarDataInicio;
        private TextBox txtDataFim;
        private Label lblDataFim;
        private TextBox txtDataInicio;
        private MonthCalendar calendarDataFiim;
        private Button btnFiltrar;
    }
}