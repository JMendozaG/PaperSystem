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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //validacion de Login
        public string User = "";
        public string Password = "";
        public int Administrador = 0;

        //public int Empleado = 0;
        string Cadena = ""; 
        //Borrar B = new Borrar();
        Consultas C = new Consultas(); 

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "" || TxtUsuario.Text == "")
            {
                MessageBox.Show("Datos Incompletos");
            }
            else
            {
                Validacion();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
        public void Validacion()
        {
            
            Cadena =  "SELECT USUARIO, CONTRASEÑA, ADMINISTRADOR FROM USUARIOS WHERE USUARIO = '" + TxtUsuario.Text + "'" + "AND CONTRASEÑA ='" + TxtContraseña.Text + "'";
            C.Login(Cadena);
            //Tomar los Valores Encontrados 
            Password = C.Pass;
            User = C.User;
            Administrador = C.Administrador;
            Login(); 
        }

        public void Login()
        {
            //Valida Campos vacios 
                if (TxtContraseña.Text == Password && TxtUsuario.Text == User)
                {

                //valida el tipo de usuario
                    if (Administrador == 1)
                    {

                    //Entra Al Sistema como tipo administrador
                        var frm2 = new Principal(User);
                        frm2.Show();
                        this.Hide();
                      //  B.UsuarioBitacoras(User);
                    }
                    else if (Administrador == 0)
                    {

                    //Entra al sistema como tipo estandar
                        var frm2 = new Principal(User);
                        frm2.Show();
                        this.Hide();
                      //  B.UsuarioBitacoras(User);
                    }

                }
                else
                {

                //Muestra error 
                    label2.Visible = true;
                }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
