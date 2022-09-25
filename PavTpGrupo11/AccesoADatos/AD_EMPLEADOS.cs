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
          

        public DataTable ConsultarBarriosDG()
        {
            return cn.ConsultarBarriosDG();
        }

        public int InsertarBarrio(string id, string nom)
        {
            return cn.InsertarBarrio(id, nom);
        }
    }
}
