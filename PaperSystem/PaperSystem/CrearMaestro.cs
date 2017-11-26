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
    public partial class CrearMaestro : Form
    {
        string Num = "";
        Consultas con = new Consultas();
        Validaciones V = new Validaciones();
        public CrearMaestro()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "" || txt_Empleado.Text == "" || txt_area.Text == "")
            {
                MessageBox.Show("Completa datos....", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Seleccion();
                if (Num == txt_Empleado.Text)
                {
                    MessageBox.Show("Ese numero de maestro ya existe, por favor consulte a los maestros..");
                }

                else
                {

                    con.Conexion.Open();

                    int Empleado = Convert.ToInt32(txt_Empleado.Text);
                    string NombreMaestro = txt_nombre.Text;
                    string Area = txt_area.Text;

                    string cadena = "insert into maestro(NumMaestro, NomMaestro, AreaMaestro) values ('" + Empleado + "','" + NombreMaestro + "','" + Area + "')";
                    SqlCommand comando = new SqlCommand(cadena, con.Conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE....", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_area.Clear();
                    txt_Empleado.Clear();
                    txt_nombre.Clear();
                    txt_Empleado.Focus();


                    con.Conexion.Close();
                }
            }
        }
        public void Seleccion()
        {
            SqlConnection conexion = new SqlConnection("server=localhost;Initial Catalog = PaperSystem; integrated security = true");
            conexion.Open();
            SqlDataReader sqldr;
            string cadena = "SELECT NumMaestro FROM Maestro WHERE NumMaestro = '" + txt_Empleado.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                Num = sqldr["NumMaestro"].ToString();
            }

            conexion.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirLetras(sender, e);
        }

        private void txt_area_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirLetras(sender, e);
        }
    }
}
