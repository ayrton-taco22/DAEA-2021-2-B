using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }

        private void mnuSisSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frmusuarios = new frmUsuarios();
            frmusuarios.MdiParent = this;
            frmusuarios.Show();
        }

        private void mnuManProveedores_Click(object sender, EventArgs e)
        {
            manProveedores frmProveedores = new manProveedores();
            frmProveedores.MdiParent = this;
            frmProveedores.Show();
        }

        private void mnuManProductos_Click(object sender, EventArgs e)
        {
            manProductos frmProductos = new manProductos();
            frmProductos.MdiParent = this;
            frmProductos.Show();
        }

        private void mnuManCategorias_Click(object sender, EventArgs e)
        {
            manCategorias frmCategorias = new manCategorias();
            frmCategorias.MdiParent = this;
            frmCategorias.Show();
        }

        private void mnuManClientes_Click(object sender, EventArgs e)
        {
            manClientes frmClientes = new manClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }
    }
}
