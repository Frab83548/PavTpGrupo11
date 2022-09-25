using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace PavTpGrupo11.AccesoADatos
{
    public class AD_EMPLEADOS
    {
        ConexionSQL cn = new ConexionSQL();

        
        public DataTable ConsultarUsuariosDG()
        {
            return cn.ConsultarUsuariosDG();


        }

          public int InsertarEmpleado(string cod, string nom, string tel, string doc, string calle, string nro, string barrio)
        {
            return cn.InsertarUsuario(cod, nom,tel,doc,calle,nro,barrio);
        }
        public int EliminarEmpleado(string cod)
        {
            return cn.EliminarEmpleado(cod);
        }

        public int ModificarEmpleado(string cod, string nom, string tel, string doc, string calle, string nro, string barrio)
        {
            return cn.ModificarEmpleado(cod, nom, tel, doc, calle, nro, barrio);
        }



        public DataTable ConsultarBarriosDG()
        {
            return cn.ConsultarBarriosDG();
        }

        public bool InsertarBarrio(string id, string nom)
        {
            return cn.InsertarBarrio(id, nom);
        }

        public bool ModificarBarrio(string dni, string nom)
        {
            return cn.ModificarBarrio(dni, nom);
        }

        public int EliminarBarrio(string id)
        {
            return cn.EliminarBarrio(id);
        }
    }
}
