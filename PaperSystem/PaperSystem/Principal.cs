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
    public partial class Principal : Form
    {
        Consultas con = new Consultas();
        public string User = "";
        string password = "";
        int admin = 0;
        public int Empleado = 0;

        public Principal(string s)
        {
            InitializeComponent();
            lbl_usuario.Text = s;

            con.Conexion.Open();
            SqlDataReader sqldr;
            string cadena = "SELECT USUARIO, CONTRASEÑA, ADMINISTRADOR FROM USUARIOS WHERE USUARIO = '" + s + "'";
            SqlCommand comando = new SqlCommand(cadena, con.Conexion);
            sqldr = comando.ExecuteReader();
            while (sqldr.Read())
            {
                User = sqldr["Usuario"].ToString();
                password = sqldr["Contraseña"].ToString();
                admin = Convert.ToInt32(sqldr["Administrador"]);
                if (admin == 1)
                {
                    consultarCopiasRealizadasToolStripMenuItem.Visible = true;
                    usuarioToolStripMenuItem.Visible = true;
                }
            }

            con.Conexion.Close();
        }
        private void registrarCopiaRealizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCopiaEimpresionescs RC = new RegistrarCopiaEimpresionescs();
            RC.Show();
        }

        private void consultarCopiasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCopias CP = new ConsultarCopias();
            CP.Show();
        }

        private void consultarMaestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaMaestro CM = new ConsultaMaestro();
            CM.Show();
        }

        private void registrarMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearMaestro Ma = new CrearMaestro();
            Ma.Show();
        }

        private void consultarMaterialDisponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConsultarP = new ConsultarProductos();
            ConsultarP.Show();
        }

        private void registrarUnNuevoMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarProducto RP = new RegistrarProducto();
            RP.Show();
        }

        private void consultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuario EU = new EliminarUsuario();
            EU.Show();
        }

        private void crearUnNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearUsuario CNU = new CrearUsuario();
            CNU.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea cerrar sesion?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Form1 login = new Form1();
                login.Show();
            }
            else
            {
                result = DialogResult.Cancel;
            }
        }

        private void registrarEntradeDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntradaProducto EP = new EntradaProducto();
            EP.Show();
        }

        private void registrarSalidaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalidaProductos SP = new SalidaProductos();
            SP.Show();
        }
    }
}
