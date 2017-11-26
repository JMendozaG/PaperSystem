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
    public partial class ConsultarProductos : Form
    {
        public ConsultarProductos()
        {
            InitializeComponent();
        }

        string Cadena = "";
        Consultas C = new Consultas();
        Validaciones V = new Validaciones();

        private void ConsultarProductos_Load(object sender, EventArgs e)
        {

            Cadena = "SELECT * FROM Papeleria";
            C.ConsultasBD(Cadena, "Papeleria", dgvConsultarP);
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvConsultarP.Rows.Clear();
                Cadena = "SELECT * FROM Papeleria WHERE NumProducto = '" + txt_buscar.Text + "'";
                C.ConsultasBD(Cadena, "Papeleria", dgvConsultarP);
            }
            catch
            {
                MessageBox.Show("Ese numero no existe");
            } 
        }
        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            V.PermitirNumeros(sender, e);
        }

        private void dgvConsultarP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cambiar Este Metodo
            if (this.dgvConsultarP.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                string Borrar1 = "";
                Borrar Borrar = new Borrar();
                Borrar1 = dgvConsultarP.CurrentRow.Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Seguro que desea Borrar este Producto?", "Salir", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    Borrar.BorrarProducto(Borrar1);
                    MessageBox.Show("Producto Borrado Correctamente");
                }
                else
                {
                    result = DialogResult.Cancel;
                }
                dgvConsultarP.Rows.Clear();
                ConsultarProductos_Load(sender, e);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
