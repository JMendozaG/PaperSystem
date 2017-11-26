using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperSystem
{
    public partial class EliminarUsuario : Form
    {
        Consultas con = new Consultas();
        public EliminarUsuario()
        {
            InitializeComponent();
        }
        string Borrar1 = "";
        Borrar Borrar = new Borrar();
        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                Borrar1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Seguro que desea Borrar este usuario?", "Salir", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    Borrar.BorrarEmpleado(Borrar1);
                    MessageBox.Show("Usuario Borrado Correctamente");
                }
                else
                {
                    result = DialogResult.Cancel;
                }           
                dataGridView1.Rows.Clear();
                Cargar();
            }
        }
        public void Cargar()
        {

            con.Conexion.Open();
            SqlDataReader sqldr;
            string cadena = "SELECT USUARIO, CONTRASEÑA, ADMINISTRADOR FROM USUARIOS ";
            SqlCommand comando = new SqlCommand(cadena, con.Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                string Adm = sqldr["ADMINISTRADOR"].ToString();

                if (Adm == Convert.ToString(1))
                {
                    dataGridView1.Rows.Add(sqldr["USUARIO"].ToString(), sqldr["CONTRASEÑA"].ToString(), "Si", "Eliminar");
                }
                else
                {
                    dataGridView1.Rows.Add(sqldr["USUARIO"].ToString(), sqldr["CONTRASEÑA"].ToString(), "No", "Eliminar");
                }
            }
            con.Conexion.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
