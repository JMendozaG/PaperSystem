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
    public partial class ConsultaMaestro : Form
    {
        public ConsultaMaestro()
        {
            InitializeComponent();
        }

        string Cadena = ""; 
        Consultas C = new Consultas();
        Validaciones V = new Validaciones();

        private void ConsultaMaestro_Load(object sender, EventArgs e)
        {
            
            Cadena = "SELECT * FROM Maestro";
            C.ConsultasBD(Cadena, "Maestros", dgvBuscarMaestro);
        }

        private void txt_buscarmaestro_TextChanged(object sender, EventArgs e)
        {
            if (txt_buscarmaestro.Text == "")
            {
                dgvBuscarMaestro.Rows.Clear();
                ConsultaMaestro_Load(sender, e);
            }
            else
            {
                dgvBuscarMaestro.Rows.Clear();

                Cadena =  "SELECT * FROM Maestro WHERE NumMaestro = '" + txt_buscarmaestro.Text + "'";
                C.ConsultasBD(Cadena, "Maestros", dgvBuscarMaestro);            
            }
        }

        private void txt_buscarmaestro_KeyPress(object sender, KeyPressEventArgs e)
        {     
            V.PermitirNumeros(sender, e);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
