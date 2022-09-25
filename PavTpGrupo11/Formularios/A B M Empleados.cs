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
            if (txtCodigoEMPLEADO.Text.Equals("") || txtBarrio.Text.Equals("") || txtCalle.Text.Equals("") || txtCalleNRO.Text.Equals("") || txttelefonoE.Text.Equals("") ||
                txtDocumento.Text.Equals("") || txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para dar el alta al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    int resultado = cn.InsertarUsuario(txtCodigoEMPLEADO.Text, txtNombre.Text, txttelefonoE.Text, txtDocumento.Text, txtCalle.Text, txtCalleNRO.Text, txtBarrio.Text);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha dado de alta el empleado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    throw;
                }


                GrillaEmpleados.DataSource = cn.ConsultarUsuariosDG();
            }
            
            GrillaEmpleados.DataSource = cn.ConsultarUsuariosDG();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCodigoEMPLEADO.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el codigo del empleado que desee elimanr", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    int resultado = cn.EliminarEmpleado(txtCodigoEMPLEADO.Text);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha eliminado el empleado seleccionado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ese empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    throw;
                }




            }
            GrillaEmpleados.DataSource = cn.ConsultarUsuariosDG();

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigoEMPLEADO.Text.Equals("") || txtBarrio.Text.Equals("") || txtCalle.Text.Equals("") || txtCalleNRO.Text.Equals("") || txttelefonoE.Text.Equals("") ||
                txtDocumento.Text.Equals("") || txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    int resultado = cn.ModificarEmpleado(txtCodigoEMPLEADO.Text, txtNombre.Text, txttelefonoE.Text, txtDocumento.Text, txtCalle.Text, txtCalleNRO.Text, txtBarrio.Text);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha modificado el empleado seleccionado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ese empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    throw;
                }


                GrillaEmpleados.DataSource = cn.ConsultarUsuariosDG();
            }
        }

            private void btnSalir_Click(object sender, EventArgs e)
            {
                this.Hide();
            }

            private void BtnLimpiarCampos_Click(object sender, EventArgs e)
            {
                txtNombre.Text = "";
                txtBarrio.Text = "";
                txtCalleNRO.Text = "";
                txtCodigoEMPLEADO.Text = "";
                txttelefonoE.Text = "";
                txtDocumento.Text = "";
                txtCalle.Text = "";
            }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

    