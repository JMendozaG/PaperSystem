using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PaperSystem
{
    class Consultas
    {
        // Cadena De Conexion 
        public SqlConnection Conexion = new SqlConnection("Server=tcp:scorpion-ith.database.windows.net,1433;Initial Catalog=PaperSystem;Persist Security Info=False;User ID=JRivera;Password=PaperSystem123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        //Validacion de login 
       public string User = "", Pass = "";
       public int Administrador = 0; 

        public void Login(string Cadena)
        {
            Conexion.Open();
            SqlDataReader Sqldr;
            SqlCommand Cmd = new SqlCommand(Cadena, Conexion);
            Sqldr = Cmd.ExecuteReader();
            while (Sqldr.Read())
            {
                User = Sqldr["usuario"].ToString();
                Pass = Sqldr["contraseña"].ToString();
                Administrador =  Convert.ToInt32( Sqldr["administrador"]);
                
            }
            Conexion.Close();
        }

        public void ConsultasBD(string Cadena, string Tabla, DataGridView Resultados)
        {
            Conexion.Open();
            SqlDataReader Sqldr;
            SqlCommand Cmd = new SqlCommand(Cadena, Conexion);
            Sqldr = Cmd.ExecuteReader();
            while (Sqldr.Read())
            {
                if (Tabla == "Maestros")
                {
                    Resultados.Rows.Add(Sqldr["NumMaestro"], Sqldr["NomMaestro"], Sqldr["AreaMaestro"]);
                }
                else if (Tabla == "Copias")
                {
                    Resultados.Rows.Add(Sqldr["Folio"], Sqldr["NumMaestro"], Sqldr["NomMaestro"], Sqldr["NumCopias"], Sqldr["TipoMaterial"], Sqldr["Fecha"]);
                } else if (Tabla == "Papeleria")
                {
                    Resultados.Rows.Add(Sqldr["NumProducto"], Sqldr["NombreProducto"], Sqldr["Cantidad"], Sqldr["FechaLlegada"]);
                } 

            }
            Conexion.Close();
        }

    }
}
