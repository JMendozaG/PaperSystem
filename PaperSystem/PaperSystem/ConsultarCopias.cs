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
    public partial class ConsultarCopias : Form
    {
        

        public ConsultarCopias()
        {
            InitializeComponent();
        }

        string Cadena = "";
        Validaciones V = new Validaciones();
        Consultas C = new Consultas();

        private void ConsultarCopias_Load(object sender, EventArgs e)
        {
             Cadena = "select Folio, maestro.NumMaestro, NomMaestro, NumCopias ,TipoMaterial, fecha from Copias inner join maestro on maestro.NumMaestro = Copias.NumMaestro";
             C.ConsultasBD(Cadena, "Copias", dgvBuscarcopias);
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dgvBuscarcopias.Rows.Clear();
            Cadena = "select*FROM VISTACOPIAS WHERE NumMaestro = '" + txt_buscar.Text + "'";
            C.ConsultasBD(Cadena, "Copias", dgvBuscarcopias);
            
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.PermitirNumeros(sender, e);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
