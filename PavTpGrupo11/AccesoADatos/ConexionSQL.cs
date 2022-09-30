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
            string query = "UPDATE Empleados SET Nombre = '" + nom + "', Telefono = '" + tel + "', Documento = '" + doc + "', calle =  '" + calle + "', nro_calle =  '" + nro + "', id_barrio = '" + barrio + "' WHERE Cod_Empleado = '" + cod + "'";

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

        public int ModificarBarrio( string dni, string nom)

        {
            int resultado = 0;
            try
            {
                conexion.Open();
                string query = "UPDATE Barrios SET nombre_barrio = '" + nom + "' where id_barrio = '" + dni + "'";

                SqlCommand cmd = new SqlCommand(query, conexion);
                resultado =cmd.ExecuteNonQuery();

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            
          


        }
        public int EliminarBarrio(string id)

        {
            int flag = 0;

            try
            {
                conexion.Open();
                string query = "DELETE FROM Barrios WHERE id_barrio = '" + id + "'";

                SqlCommand cmd = new SqlCommand(query, conexion);
                flag = cmd.ExecuteNonQuery();
                return flag;
                 
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conexion.Close();
            }
            
           


        }
        // proveedores david
        public DataTable ConsultarProveedoresDG()
        {
            string query = "SELECT * FROM Proveedor";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarProveedor(string cod, string nom, string tel, string mail, string calle, string nro, string barrio)

        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Proveedor(Cod_Proveedor, Nombre, Telefono, Mail, Calle, nro_Calle, id_barrio) values('" + cod + "', '" + nom + "', '" + tel + "', '" + mail + "', '" + calle + "', '" + nro + "', '" + barrio + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }

        public int ModificarProveedor(string cod, string nom, string tel, string mail, string calle, string nro, string barrio)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Proveedor SET Nombre = '" + nom + "', Telefono = '" + tel + "', Mail = '" + mail + "', Calle =  '" + calle + "', nro_calle =  '" + nro + "', id_barrio = '" + barrio + "' WHERE Cod_Proveedor = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int EliminarProveedor(string cod)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Proveedor WHERE Cod_Proveedor = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        // Obra david
        public DataTable ConsultarObrasDG()
        {
            string query = "SELECT * FROM Obras";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarObra(string cod, string nomObra, string calle, string nro, string barrio)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Obras(codigo_obra, nombre_Obra, calle, nro_Calle, id_barrio) values('" + cod + "','" + nomObra + "', '" + calle + "', '" + nro + "', '" + barrio + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }

        public int ModificarObra(string cod, string nomObra, string calle, string nro, string barrio)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Obras SET nombre_Obra = '" + nomObra + "', Calle =  '" + calle + "', nro_calle =  '" + nro + "', id_barrio = '" + barrio + "' WHERE codigo_Obra = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int EliminarObra(string cod)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Obras WHERE codigo_Obra = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }


        public DataTable ObtenerCamiones()
        {
            string query = "SELECT * FROM Camiones";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarCamion(string patente, string marca, string mod, string cap)

        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Camiones(Patente, Marca_Camión, Año_Modelo, Capacidad ) values('" + patente + "', '" + marca + "', '" + mod + "', '" + cap + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int eliminarCamion(string patente)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Camiones WHERE Patente = '" + patente + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int ModificarCamion(string patente, string marca, string mod, string cap)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Camiones SET Marca_Camión = '" + marca + "', Año_Modelo =  '" + mod + "', Capacidad =  '" + cap + "' WHERE Patente = '" + patente + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }


    }

}
