
namespace lab05
{
    partial class ManPerson
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnrollmentDate = new System.Windows.Forms.DateTimePicker();
            this.txtHireDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnBuscarApellido = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.txtBuscarApe = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEnrollmentDate);
            this.groupBox1.Controls.Add(this.txtHireDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtPersonID);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Inscripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contrato";
            // 
            // txtEnrollmentDate
            // 
            this.txtEnrollmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEnrollmentDate.Location = new System.Drawing.Point(276, 187);
            this.txtEnrollmentDate.Name = "txtEnrollmentDate";
            this.txtEnrollmentDate.Size = new System.Drawing.Size(245, 22);
            this.txtEnrollmentDate.TabIndex = 7;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtHireDate.Location = new System.Drawing.Point(7, 186);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(228, 22);
            this.txtHireDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(279, 115);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(242, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(7, 115);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(228, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(10, 43);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(84, 22);
            this.txtPersonID.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(608, 27);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(90, 32);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(19, 275);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 33);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(172, 566);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(116, 38);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(307, 566);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 38);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(467, 566);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 38);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 374);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 24;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(686, 171);
            this.dgvListado.TabIndex = 6;
            this.dgvListado.SelectionChanged += new System.EventHandler(this.dgvListado_SelectionChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(19, 566);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(122, 38);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Location = new System.Drawing.Point(198, 269);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(90, 45);
            this.btnBuscarNombre.TabIndex = 8;
            this.btnBuscarNombre.Text = "Buscar por nombre";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // btnBuscarApellido
            // 
            this.btnBuscarApellido.Location = new System.Drawing.Point(396, 269);
            this.btnBuscarApellido.Name = "btnBuscarApellido";
            this.btnBuscarApellido.Size = new System.Drawing.Size(90, 45);
            this.btnBuscarApellido.TabIndex = 9;
            this.btnBuscarApellido.Text = "Buscar por Apellido";
            this.btnBuscarApellido.UseVisualStyleBackColor = true;
            this.btnBuscarApellido.Click += new System.EventHandler(this.btnBuscarApellido_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(22, 334);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(119, 22);
            this.txtBuscarCodigo.TabIndex = 10;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(198, 334);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(119, 22);
            this.txtBuscarNombre.TabIndex = 11;
            // 
            // txtBuscarApe
            // 
            this.txtBuscarApe.Location = new System.Drawing.Point(396, 334);
            this.txtBuscarApe.Name = "txtBuscarApe";
            this.txtBuscarApe.Size = new System.Drawing.Size(119, 22);
            this.txtBuscarApe.TabIndex = 12;
            // 
            // ManPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 616);
            this.Controls.Add(this.txtBuscarApe);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.txtBuscarCodigo);
            this.Controls.Add(this.btnBuscarApellido);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManPerson";
            this.Text = "Mantenimiento de Personas";
            this.Load += new System.EventHandler(this.ManPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtEnrollmentDate;
        private System.Windows.Forms.DateTimePicker txtHireDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Button btnBuscarApellido;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.TextBox txtBuscarApe;
    }
}

