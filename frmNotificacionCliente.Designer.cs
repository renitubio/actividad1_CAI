namespace actividad1_CAI
{
    partial class frmNotificacionCliente
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
            label1 = new Label();
            cmbCalificacion = new ComboBox();
            lblCalificacion = new Label();
            lblResolucion = new Label();
            cmbSiNo = new ComboBox();
            lblComentario = new Label();
            textBox1 = new TextBox();
            btnRespuesta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(300, 32);
            label1.TabIndex = 0;
            label1.Text = "Respuesta de satisfacción";
            label1.Click += label1_Click;
            // 
            // cmbCalificacion
            // 
            cmbCalificacion.FormattingEnabled = true;
            cmbCalificacion.Items.AddRange(new object[] { "Excelente", "Muy Buena", "Buena", "Regular", "Mala" });
            cmbCalificacion.Location = new Point(43, 122);
            cmbCalificacion.Name = "cmbCalificacion";
            cmbCalificacion.Size = new Size(237, 33);
            cmbCalificacion.TabIndex = 1;
            cmbCalificacion.SelectedIndexChanged += cmbCalificacion_SelectedIndexChanged;
            // 
            // lblCalificacion
            // 
            lblCalificacion.AutoSize = true;
            lblCalificacion.Location = new Point(40, 94);
            lblCalificacion.Name = "lblCalificacion";
            lblCalificacion.Size = new Size(237, 25);
            lblCalificacion.TabIndex = 2;
            lblCalificacion.Text = "Califique la atención recibida";
            // 
            // lblResolucion
            // 
            lblResolucion.AutoSize = true;
            lblResolucion.Location = new Point(43, 192);
            lblResolucion.Name = "lblResolucion";
            lblResolucion.Size = new Size(219, 25);
            lblResolucion.TabIndex = 3;
            lblResolucion.Text = "¿Su problema se resolvió?";
            // 
            // cmbSiNo
            // 
            cmbSiNo.FormattingEnabled = true;
            cmbSiNo.Items.AddRange(new object[] { "Si", "No" });
            cmbSiNo.Location = new Point(43, 220);
            cmbSiNo.Name = "cmbSiNo";
            cmbSiNo.Size = new Size(237, 33);
            cmbSiNo.TabIndex = 4;
            cmbSiNo.SelectedIndexChanged += cmbSiNo_SelectedIndexChanged;
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Location = new Point(40, 317);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(302, 25);
            lblComentario.TabIndex = 5;
            lblComentario.Text = "Dejanos un comentario para mejorar";
            lblComentario.Click += lblComentario_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 345);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 97);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnRespuesta
            // 
            btnRespuesta.Location = new Point(236, 482);
            btnRespuesta.Name = "btnRespuesta";
            btnRespuesta.Size = new Size(225, 40);
            btnRespuesta.TabIndex = 7;
            btnRespuesta.Text = "Confirmar recepción";
            btnRespuesta.UseVisualStyleBackColor = true;
            // 
            // frmNotificacionCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 535);
            Controls.Add(btnRespuesta);
            Controls.Add(textBox1);
            Controls.Add(lblComentario);
            Controls.Add(cmbSiNo);
            Controls.Add(lblResolucion);
            Controls.Add(lblCalificacion);
            Controls.Add(cmbCalificacion);
            Controls.Add(label1);
            Name = "frmNotificacionCliente";
            Text = "Notificación de cierre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCalificacion;
        private Label lblCalificacion;
        private Label lblResolucion;
        private ComboBox cmbSiNo;
        private Label lblComentario;
        private TextBox textBox1;
        private Button btnRespuesta;
    }
}