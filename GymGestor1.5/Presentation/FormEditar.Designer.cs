namespace GymGestor1._5
{
    partial class FormEditar
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConfirmarCambios = new System.Windows.Forms.Button();
            this.cmbEstadoSuscripcion = new System.Windows.Forms.ComboBox();
            this.cmbTipoSuscripcion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Info;
            this.btnBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBuscar.Location = new System.Drawing.Point(616, 180);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(196, 41);
            this.btnBuscar.TabIndex = 54;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConfirmarCambios
            // 
            this.btnConfirmarCambios.BackColor = System.Drawing.SystemColors.Info;
            this.btnConfirmarCambios.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCambios.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnConfirmarCambios.Location = new System.Drawing.Point(351, 550);
            this.btnConfirmarCambios.Name = "btnConfirmarCambios";
            this.btnConfirmarCambios.Size = new System.Drawing.Size(239, 67);
            this.btnConfirmarCambios.TabIndex = 53;
            this.btnConfirmarCambios.Text = "Confirmar Cambios";
            this.btnConfirmarCambios.UseVisualStyleBackColor = false;
            this.btnConfirmarCambios.Click += new System.EventHandler(this.btnConfirmarCambios_Click);
            // 
            // cmbEstadoSuscripcion
            // 
            this.cmbEstadoSuscripcion.FormattingEnabled = true;
            this.cmbEstadoSuscripcion.Items.AddRange(new object[] {
            "Pagado",
            "En proceso",
            "Finalizado",
            "Reanudado"});
            this.cmbEstadoSuscripcion.Location = new System.Drawing.Point(351, 484);
            this.cmbEstadoSuscripcion.Name = "cmbEstadoSuscripcion";
            this.cmbEstadoSuscripcion.Size = new System.Drawing.Size(239, 24);
            this.cmbEstadoSuscripcion.TabIndex = 52;
            // 
            // cmbTipoSuscripcion
            // 
            this.cmbTipoSuscripcion.FormattingEnabled = true;
            this.cmbTipoSuscripcion.Items.AddRange(new object[] {
            "Mensual",
            "Trimestral",
            "Anual"});
            this.cmbTipoSuscripcion.Location = new System.Drawing.Point(351, 434);
            this.cmbTipoSuscripcion.Name = "cmbTipoSuscripcion";
            this.cmbTipoSuscripcion.Size = new System.Drawing.Size(239, 24);
            this.cmbTipoSuscripcion.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 48);
            this.label8.TabIndex = 50;
            this.label8.Text = "Estado de\r\nSuscripciòn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(225, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 48);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tipo de\r\nSuscripciòn";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(351, 384);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(239, 22);
            this.txtDireccion.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "Direcciòn";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(351, 334);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(239, 22);
            this.txtTel.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Telèfono";
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(351, 191);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(239, 22);
            this.txtCed.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Cèdula";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(351, 286);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(239, 22);
            this.txtApellido.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(351, 236);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(239, 22);
            this.txtNombre.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 33);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(565, 99);
            this.label1.TabIndex = 38;
            this.label1.Text = "Editar Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(938, 650);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnConfirmarCambios);
            this.Controls.Add(this.cmbEstadoSuscripcion);
            this.Controls.Add(this.cmbTipoSuscripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditar";
            this.Text = "FormEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConfirmarCambios;
        private System.Windows.Forms.ComboBox cmbEstadoSuscripcion;
        private System.Windows.Forms.ComboBox cmbTipoSuscripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}