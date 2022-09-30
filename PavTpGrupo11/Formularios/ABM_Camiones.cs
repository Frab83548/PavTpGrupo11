using PavTpGrupo11.AccesoADatos;
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

namespace PavTpGrupo11.Formularios
{
    public partial class ABM_Camiones : Form
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);
        ConexionSQL cn = new ConexionSQL();
        public ABM_Camiones()
        {
            InitializeComponent();
        }

        private void ABM_Camiones_Load(object sender, EventArgs e)
        {
            grillaCamiones.DataSource = cn.ConsultarCamiones();
            this.cargarCombos();
        }
        private void cargarCombos()
        {
            cmbMarca.DataSource = cn.ConsultarMarcaCamiones();
            cmbMarca.DisplayMember = "nombre_marca_camion";
            cmbMarca.ValueMember = "id_marca_camion";
            cmbMarca.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool tienePatente = false,tieneMarca=false, tieneModelo=false,tieneCapacidad=false;
            string patente = "";
            int marca=-1,modelo=0,capacidad=0;
            if (txtPatente.Text.Equals(""))
            {
                MessageBox.Show("Debe completar el campo Patente para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
