
namespace Lab04
{
    partial class Curso
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
            this.btnListarCurso = new System.Windows.Forms.Button();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.btnBuscarCurso = new System.Windows.Forms.Button();
            this.dgvListadoCurso = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarCurso
            // 
            this.btnListarCurso.Location = new System.Drawing.Point(12, 23);
            this.btnListarCurso.Name = "btnListarCurso";
            this.btnListarCurso.Size = new System.Drawing.Size(111, 33);
            this.btnListarCurso.TabIndex = 0;
            this.btnListarCurso.Text = "Listar";
            this.btnListarCurso.UseVisualStyleBackColor = true;
            this.btnListarCurso.Click += new System.EventHandler(this.btnListarCurso_Click);
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCurso.Location = new System.Drawing.Point(300, 26);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(314, 30);
            this.txtNombreCurso.TabIndex = 1;
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.Location = new System.Drawing.Point(635, 21);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(98, 35);
            this.btnBuscarCurso.TabIndex = 2;
            this.btnBuscarCurso.Text = "Buscar";
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            this.btnBuscarCurso.Click += new System.EventHandler(this.btnBuscarCurso_Click);
            // 
            // dgvListadoCurso
            // 
            this.dgvListadoCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoCurso.Location = new System.Drawing.Point(12, 84);
            this.dgvListadoCurso.Name = "dgvListadoCurso";
            this.dgvListadoCurso.RowHeadersWidth = 51;
            this.dgvListadoCurso.RowTemplate.Height = 24;
            this.dgvListadoCurso.Size = new System.Drawing.Size(721, 423);
            this.dgvListadoCurso.TabIndex = 3;
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 519);
            this.Controls.Add(this.dgvListadoCurso);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.btnListarCurso);
            this.Name = "Curso";
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.Curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.DataGridView dgvListadoCurso;
    }
}