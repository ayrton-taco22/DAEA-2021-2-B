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

namespace Lab04
{
    public partial class Curso : Form
    {
        SqlConnection conn;
        public Curso(SqlConnection connDB)
        {
            this.conn = connDB;
            InitializeComponent();
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            MessageBox.Show(conn.State.ToString());
        }

        private void btnListarCurso_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sql = "select * from Course";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListadoCurso.DataSource = dt;
                dgvListadoCurso.Refresh();
            }
            else
            {
                MessageBox.Show("La conexion esta cerrada");
            }
        }

        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String Title = txtNombreCurso.Text;


                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BuscarCursoNombre";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //crear parametros
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Title";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = Title;

                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListadoCurso.DataSource = dt;
                dgvListadoCurso.Refresh();

            }
            else
            {
                MessageBox.Show("La conexion esta cerrada");
            }
        }
    }
}
