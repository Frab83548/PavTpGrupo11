using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PavTpGrupo11.AccesoADatos;

namespace PavTpGrupo11.Formularios
{
    public partial class ABM_Camiones : Form
    {
        AD_Camion camion = new AD_Camion();
        public ABM_Camiones()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ABM_Camiones_Load(object sender, EventArgs e)
        {
            GrillaCamiones.DataSource = camion.ObtenerCamiones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtPatente.Text.Equals("") || TxtMarca.Text.Equals("") || txtAño.Text.Equals("") || txtCapacidad.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para dar el alta a la Obra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int resultado = camion.InsertarCamion(txtPatente.Text, TxtMarca.Text, txtAño.Text, txtCapacidad.Text);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha dado de alta el camion", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Ese camion ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                GrillaCamiones.DataSource = camion.ObtenerCamiones();
            }
            GrillaCamiones.DataSource = camion.ObtenerCamiones();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtPatente.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el codigo de la Obra que desee eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int resultado = camion.eliminarCamion(txtPatente.Text);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha eliminado el camion seleccionado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("Ese camion no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch
                {
                    MessageBox.Show("Ese camion no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GrillaCamiones.DataSource = camion.ObtenerCamiones();
            }
            GrillaCamiones.DataSource = camion.ObtenerCamiones();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtPatente.Text.Equals("") || TxtMarca.Text.Equals("") || txtAño.Text.Equals("") || txtCapacidad.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para Modificar la Obra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    int resultado = camion.ModificarCamion(txtPatente.Text, TxtMarca.Text, txtAño.Text, txtCapacidad.Text);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha Modificado el camion con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                GrillaCamiones.DataSource = camion.ObtenerCamiones();
            }
            GrillaCamiones.DataSource = camion.ObtenerCamiones();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtPatente.Text = "";
            TxtMarca.Text = "";
            txtAño.Text = "";
            txtCapacidad.Text = "";

        }
    }
}
