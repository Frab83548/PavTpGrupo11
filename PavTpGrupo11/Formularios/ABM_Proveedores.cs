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
    public partial class ABM_Proveedores : Form
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);
        ConexionSQL cn = new ConexionSQL();
        public ABM_Proveedores()
        {
            InitializeComponent();
        }

        public void ABM_Proveedores_Load(object sender, EventArgs e)
        {
            grillaProveedores.DataSource = cn.ConsultarProveedoresDG();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_AgregarProv_Click(object sender, EventArgs e)
        {
            if (txt_CodProv.Text.Equals("") || txt_NombreProv.Text.Equals("") || txt_TelefonoProv.Text.Equals("") || txt_MailProv.Text.Equals("") || txt_CalleProv.Text.Equals("") || txt_NroDeCalleProv.Text.Equals("") || txt_IdBarrioProv.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para dar el alta del Proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                try
                {   
                    int resultado = cn.InsertarProveedor(txt_CodProv.Text, txt_NombreProv.Text, txt_TelefonoProv.Text, txt_MailProv.Text, txt_CalleProv.Text, txt_NroDeCalleProv.Text, txt_IdBarrioProv.Text);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha dado de alta el Proveedor con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    throw;
                }
            }

        }

        private void Btn_ModificarProv_Click(object sender, EventArgs e)
        {
            if (txt_CodProv.Text.Equals("") || txt_NombreProv.Text.Equals("") || txt_TelefonoProv.Text.Equals("") || txt_MailProv.Text.Equals("") || txt_CalleProv.Text.Equals("") || txt_NroDeCalleProv.Text.Equals("") || txt_IdBarrioProv.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para Modificar la Obra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    int resultado = cn.ModificarProveedor(txt_CodProv.Text, txt_NombreProv.Text, txt_TelefonoProv.Text, txt_MailProv.Text, txt_CalleProv.Text, txt_NroDeCalleProv.Text, txt_IdBarrioProv.Text);
                    if(resultado > 0)
                    {
                        MessageBox.Show("Se ha Modificado el Proveedor con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    throw;
                }
                grillaProveedores.DataSource = cn.ConsultarProveedoresDG();
            }
            grillaProveedores.DataSource = cn.ConsultarProveedoresDG();

        }

        private void btn_BorrarProv_Click(object sender, EventArgs e)
        {
            if (txt_CodProv.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el codigo del Proveedor que desee eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int resultado = cn.EliminarProveedor(txt_CodProv.Text);
                    if (resultado >0)
                    {
                        MessageBox.Show("Se ha eliminado el Proveedor seleccionado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("Ese Proveedor no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    throw;
                }
                grillaProveedores.DataSource = cn.ConsultarProveedoresDG();
            }
            grillaProveedores.DataSource = cn.ConsultarProveedoresDG();
        }

        private void Btn_LimpiarCamposProv_Click(object sender, EventArgs e)
        {
            txt_CodProv.Text = "";
            txt_CalleProv.Text = "";
            txt_IdBarrioProv.Text = "";
            txt_MailProv.Text = "";
            txt_NombreProv.Text = "";
            txt_TelefonoProv.Text = "";
            txt_NroDeCalleProv.Text = "";

        }
    }
}
