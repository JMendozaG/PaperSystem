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
    public partial class EntradaProducto : Form
    {
        Validaciones V = new Validaciones();
        Consultas con = new Consultas();

        public EntradaProducto()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "" || txtClaveP.Text == "" || txtNombreP.Text == "")
            {
                MessageBox.Show("Completa datos....", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                con.Conexion.Open();
                SqlDataReader sqldr;

                string cadena = "UPDATE Papeleria set cantidad = cantidad + '" + txtCantidad.Text + "'" + ", FechaLlegada = '" + dtpLlegada.Text + "'" + "where Papeleria.NumProducto = '" + txtClaveP.Text + "'";
                SqlCommand comando = new SqlCommand(cadena, con.Conexion);
                sqldr = comando.ExecuteReader();
                MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE....", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Clear();
                txtClaveP.Clear();
                txtNombreP.Clear();

                con.Conexion.Close();
            }
        }

        private void txtClaveP_TextChanged(object sender, EventArgs e)
        {
            txtNombreP.Clear();

            con.Conexion.Open();
            SqlDataReader sqldr;
            string cadena = "SELECT NombreProducto from Papeleria where NumProducto = '" + txtClaveP.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, con.Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                string Maestro = sqldr["NombreProducto"].ToString();
                txtNombreP.Text = Maestro;
            }
            con.Conexion.Close();
        }

        private void txtClaveP_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
