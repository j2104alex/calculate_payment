namespace App_calcular_pago
{
    partial class lblNombre
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nombre = new System.Windows.Forms.Label();
            this.lblSueldoBasico = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblDiasLaborados = new System.Windows.Forms.Label();
            this.lblAuxilioTransporte = new System.Windows.Forms.Label();
            this.lblTotalDevengado = new System.Windows.Forms.Label();
            this.lblBasico = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtBasico = new System.Windows.Forms.TextBox();
            this.txtAuxilioTransporte = new System.Windows.Forms.TextBox();
            this.txtTotalDevengado = new System.Windows.Forms.TextBox();
            this.txtDiasLaborados = new System.Windows.Forms.TextBox();
            this.txtSueldoBasico = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(211, 58);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 16);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // lblSueldoBasico
            // 
            this.lblSueldoBasico.AutoSize = true;
            this.lblSueldoBasico.Location = new System.Drawing.Point(211, 121);
            this.lblSueldoBasico.Name = "lblSueldoBasico";
            this.lblSueldoBasico.Size = new System.Drawing.Size(95, 16);
            this.lblSueldoBasico.TabIndex = 1;
            this.lblSueldoBasico.Text = "Sueldo Basico";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(211, 88);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(50, 16);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cedula";
            // 
            // lblDiasLaborados
            // 
            this.lblDiasLaborados.AutoSize = true;
            this.lblDiasLaborados.Location = new System.Drawing.Point(211, 157);
            this.lblDiasLaborados.Name = "lblDiasLaborados";
            this.lblDiasLaborados.Size = new System.Drawing.Size(104, 16);
            this.lblDiasLaborados.TabIndex = 3;
            this.lblDiasLaborados.Text = "Días Laborados";
            // 
            // lblAuxilioTransporte
            // 
            this.lblAuxilioTransporte.AutoSize = true;
            this.lblAuxilioTransporte.Location = new System.Drawing.Point(211, 228);
            this.lblAuxilioTransporte.Name = "lblAuxilioTransporte";
            this.lblAuxilioTransporte.Size = new System.Drawing.Size(115, 16);
            this.lblAuxilioTransporte.TabIndex = 4;
            this.lblAuxilioTransporte.Text = "Auxilio Transporte";
            // 
            // lblTotalDevengado
            // 
            this.lblTotalDevengado.AutoSize = true;
            this.lblTotalDevengado.Location = new System.Drawing.Point(211, 266);
            this.lblTotalDevengado.Name = "lblTotalDevengado";
            this.lblTotalDevengado.Size = new System.Drawing.Size(113, 16);
            this.lblTotalDevengado.TabIndex = 5;
            this.lblTotalDevengado.Text = "Total Devengado";
            // 
            // lblBasico
            // 
            this.lblBasico.AutoSize = true;
            this.lblBasico.Location = new System.Drawing.Point(212, 195);
            this.lblBasico.Name = "lblBasico";
            this.lblBasico.Size = new System.Drawing.Size(49, 16);
            this.lblBasico.TabIndex = 6;
            this.lblBasico.Text = "Basico";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(330, 327);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 42);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(430, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtBasico
            // 
            this.txtBasico.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBasico.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBasico.Location = new System.Drawing.Point(430, 192);
            this.txtBasico.Name = "txtBasico";
            this.txtBasico.Size = new System.Drawing.Size(192, 22);
            this.txtBasico.TabIndex = 9;
            // 
            // txtAuxilioTransporte
            // 
            this.txtAuxilioTransporte.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAuxilioTransporte.Location = new System.Drawing.Point(430, 225);
            this.txtAuxilioTransporte.Name = "txtAuxilioTransporte";
            this.txtAuxilioTransporte.Size = new System.Drawing.Size(192, 22);
            this.txtAuxilioTransporte.TabIndex = 10;
            // 
            // txtTotalDevengado
            // 
            this.txtTotalDevengado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotalDevengado.Location = new System.Drawing.Point(430, 260);
            this.txtTotalDevengado.Name = "txtTotalDevengado";
            this.txtTotalDevengado.Size = new System.Drawing.Size(192, 22);
            this.txtTotalDevengado.TabIndex = 11;
            // 
            // txtDiasLaborados
            // 
            this.txtDiasLaborados.Location = new System.Drawing.Point(430, 157);
            this.txtDiasLaborados.Name = "txtDiasLaborados";
            this.txtDiasLaborados.Size = new System.Drawing.Size(192, 22);
            this.txtDiasLaborados.TabIndex = 12;
            // 
            // txtSueldoBasico
            // 
            this.txtSueldoBasico.Location = new System.Drawing.Point(430, 118);
            this.txtSueldoBasico.Name = "txtSueldoBasico";
            this.txtSueldoBasico.Size = new System.Drawing.Size(192, 22);
            this.txtSueldoBasico.TabIndex = 13;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(430, 82);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(192, 22);
            this.txtCedula.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtSueldoBasico);
            this.Controls.Add(this.txtDiasLaborados);
            this.Controls.Add(this.txtTotalDevengado);
            this.Controls.Add(this.txtAuxilioTransporte);
            this.Controls.Add(this.txtBasico);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblBasico);
            this.Controls.Add(this.lblTotalDevengado);
            this.Controls.Add(this.lblAuxilioTransporte);
            this.Controls.Add(this.lblDiasLaborados);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblSueldoBasico);
            this.Controls.Add(this.Nombre);
            this.Name = "lblNombre";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label lblSueldoBasico;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblDiasLaborados;
        private System.Windows.Forms.Label lblAuxilioTransporte;
        private System.Windows.Forms.Label lblTotalDevengado;
        private System.Windows.Forms.Label lblBasico;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtBasico;
        private System.Windows.Forms.TextBox txtAuxilioTransporte;
        private System.Windows.Forms.TextBox txtTotalDevengado;
        private System.Windows.Forms.TextBox txtDiasLaborados;
        private System.Windows.Forms.TextBox txtSueldoBasico;
        private System.Windows.Forms.TextBox txtCedula;
    }
}
