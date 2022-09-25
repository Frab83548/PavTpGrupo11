using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using PavTpGrupo11.Formularios;
namespace PavTpGrupo11.AccesoADatos

{
   public  class ConexionSQL
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);

        public DataTable ConsultarUsuariosDG()
        {
            string query = "SELECT * FROM Empleados";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }
        public DataTable ConsultarBarriosDG()
        {
            string query = "SELECT * FROM Barrios";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }
        public int InsertarUsuario(string cod, string nom, string tel, string doc, string calle, string nro, string barrio)

        {
                int flag = 0;
                conexion.Open();
                string query = "insert into Empleados(Cod_Empleado, Nombre, Telefono, Documento, calle, nro_Calle, id_barrio) values('" + cod + "', '" + nom + "', '" + tel + "', '" + doc + "', '" + calle + "', '" + nro + "', '" + barrio + "')";

                SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
                conexion.Close();
            return flag;
               
            
        }
        public int  EliminarEmpleado(string cod)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Empleados WHERE Cod_Empleado = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int ModificarEmpleado(string cod, string nom, string tel, string doc, string calle, string nro, string barrio)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Empleados SET Nombre = '" + nom + "' Telefono =  '" + tel + "' Documento = '" + doc + "' calle =  '" + calle + "' nro_calle =  '" + nro + "' id_barrio = '" + barrio + "' where Cod_Empleado = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }

        public bool InsertarBarrio(string id, string nom)

        {
            bool resultado = false;

            try
            {
                conexion.Open();
                string query = "insert into Barrios(id_barrio, nombre_barrio) values('" + id + "', '" + nom + "')";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                
                resultado= true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }

        public bool ModificarBarrio( string dni, string nom)

        {
            bool flag = false;
            try
            {
                conexion.Open();
                string query = "UPDATE Barrios SET nombre_barrio = '" + nom + "' where id_barrio = '" + dni + "'";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                
                flag = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            
            return flag;


        }
        public int EliminarBarrio(string id)

        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Barrios WHERE id_barrio = '" + id + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }


    }
}
