using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab05
{
    public partial class ManPerson : Form
    {
        SqlConnection con;
        public ManPerson()
        {
            InitializeComponent();
        }

        private void ManPerson_Load(object sender, EventArgs e)
        {
            String str = "Server=DOUG-GM\\LOCAL;DataBase=School;Integrated Security=true";
            con = new SqlConnection(str);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from Person";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvListado.DataSource = dt;
            dgvListado.Refresh();
            con.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            con.Open();
            string sp = "InsertPerson";
            SqlCommand cmd = new SqlCommand(sp,con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FirstName",txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Value);
            cmd.Parameters.AddWithValue("@EnrollmentDate", txtEnrollmentDate.Value);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("Se ha registrado nueva persona con el codigo" + codigo);
            
            con.Close();
            btnListar.PerformClick();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            con.Open();
            string sp = "UpdatePerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Value);
            cmd.Parameters.AddWithValue("@EnrollmentDate", txtEnrollmentDate.Value);

            int resultado = cmd.ExecuteNonQuery();
            if (resultado > 0) {
                MessageBox.Show("Se ha modificado el registro correctamente");
            }
            
            con.Close();

            btnListar.PerformClick();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            string sp = "DeletePerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);
            try 
            {
                int resultado = cmd.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Se ha eliminado el registro correctamente");
                }
            }
            catch (SqlException ex) 
            {
                MessageBox.Show("Error al eliminar : \n" + ex.Errors[0].Number + "\n" + ex.Errors[0].ToString());
            }
            
            con.Close();
            btnListar.PerformClick();
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0) 
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                txtHireDate.Text = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                txtEnrollmentDate.Text = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtHireDate.Value = DateTime.Now;
            txtEnrollmentDate.Value = DateTime.Now;
            txtPersonID.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string sp = "BuscarPersonaCodigo";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PersonID", txtBuscarCodigo.Text);
                                 
            con.Close();
            btnListar.PerformClick();
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {

            con.Open();
            string sp = "BuscarPersonaBombre";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FirstName", txtBuscarNombre.Text);

            con.Close();
            btnListar.PerformClick();
        }

        private void btnBuscarApellido_Click(object sender, EventArgs e)
        {

            con.Open();
            string sp = "BuscarPersonaApe";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@LastName", txtBuscarApe.Text);

            con.Close();
            btnListar.PerformClick();
        }
    }
}
