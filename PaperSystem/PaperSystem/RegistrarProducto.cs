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
    public partial class RegistrarProducto : Form
    {
        public RegistrarProducto()
        {
            InitializeComponent();
        }
        string NUMP = "";
        Validaciones V = new Validaciones();
        Consultas con = new Consultas();

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Validacion();
            if (txtnumproducto.Text == NUMP)
            {
                MessageBox.Show("Ese producto ya existe", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (txtnumproducto.Text == "" || txtnomproducto.Text == "" || txtcantidadproducto.Text == "")
                {
                    MessageBox.Show("Completa datos....", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    con.Conexion.Open();

                    string Producto = txtnomproducto.Text;
                    int Cantidad = Convert.ToInt32(txtcantidadproducto.Text);
                    string NumProducto = txtnumproducto.Text;
                    string fechallegada = dtpllegada.Text;


                    string cadena = "insert into Papeleria(NumProducto, NombreProducto,Cantidad,fechallegada) values ('" + NumProducto + "','" + Producto + "','" + Cantidad + "','" + fechallegada + "')";
                    SqlCommand comando = new SqlCommand(cadena, con.Conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE....", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcantidadproducto.Clear();
                    txtnomproducto.Clear();
                    txtnumproducto.Clear();


                    con.Conexion.Close();
                }
            }
        }

        private void txtnumproducto_KeyPress(object sender, KeyPressEventArgs e)
        {  
            V.PermitirNumeros(sender, e) ;
        }
        private void txtcantidadproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Validacion()
        {
            con.Conexion.Open();
            SqlDataReader sqldr;

            string cadena = "SELECT NumProducto FROM Papeleria WHERE NumProducto = '" + txtnumproducto.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, con.Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                NUMP = sqldr["NumProducto"].ToString();
            }
            con.Conexion.Close();
        }
    }
}
