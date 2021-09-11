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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //TODO - CREAR FORMULARIO MDI PARA ENLAZAR
            String usuario = "Admin";
            String password = "Admin";
            PrincipalMDI principal = new PrincipalMDI();
            if (txtUsuario.Text == usuario && txtPassword.Text == password) {
                
                principal.Show();
                this.Hide();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
