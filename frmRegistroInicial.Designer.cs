namespace actividad1_CAI
{
    partial class RegistroTicket
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNombreCompleto = new TextBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            btnEnviar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombreCompleto);
            groupBox1.Location = new Point(31, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 227);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 5;
            label3.Text = "Teléfono";
            label3.Click += label3_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(17, 267);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(283, 31);
            txtTelefono.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(17, 182);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(283, 31);
            txtCorreo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 142);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 2;
            label2.Text = "Correo electrónico";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 45);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre y Apellido";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(17, 89);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(283, 31);
            txtNombreCompleto.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtDescripcion);
            groupBox2.Location = new Point(409, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 329);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle del problema";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 45);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 10;
            label8.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(15, 73);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(182, 225);
            txtDescripcion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(777, 186);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(283, 383);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(174, 40);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // RegistroTicket
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 450);
            Controls.Add(btnEnviar);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RegistroTicket";
            Text = "Registro del Incidente";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtNombreCompleto;
        private Label label3;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Label label2;
        private GroupBox groupBox2;
        private Label label5;
        private Label label8;
        private TextBox txtDescripcion;
        private Button btnEnviar;
    }
}
