using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.AccesoADatos
{
    public class AD_Proveedores
    {
        ConexionSQL cn = new ConexionSQL();
        public DataTable consultarProveedores()
        {
            return cn.ConsultarProveedoresDG();
        }
        public int InsertarProveedor(string cod, string nom, string tel, string mail, string calle, string nro, string barrio)
        {
            return cn.InsertarProveedor(cod, nom, tel, mail, calle, nro, barrio);
        }

        public int EliminarProvedor(string cod)
        {
            return cn.EliminarProveedor(cod);
        }
    }

    



}
