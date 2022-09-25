using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PavTpGrupo11.AccesoADatos;

namespace PavTpGrupo11.Formularios
{
    public partial class ABM_BARRIOS : Form
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);
        ConexionSQL cn = new ConexionSQL();
        public ABM_BARRIOS()
        {
            InitializeComponent();
        }

        private void ABM_BARRIOS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.InsertarBarrio(txtBarrio.Text, txtNombreBarrio.Text);
            grillaBarrios.DataSource = cn.ConsultarBarriosDG();
        }
    }
}
