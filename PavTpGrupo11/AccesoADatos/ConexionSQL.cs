using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using PavTpGrupo11.Formularios;
using PavTpGrupo11.Entidades;

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
        public DataTable ConsultarMateriales()
        {
            string query = "SELECT * FROM Materiales";
            SqlCommand cmd = new SqlCommand(query,conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd); 
            DataTable table = new DataTable();
            data.Fill(table);

            return table;
        }
        public DataTable ConsultarProvMateriales()
        {
            string query = "SELECT * FROM Proveedor";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }
        public DataTable ConsultarMedidaMateriales()
        {
            string query = "SELECT * FROM UNIDADESxDExMEDIDA";
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
        public bool InsertarMAterial(Material mate)
        {
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Materiales(Codigo_Material,Cantidad,Cod_Unidad_Medida,Cod_Proveedor,Fecha_Ingreso,Precio) VALUES(@cod,@cant,@codUni,@codProv,@Date,@precio)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", mate.codigo_material);
                cmd.Parameters.AddWithValue("@cant", mate.cantidad);
                cmd.Parameters.AddWithValue("@codUni", mate.cod_unidad_medida);
                cmd.Parameters.AddWithValue("@codProv", mate.cod_proveedor);
                cmd.Parameters.AddWithValue("@Date", mate.fecha_ingreso);
                cmd.Parameters.AddWithValue("@precio", mate.precio);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return resultado;
        }

        public bool ModificarMAterial(Material mate)
        {
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE MAteriales SET Cantidad = @cant, Cod_Unidad_Medida=@codUni, Cod_Proveedor=@codProv, precio=@precio WHERE Codigo_Material like @cod";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", mate.codigo_material);
                cmd.Parameters.AddWithValue("@cant", mate.cantidad);
                cmd.Parameters.AddWithValue("@codUni", mate.cod_unidad_medida);
                cmd.Parameters.AddWithValue("@codProv", mate.cod_proveedor);
                cmd.Parameters.AddWithValue("@precio", mate.precio);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                
                conexion.Open();
                cmd.Connection = conexion;
                cmd.ExecuteNonQuery();
                resultado = true;
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
        public bool EliminarMaterial(int cod)
        {
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Materiales WHERE Codigo_Material like @cod";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;
                cmd.ExecuteNonQuery();
                resultado = true;
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
        public Material ObtenerMAterial(int cod)
        {
            Material mate = new Material();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Materiales WHERE Codigo_Material like @cod";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", cod);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;
                SqlDataReader dr = cmd.ExecuteReader();

                if(dr != null && dr.Read())
                {
                    mate.codigo_material = int.Parse(dr["Codigo_Material"].ToString());
                    mate.cantidad = int.Parse(dr["Cantidad"].ToString());
                    mate.cod_unidad_medida = int.Parse(dr["Cod_Unidad_Medida"].ToString());
                    mate.cod_proveedor = int.Parse(dr["Cod_Proveedor"].ToString());
                    mate.fecha_ingreso = DateTime.Parse(dr["Fecha_Ingreso"].ToString());
                    mate.precio = float.Parse(dr["precio"].ToString());
                    
                }
   


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            return mate;
        }


    }
}
