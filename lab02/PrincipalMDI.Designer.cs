
namespace lab02
{
    partial class PrincipalMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSisSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepInventarioProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepReporteClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistema,
            this.mnuMantenimiento,
            this.mnuProcesos,
            this.mnuReportes,
            this.mnuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSistema
            // 
            this.mnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSisSalir});
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(75, 24);
            this.mnuSistema.Text = "Sistema";
            // 
            // mnuMantenimiento
            // 
            this.mnuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mnuMantenimiento.Name = "mnuMantenimiento";
            this.mnuMantenimiento.Size = new System.Drawing.Size(124, 24);
            this.mnuMantenimiento.Text = "Mantenimiento";
            // 
            // mnuProcesos
            // 
            this.mnuProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProRegistrarVenta,
            this.mnuProRegistrarCompra});
            this.mnuProcesos.Name = "mnuProcesos";
            this.mnuProcesos.Size = new System.Drawing.Size(81, 24);
            this.mnuProcesos.Text = "Procesos";
            // 
            // mnuReportes
            // 
            this.mnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepReporteVentas,
            this.mnuRepReporteCompras,
            this.mnuRepInventarioProductos,
            this.mnuRepReporteProveedores,
            this.mnuRepReporteUsuarios,
            this.mnuRepReporteClientes});
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(82, 24);
            this.mnuReportes.Text = "Reportes";
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(65, 24);
            this.mnuAyuda.Text = "Ayuda";
            // 
            // mnuSisSalir
            // 
            this.mnuSisSalir.Name = "mnuSisSalir";
            this.mnuSisSalir.Size = new System.Drawing.Size(224, 26);
            this.mnuSisSalir.Text = "Salir";
            this.mnuSisSalir.Click += new System.EventHandler(this.mnuSisSalir_Click);
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(224, 26);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(224, 26);
            this.mnuManProductos.Text = "Productos";
            this.mnuManProductos.Click += new System.EventHandler(this.mnuManProductos_Click);
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(224, 26);
            this.mnuManCategorias.Text = "Categorias";
            this.mnuManCategorias.Click += new System.EventHandler(this.mnuManCategorias_Click);
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(224, 26);
            this.mnuManProveedores.Text = "Proveedores";
            this.mnuManProveedores.Click += new System.EventHandler(this.mnuManProveedores_Click);
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(224, 26);
            this.mnuManClientes.Text = "Clientes";
            this.mnuManClientes.Click += new System.EventHandler(this.mnuManClientes_Click);
            // 
            // mnuProRegistrarVenta
            // 
            this.mnuProRegistrarVenta.Name = "mnuProRegistrarVenta";
            this.mnuProRegistrarVenta.Size = new System.Drawing.Size(224, 26);
            this.mnuProRegistrarVenta.Text = "Registrar Venta";
            // 
            // mnuProRegistrarCompra
            // 
            this.mnuProRegistrarCompra.Name = "mnuProRegistrarCompra";
            this.mnuProRegistrarCompra.Size = new System.Drawing.Size(224, 26);
            this.mnuProRegistrarCompra.Text = "Registrar Compra";
            // 
            // mnuRepReporteVentas
            // 
            this.mnuRepReporteVentas.Name = "mnuRepReporteVentas";
            this.mnuRepReporteVentas.Size = new System.Drawing.Size(252, 26);
            this.mnuRepReporteVentas.Text = "Reporte de Ventas";
            // 
            // mnuRepReporteCompras
            // 
            this.mnuRepReporteCompras.Name = "mnuRepReporteCompras";
            this.mnuRepReporteCompras.Size = new System.Drawing.Size(252, 26);
            this.mnuRepReporteCompras.Text = "Reporte de Compras";
            // 
            // mnuRepInventarioProductos
            // 
            this.mnuRepInventarioProductos.Name = "mnuRepInventarioProductos";
            this.mnuRepInventarioProductos.Size = new System.Drawing.Size(252, 26);
            this.mnuRepInventarioProductos.Text = "Inventario de Productos";
            // 
            // mnuRepReporteProveedores
            // 
            this.mnuRepReporteProveedores.Name = "mnuRepReporteProveedores";
            this.mnuRepReporteProveedores.Size = new System.Drawing.Size(252, 26);
            this.mnuRepReporteProveedores.Text = "Reporte de Proveedores";
            // 
            // mnuRepReporteUsuarios
            // 
            this.mnuRepReporteUsuarios.Name = "mnuRepReporteUsuarios";
            this.mnuRepReporteUsuarios.Size = new System.Drawing.Size(252, 26);
            this.mnuRepReporteUsuarios.Text = "Reporte de Usuarios";
            // 
            // mnuRepReporteClientes
            // 
            this.mnuRepReporteClientes.Name = "mnuRepReporteClientes";
            this.mnuRepReporteClientes.Size = new System.Drawing.Size(252, 26);
            this.mnuRepReporteClientes.Text = "Reporte de Clientes";
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 541);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuSisSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuProcesos;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuRepInventarioProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuRepReporteClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
    }
}