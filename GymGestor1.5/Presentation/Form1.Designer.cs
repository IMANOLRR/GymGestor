namespace GymGestor1._5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstbInfoClientes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregarClase = new System.Windows.Forms.Button();
            this.btnEditarClase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 61);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(447, 99);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gym Gestor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // lstbInfoClientes
            // 
            this.lstbInfoClientes.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbInfoClientes.FormattingEnabled = true;
            this.lstbInfoClientes.ItemHeight = 24;
            this.lstbInfoClientes.Location = new System.Drawing.Point(119, 398);
            this.lstbInfoClientes.Name = "lstbInfoClientes";
            this.lstbInfoClientes.Size = new System.Drawing.Size(412, 244);
            this.lstbInfoClientes.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Inserte la Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(301, 359);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(230, 30);
            this.txtCedula.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar Clientes";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Info;
            this.btnEliminar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEliminar.Location = new System.Drawing.Point(679, 388);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 60);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar Usuario";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Info;
            this.btnEditar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEditar.Location = new System.Drawing.Point(484, 195);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(145, 60);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Info;
            this.btnBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBuscar.Location = new System.Drawing.Point(301, 195);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 60);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Info;
            this.btnAgregar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.Location = new System.Drawing.Point(119, 195);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 60);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Info;
            this.btnLimpiar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLimpiar.Location = new System.Drawing.Point(679, 489);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 98);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregarClase
            // 
            this.btnAgregarClase.BackColor = System.Drawing.SystemColors.Info;
            this.btnAgregarClase.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarClase.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarClase.Location = new System.Drawing.Point(679, 195);
            this.btnAgregarClase.Name = "btnAgregarClase";
            this.btnAgregarClase.Size = new System.Drawing.Size(145, 60);
            this.btnAgregarClase.TabIndex = 18;
            this.btnAgregarClase.Text = "Agregar Clase";
            this.btnAgregarClase.UseVisualStyleBackColor = false;
            this.btnAgregarClase.Click += new System.EventHandler(this.btnAgregarClase_Click);
            // 
            // btnEditarClase
            // 
            this.btnEditarClase.BackColor = System.Drawing.SystemColors.Info;
            this.btnEditarClase.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarClase.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEditarClase.Location = new System.Drawing.Point(679, 289);
            this.btnEditarClase.Name = "btnEditarClase";
            this.btnEditarClase.Size = new System.Drawing.Size(145, 60);
            this.btnEditarClase.TabIndex = 19;
            this.btnEditarClase.Text = "Editar/Buscar Clase";
            this.btnEditarClase.UseVisualStyleBackColor = false;
            this.btnEditarClase.Click += new System.EventHandler(this.btnEditarClase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(938, 650);
            this.Controls.Add(this.btnEditarClase);
            this.Controls.Add(this.btnAgregarClase);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstbInfoClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbInfoClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregarClase;
        private System.Windows.Forms.Button btnEditarClase;
    }
}

