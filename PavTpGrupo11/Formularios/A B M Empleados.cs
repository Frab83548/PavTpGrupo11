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
using PavTpGrupo11.Entidades;

namespace PavTpGrupo11.Formularios
{
    public partial class frmABM_EMPLEADOS : Form
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);
        ConexionSQL cn = new ConexionSQL();

        public frmABM_EMPLEADOS()
        {
            InitializeComponent();
        }

        private void frmABM_EMPLEADOS_Load(object sender, EventArgs e)
        {
            GrillaEmpleados.DataSource = cn.ConsultarUsuariosDG();
        }


       
        private void button1_Click(object sender, EventArgs e)
        {

            cn.InsertarUsuario(txtCodigoEMPLEADO.Text, txtNombre.Text, txttelefonoE.Text,txtDocumento.Text,txtCalle.Text,txtCalleNRO.Text,txtBarrio.Text);
            GrillaEmpleados.DataSource =  cn.ConsultarUsuariosDG();
           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cn.EliminarEmpleado(txtCodigoEMPLEADO.Text);
            GrillaEmpleados.DataSource = cn.ConsultarUsuariosDG();

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            cn.ModificarEmpleado(txtCodigoEMPLEADO.Text, txtNombre.Text, txttelefonoE.Text, txtDocumento.Text, txtCalle.Text, txtCalleNRO.Text, txtBarrio.Text);
            GrillaEmpleados.DataSource = cn.ConsultarUsuariosDG();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
        }
    