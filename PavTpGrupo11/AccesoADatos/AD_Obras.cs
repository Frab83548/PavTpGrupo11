using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.AccesoADatos
{
    public class AD_Obras
    {
        ConexionSQL cn = new ConexionSQL();
        public DataTable ConsultarObrasDG()
        {
            return cn.ConsultarObrasDG();
        }

        public int InsertarObra(string cod, string nomObra, string calle, string nro, string barrio)
        {
            return cn.InsertarObra(cod, nomObra, calle, nro, barrio);
        }
        public int ModificarObra(string cod, string nomObra, string calle, string nro, string barrio)
        {
            return cn.InsertarObra(cod, nomObra, calle, nro, barrio);
        }

    }
}
