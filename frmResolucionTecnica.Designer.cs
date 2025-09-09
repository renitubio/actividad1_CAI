namespace actividad1_CAI
{
    partial class frmResolucionTecnica
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            columCategoria = new DataGridViewTextBoxColumn();
            ColumEstado = new DataGridViewTextBoxColumn();
            lblTicketsAsignados = new Label();
            grbxInfoTickets = new GroupBox();
            lbxDetalleTicket = new ListBox();
            lblDiagnostico = new Label();
            txtDiagnostico = new TextBox();
            txtIntervencion = new TextBox();
            lblIntervencion = new Label();
            lblActEstado = new Label();
            cbxEstados = new ComboBox();
            btnAdjuntar = new Button();
            btnActTicket = new Button();
            ColumUrgencia = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grbxInfoTickets.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Cliente, columCategoria, ColumEstado, ColumUrgencia });
            dataGridView1.Location = new Point(19, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(815, 131);
            dataGridView1.TabIndex = 18;
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
            // columCategoria
            // 
            columCategoria.HeaderText = "Categoría";
            columCategoria.MinimumWidth = 8;
            columCategoria.Name = "columCategoria";
            columCategoria.Width = 150;
            // 
            // ColumEstado
            // 
            ColumEstado.HeaderText = "Estado";
            ColumEstado.MinimumWidth = 8;
            ColumEstado.Name = "ColumEstado";
            ColumEstado.Resizable = DataGridViewTriState.True;
            ColumEstado.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumEstado.Width = 150;
            // 
            // lblTicketsAsignados
            // 
            lblTicketsAsignados.AutoSize = true;
            lblTicketsAsignados.Location = new Point(65, 24);
            lblTicketsAsignados.Name = "lblTicketsAsignados";
            lblTicketsAsignados.Size = new Size(154, 25);
            lblTicketsAsignados.TabIndex = 19;
            lblTicketsAsignados.Text = "Tickets Asignados";
            lblTicketsAsignados.Click += lblTicketsAsignados_Click;
            // 
            // grbxInfoTickets
            // 
            grbxInfoTickets.Controls.Add(lbxDetalleTicket);
            grbxInfoTickets.Location = new Point(19, 206);
            grbxInfoTickets.Name = "grbxInfoTickets";
            grbxInfoTickets.Size = new Size(270, 207);
            grbxInfoTickets.TabIndex = 20;
            grbxInfoTickets.TabStop = false;
            grbxInfoTickets.Text = "Detalle del ticket seleccionado";
            grbxInfoTickets.UseWaitCursor = true;
            // 
            // lbxDetalleTicket
            // 
            lbxDetalleTicket.FormattingEnabled = true;
            lbxDetalleTicket.Location = new Point(18, 38);
            lbxDetalleTicket.Name = "lbxDetalleTicket";
            lbxDetalleTicket.Size = new Size(230, 154);
            lbxDetalleTicket.TabIndex = 0;
            lbxDetalleTicket.UseWaitCursor = true;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Location = new Point(313, 235);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(107, 25);
            lblDiagnostico.TabIndex = 21;
            lblDiagnostico.Text = "Diagnóstico";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(313, 261);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(209, 148);
            txtDiagnostico.TabIndex = 22;
            // 
            // txtIntervencion
            // 
            txtIntervencion.Location = new Point(547, 263);
            txtIntervencion.Multiline = true;
            txtIntervencion.Name = "txtIntervencion";
            txtIntervencion.Size = new Size(202, 148);
            txtIntervencion.TabIndex = 23;
            // 
            // lblIntervencion
            // 
            lblIntervencion.AutoSize = true;
            lblIntervencion.Location = new Point(547, 235);
            lblIntervencion.Name = "lblIntervencion";
            lblIntervencion.Size = new Size(183, 25);
            lblIntervencion.TabIndex = 24;
            lblIntervencion.Text = "Intervención realizada";
            lblIntervencion.Click += lblIntervencion_Click;
            // 
            // lblActEstado
            // 
            lblActEstado.AutoSize = true;
            lblActEstado.Location = new Point(547, 449);
            lblActEstado.Name = "lblActEstado";
            lblActEstado.Size = new Size(203, 25);
            lblActEstado.TabIndex = 25;
            lblActEstado.Text = "Actualización del estado";
            lblActEstado.Click += lblActEstado_Click;
            // 
            // cbxEstados
            // 
            cbxEstados.FormattingEnabled = true;
            cbxEstados.Items.AddRange(new object[] { "En proceso", "Requiere aprobación", "Resuelto" });
            cbxEstados.Location = new Point(547, 478);
            cbxEstados.Name = "cbxEstados";
            cbxEstados.Size = new Size(198, 33);
            cbxEstados.TabIndex = 26;
            // 
            // btnAdjuntar
            // 
            btnAdjuntar.Location = new Point(329, 471);
            btnAdjuntar.Name = "btnAdjuntar";
            btnAdjuntar.Size = new Size(193, 40);
            btnAdjuntar.TabIndex = 27;
            btnAdjuntar.Text = "Adjuntar evidencia";
            btnAdjuntar.UseVisualStyleBackColor = true;
            // 
            // btnActTicket
            // 
            btnActTicket.Cursor = Cursors.Cross;
            btnActTicket.Location = new Point(613, 574);
            btnActTicket.Name = "btnActTicket";
            btnActTicket.Size = new Size(132, 42);
            btnActTicket.TabIndex = 28;
            btnActTicket.Text = "Actualizar";
            btnActTicket.UseVisualStyleBackColor = true;
            btnActTicket.Click += btnActTicket_Click;
            // 
            // ColumUrgencia
            // 
            ColumUrgencia.HeaderText = "Urgencia";
            ColumUrgencia.MinimumWidth = 8;
            ColumUrgencia.Name = "ColumUrgencia";
            ColumUrgencia.Width = 150;
            // 
            // frmResolucionTecnica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 657);
            Controls.Add(btnActTicket);
            Controls.Add(btnAdjuntar);
            Controls.Add(cbxEstados);
            Controls.Add(lblActEstado);
            Controls.Add(lblIntervencion);
            Controls.Add(txtIntervencion);
            Controls.Add(txtDiagnostico);
            Controls.Add(lblDiagnostico);
            Controls.Add(grbxInfoTickets);
            Controls.Add(lblTicketsAsignados);
            Controls.Add(dataGridView1);
            Name = "frmResolucionTecnica";
            Text = "ResolucionTecnica";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grbxInfoTickets.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblTicketsAsignados;
        private GroupBox grbxInfoTickets;
        private Label lblDiagnostico;
        private TextBox txtDiagnostico;
        private TextBox txtIntervencion;
        private Label lblIntervencion;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn columCategoria;
        private DataGridViewTextBoxColumn ColumEstado;
        private Label lblActEstado;
        private ComboBox cbxEstados;
        private Button btnAdjuntar;
        private Button btnActTicket;
        private ListBox lbxDetalleTicket;
        private DataGridViewTextBoxColumn ColumUrgencia;
    }
}