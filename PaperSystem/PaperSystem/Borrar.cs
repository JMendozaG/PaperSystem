using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperSystem
{
    
    class Borrar
    {
        Consultas con = new Consultas();
        
        string Cadena = "";

        public void BorrarEmpleado(string Borrar)
        {
            Cadena = "DELETE FROM usuarios WHERE usuario = @Usuario";
            SqlCommand com = new SqlCommand(Cadena, con.Conexion);
            con.Conexion.Open();
            com.Parameters.AddWithValue("@Usuario", Borrar);
            com.ExecuteNonQuery();
            con.Conexion.Close();

        }
        public void BorrarProducto(string Borrar)
        {
            Cadena = "DELETE FROM Papeleria WHERE NumProducto = @NumP";
            SqlCommand com = new SqlCommand(Cadena, con.Conexion);
            con.Conexion.Open();
            com.Parameters.AddWithValue("@NumP", Borrar);
            com.ExecuteNonQuery();
            con.Conexion.Close();

        }
        public void UsuarioBitacoras(string Usuario)
        {
            SqlCommand com = new SqlCommand("SP_USUARIO", con.Conexion);
            com.CommandType = System.Data.CommandType.StoredProcedure;


            con.Conexion.Open();

            com.Parameters.AddWithValue("@USUARIO", Usuario);


            com.ExecuteNonQuery();
            con.Conexion.Close();
        }
    }

}
