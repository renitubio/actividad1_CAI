namespace actividad1_CAI
{
    partial class frmGestionOperador
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
            Label label6;
            label7 = new Label();
            cmbUrgencia = new ComboBox();
            cmbCategoriaProblema = new ComboBox();
            txtObservaciones = new TextBox();
            lblObservaciones = new Label();
            lblTickets = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            gbInfoTicket = new GroupBox();
            txtinfoTicket = new TextBox();
            cmbTecnicos = new ComboBox();
            lblTecnicos = new Label();
            btnDerivar = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbInfoTicket.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(595, 63);
            label6.Name = "label6";
            label6.Size = new Size(88, 25);
            label6.TabIndex = 12;
            label6.Text = "Categoría";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(595, 142);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 9;
            label7.Text = "Urgencia";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbUrgencia
            // 
            cmbUrgencia.FormattingEnabled = true;
            cmbUrgencia.Items.AddRange(new object[] { "Baja", "Media", "Alta" });
            cmbUrgencia.Location = new Point(595, 181);
            cmbUrgencia.Name = "cmbUrgencia";
            cmbUrgencia.Size = new Size(182, 33);
            cmbUrgencia.TabIndex = 10;
            // 
            // cmbCategoriaProblema
            // 
            cmbCategoriaProblema.FormattingEnabled = true;
            cmbCategoriaProblema.Items.AddRange(new object[] { "Hardware", "Software", "Red/conectividad", "Otro" });
            cmbCategoriaProblema.Location = new Point(595, 91);
            cmbCategoriaProblema.Name = "cmbCategoriaProblema";
            cmbCategoriaProblema.Size = new Size(182, 33);
            cmbCategoriaProblema.TabIndex = 11;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(595, 272);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(182, 123);
            txtObservaciones.TabIndex = 13;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(599, 240);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(128, 25);
            lblObservaciones.TabIndex = 14;
            lblObservaciones.Text = "Observaciones";
            lblObservaciones.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Location = new Point(12, 53);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(154, 25);
            lblTickets.TabIndex = 16;
            lblTickets.Text = "Tickets sin asignar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Cliente, Fecha });
            dataGridView1.Location = new Point(12, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(514, 131);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "N° de ticket";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 8;
            Cliente.Name = "Cliente";
            Cliente.Width = 150;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 8;
            Fecha.Name = "Fecha";
            Fecha.Width = 150;
            // 
            // gbInfoTicket
            // 
            gbInfoTicket.Controls.Add(txtinfoTicket);
            gbInfoTicket.Location = new Point(12, 244);
            gbInfoTicket.Name = "gbInfoTicket";
            gbInfoTicket.Size = new Size(514, 154);
            gbInfoTicket.TabIndex = 18;
            gbInfoTicket.TabStop = false;
            gbInfoTicket.Text = "Información del ticket seleccionado";
            // 
            // txtinfoTicket
            // 
            txtinfoTicket.Location = new Point(23, 30);
            txtinfoTicket.Multiline = true;
            txtinfoTicket.Name = "txtinfoTicket";
            txtinfoTicket.Size = new Size(466, 103);
            txtinfoTicket.TabIndex = 22;
            // 
            // cmbTecnicos
            // 
            cmbTecnicos.FormattingEnabled = true;
            cmbTecnicos.Items.AddRange(new object[] { "Juan Perez (general.)", "Melanie Fernandez (general.)", "Estefanía Mendez (S.O)", "Juan Uriarte (instalaciones)", "Aroldo Luis (conectividad)" });
            cmbTecnicos.Location = new Point(224, 479);
            cmbTecnicos.Name = "cmbTecnicos";
            cmbTecnicos.Size = new Size(182, 33);
            cmbTecnicos.TabIndex = 19;
            // 
            // lblTecnicos
            // 
            lblTecnicos.AutoSize = true;
            lblTecnicos.Location = new Point(224, 451);
            lblTecnicos.Name = "lblTecnicos";
            lblTecnicos.Size = new Size(173, 25);
            lblTecnicos.TabIndex = 20;
            lblTecnicos.Text = "Técnicos disponibles";
            // 
            // btnDerivar
            // 
            btnDerivar.Location = new Point(424, 461);
            btnDerivar.Name = "btnDerivar";
            btnDerivar.Size = new Size(169, 43);
            btnDerivar.TabIndex = 21;
            btnDerivar.Text = "Derivar al técnico";
            btnDerivar.UseVisualStyleBackColor = true;
            btnDerivar.Click += btnDerivar_Click;
            // 
            // frmGestionOperador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 574);
            Controls.Add(btnDerivar);
            Controls.Add(lblTecnicos);
            Controls.Add(cmbTecnicos);
            Controls.Add(gbInfoTicket);
            Controls.Add(dataGridView1);
            Controls.Add(lblTickets);
            Controls.Add(lblObservaciones);
            Controls.Add(txtObservaciones);
            Controls.Add(label6);
            Controls.Add(cmbCategoriaProblema);
            Controls.Add(cmbUrgencia);
            Controls.Add(label7);
            Name = "frmGestionOperador";
            Text = "Derivación de tickets";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbInfoTicket.ResumeLayout(false);
            gbInfoTicket.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private ComboBox cmbUrgencia;
        private ComboBox cmbCategoriaProblema;
        private TextBox txtObservaciones;
        private Label lblObservaciones;
        private Label lblTickets;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Fecha;
        private GroupBox gbInfoTicket;
        private ComboBox cmbTecnicos;
        private Label lblTecnicos;
        private Button btnDerivar;
        private TextBox txtinfoTicket;
    }
}