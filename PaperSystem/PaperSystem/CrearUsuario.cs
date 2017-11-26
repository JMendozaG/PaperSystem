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
    public partial class CrearUsuario : Form
    {
        string User = "";
        int Administrador = 0;
        Consultas con = new Consultas(); 

        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            RbEmpleado.Checked = true;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese Usuario");
            }
            else
            {
                con.Conexion.Open();
                SqlDataReader sqldr;
                string Usuario = TxtUsuario.Text;
                string Password = TxtContraseña.Text;

                string cadena = "SELECT USUARIO FROM usuarios WHERE USUARIO = '" + TxtUsuario.Text + "'";
                SqlCommand comando = new SqlCommand(cadena, con.Conexion);
                sqldr = comando.ExecuteReader();
                while (sqldr.Read())
                {
                    User = sqldr["Usuario"].ToString();
                }

                con.Conexion.Close();
            }
                if (User == TxtUsuario.Text)
                {
                    MessageBox.Show("El Usuario Ya Existe");
                }

                else
                {
                    if (TxtUsuario.Text == "" || TxtContraseña.Text == "" || txtCContraseña.Text == "")
                    {
                        MessageBox.Show("Completar Los Datos");
                    }
                    else
                    {
                        if (TxtContraseña.Text != txtCContraseña.Text)
                        {
                            MessageBox.Show("La Contraseña No Coincide");
                            txtCContraseña.Text = "";
                            TxtContraseña.Text = "";
                        }
                        else
                        {

                        con.Conexion.Open();

                            string Usuario = TxtUsuario.Text;
                            string Password = TxtContraseña.Text;

                            string cadena = "insert into Usuarios(Usuario,Contraseña,administrador) values ('" + Usuario + "','" + Password + "','" + Administrador + "')";
                            SqlCommand comando = new SqlCommand(cadena, con.Conexion);
                            comando.ExecuteNonQuery();
                            MessageBox.Show("LOS DATOS SE GUARDARON CORRECTAMENTE....", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtUsuario.Text = "";
                            txtCContraseña.Clear();
                            TxtContraseña.Clear();


                        con.Conexion.Close();
                        }

                    }


                }
            }

        private void RbAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            Administrador = 1;
        }

        private void RbEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            Administrador = 0;
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
