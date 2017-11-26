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
    public partial class RegistrarCopiaEimpresionescs : Form
    {
        int Folio = 0;
        int Folio1 = 0;
        string fecha = "";

        Consultas con = new Consultas();
        Validaciones V = new Validaciones();

        public RegistrarCopiaEimpresionescs()
        {
            InitializeComponent();
        }

        private void RegistrarCopiaEimpresionescs_Load(object sender, EventArgs e)
        {
            cmb_tipo.Text = "Examenes";
            folio();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {   
            if (txt_nommaestro.Text == "")
            {
                MessageBox.Show("Ese Maestro No existe, favor de registrarlo", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txt_cantidad.Text == "" || txt_Empleado.Text == "")
                {
                    MessageBox.Show("Completa datos....", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    con.Conexion.Open();

                    string Empleado = txt_Empleado.Text;
                    int Cantidad = Convert.ToInt32(txt_cantidad.Text);
                    string Tipo = cmb_tipo.Text;
                    int fol = Convert.ToInt32(txtfolio.Text);
                    DateTime Hoy = new DateTime();
                    Hoy = DateTime.Today;
                    fecha = Convert.ToString(Hoy.Day + "/" + Hoy.Month + "/" + Hoy.Year);

                    string cadena = "insert into Copias(folio, NumCopias,NumMaestro,TipoMaterial, Fecha) values ('" + fol + "','" + Cantidad + "','" + Empleado + "','" + Tipo + "','"+ fecha +"')";
                    SqlCommand comando = new SqlCommand(cadena, con.Conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE....", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cantidad.Clear();
                    txt_Empleado.Clear();
                    txt_nommaestro.Clear();
                    cmb_tipo.Text = "Examenes";
                    folio();


                    con.Conexion.Close();
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void folio()
        {

            con.Conexion.Open();
            SqlDataReader sqldr;

            string cadena = "SELECT  Folio FROM Copias";
            SqlCommand comando = new SqlCommand(cadena, con.Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                Folio = Convert.ToInt32(sqldr["Folio"]);
                if (Folio >= Folio1)
                {
                    Folio1 = Folio;
                }

            }
            txtfolio.Text = (Folio1 + 1).ToString();
            con.Conexion.Close();
        }

        private void txt_Empleado_TextChanged(object sender, EventArgs e)
        {
             txt_nommaestro.Clear();

            con.Conexion.Open();
            SqlDataReader sqldr;
            string cadena = "SELECT NomMaestro from Maestro where NumMaestro = '" + txt_Empleado.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, con.Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                string Maestro = sqldr["NomMaestro"].ToString();
                txt_nommaestro.Text = Maestro;
            }
            con.Conexion.Close();
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }

        private void txt_Empleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }
    }
}
