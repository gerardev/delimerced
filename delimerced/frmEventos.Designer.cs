namespace delimerced
{
    partial class frmEventos
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRep_ev = new System.Windows.Forms.Button();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.lblFechaE = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPrecioE = new System.Windows.Forms.Label();
            this.txtPrecioE = new System.Windows.Forms.TextBox();
            this.lblTipoE = new System.Windows.Forms.Label();
            this.cmbTipoE = new System.Windows.Forms.ComboBox();
            this.lblDireccionE = new System.Windows.Forms.Label();
            this.txtDireccionE = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(53, 26);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(89, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Guardar";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(210, 26);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(103, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(374, 26);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(427, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRep_ev
            // 
            this.btnRep_ev.Location = new System.Drawing.Point(311, 290);
            this.btnRep_ev.Name = "btnRep_ev";
            this.btnRep_ev.Size = new System.Drawing.Size(92, 23);
            this.btnRep_ev.TabIndex = 4;
            this.btnRep_ev.Text = "Generar reporte";
            this.btnRep_ev.UseVisualStyleBackColor = true;
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(26, 66);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(100, 13);
            this.lblNombreE.TabIndex = 5;
            this.lblNombreE.Text = "Nombre del evento:";
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(29, 82);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(222, 20);
            this.txtNombreE.TabIndex = 6;
            // 
            // lblFechaE
            // 
            this.lblFechaE.AutoSize = true;
            this.lblFechaE.Location = new System.Drawing.Point(264, 66);
            this.lblFechaE.Name = "lblFechaE";
            this.lblFechaE.Size = new System.Drawing.Size(40, 13);
            this.lblFechaE.TabIndex = 7;
            this.lblFechaE.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblPrecioE
            // 
            this.lblPrecioE.AutoSize = true;
            this.lblPrecioE.Location = new System.Drawing.Point(26, 115);
            this.lblPrecioE.Name = "lblPrecioE";
            this.lblPrecioE.Size = new System.Drawing.Size(55, 13);
            this.lblPrecioE.TabIndex = 9;
            this.lblPrecioE.Text = "Precio ($):";
            // 
            // txtPrecioE
            // 
            this.txtPrecioE.Location = new System.Drawing.Point(29, 131);
            this.txtPrecioE.Name = "txtPrecioE";
            this.txtPrecioE.Size = new System.Drawing.Size(72, 20);
            this.txtPrecioE.TabIndex = 10;
            this.txtPrecioE.TextChanged += new System.EventHandler(this.txtPrecioE_TextChanged);
            this.txtPrecioE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioE_KeyPress);
            // 
            // lblTipoE
            // 
            this.lblTipoE.AutoSize = true;
            this.lblTipoE.Location = new System.Drawing.Point(118, 115);
            this.lblTipoE.Name = "lblTipoE";
            this.lblTipoE.Size = new System.Drawing.Size(31, 13);
            this.lblTipoE.TabIndex = 11;
            this.lblTipoE.Text = "Tipo:";
            // 
            // cmbTipoE
            // 
            this.cmbTipoE.FormattingEnabled = true;
            this.cmbTipoE.Items.AddRange(new object[] {
            "Servicio completo",
            "Solo comida"});
            this.cmbTipoE.Location = new System.Drawing.Point(121, 131);
            this.cmbTipoE.Name = "cmbTipoE";
            this.cmbTipoE.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoE.TabIndex = 13;
            // 
            // lblDireccionE
            // 
            this.lblDireccionE.AutoSize = true;
            this.lblDireccionE.Location = new System.Drawing.Point(264, 115);
            this.lblDireccionE.Name = "lblDireccionE";
            this.lblDireccionE.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionE.TabIndex = 14;
            this.lblDireccionE.Text = "Dirección:";
            // 
            // txtDireccionE
            // 
            this.txtDireccionE.Location = new System.Drawing.Point(267, 131);
            this.txtDireccionE.Name = "txtDireccionE";
            this.txtDireccionE.Size = new System.Drawing.Size(200, 20);
            this.txtDireccionE.TabIndex = 15;
            this.txtDireccionE.TextChanged += new System.EventHandler(this.txtDireccionE_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(29, 176);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(438, 97);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 325);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtDireccionE);
            this.Controls.Add(this.lblDireccionE);
            this.Controls.Add(this.cmbTipoE);
            this.Controls.Add(this.lblTipoE);
            this.Controls.Add(this.txtPrecioE);
            this.Controls.Add(this.lblPrecioE);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFechaE);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.lblNombreE);
            this.Controls.Add(this.btnRep_ev);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCrear);
            this.Name = "frmEventos";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.frmEventos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRep_ev;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label lblFechaE;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPrecioE;
        private System.Windows.Forms.TextBox txtPrecioE;
        private System.Windows.Forms.Label lblTipoE;
        private System.Windows.Forms.ComboBox cmbTipoE;
        private System.Windows.Forms.Label lblDireccionE;
        private System.Windows.Forms.TextBox txtDireccionE;
        private System.Windows.Forms.ListView listView1;
    }
}