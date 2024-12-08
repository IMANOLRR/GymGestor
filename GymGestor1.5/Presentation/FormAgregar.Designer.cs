namespace GymGestor1._5
{
    partial class FormAgregar
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboAddEstadoSuscrip = new System.Windows.Forms.ComboBox();
            this.cboAddTipoSuscrip = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddCed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Info;
            this.btnAgregar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.Location = new System.Drawing.Point(377, 550);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(239, 67);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboAddEstadoSuscrip
            // 
            this.cboAddEstadoSuscrip.FormattingEnabled = true;
            this.cboAddEstadoSuscrip.Items.AddRange(new object[] {
            "Pagado",
            "En proceso",
            "Finalizado",
            "Reanudado"});
            this.cboAddEstadoSuscrip.Location = new System.Drawing.Point(377, 484);
            this.cboAddEstadoSuscrip.Name = "cboAddEstadoSuscrip";
            this.cboAddEstadoSuscrip.Size = new System.Drawing.Size(239, 24);
            this.cboAddEstadoSuscrip.TabIndex = 34;
            // 
            // cboAddTipoSuscrip
            // 
            this.cboAddTipoSuscrip.FormattingEnabled = true;
            this.cboAddTipoSuscrip.Items.AddRange(new object[] {
            "Mensual",
            "Trimestral",
            "Anual"});
            this.cboAddTipoSuscrip.Location = new System.Drawing.Point(377, 434);
            this.cboAddTipoSuscrip.Name = "cboAddTipoSuscrip";
            this.cboAddTipoSuscrip.Size = new System.Drawing.Size(239, 24);
            this.cboAddTipoSuscrip.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 48);
            this.label8.TabIndex = 32;
            this.label8.Text = "Estado de\r\nSuscripciòn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 48);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tipo de\r\nSuscripciòn";
            // 
            // txtAddDireccion
            // 
            this.txtAddDireccion.Location = new System.Drawing.Point(377, 384);
            this.txtAddDireccion.Name = "txtAddDireccion";
            this.txtAddDireccion.Size = new System.Drawing.Size(239, 22);
            this.txtAddDireccion.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(267, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Direcciòn";
            // 
            // txtAddTel
            // 
            this.txtAddTel.Location = new System.Drawing.Point(377, 334);
            this.txtAddTel.Name = "txtAddTel";
            this.txtAddTel.Size = new System.Drawing.Size(239, 22);
            this.txtAddTel.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telèfono";
            // 
            // txtAddCed
            // 
            this.txtAddCed.Location = new System.Drawing.Point(377, 284);
            this.txtAddCed.Name = "txtAddCed";
            this.txtAddCed.Size = new System.Drawing.Size(239, 22);
            this.txtAddCed.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cèdula";
            // 
            // txtAddApellido
            // 
            this.txtAddApellido.Location = new System.Drawing.Point(377, 234);
            this.txtAddApellido.Name = "txtAddApellido";
            this.txtAddApellido.Size = new System.Drawing.Size(239, 22);
            this.txtAddApellido.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAddNombre
            // 
            this.txtAddNombre.Location = new System.Drawing.Point(377, 184);
            this.txtAddNombre.Name = "txtAddNombre";
            this.txtAddNombre.Size = new System.Drawing.Size(239, 22);
            this.txtAddNombre.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 33);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(635, 99);
            this.label1.TabIndex = 20;
            this.label1.Text = "Agregar Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(938, 650);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboAddEstadoSuscrip);
            this.Controls.Add(this.cboAddTipoSuscrip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddCed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregar";
            this.Text = "FormAgregar";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboAddEstadoSuscrip;
        private System.Windows.Forms.ComboBox cboAddTipoSuscrip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddCed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}