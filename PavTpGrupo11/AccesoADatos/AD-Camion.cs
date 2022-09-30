using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PavTpGrupo11.AccesoADatos
{
    public class AD_Camion
    {
        ConexionSQL cn = new ConexionSQL();

        public  DataTable ObtenerCamiones()
        {
            return cn.ObtenerCamiones();
        }


        public int InsertarCamion(string patente, string marca, string mod, string cap)
        {
            return cn.InsertarCamion(patente, marca, mod, cap);
        }

        public int eliminarCamion(string patente)
        {
            return cn.eliminarCamion(patente);
        }
        
        public int ModificarCamion(string patente, string marca, string mod, string cap)
        {
            return cn.ModificarCamion( patente, marca, mod, cap);
        }

    }
}
