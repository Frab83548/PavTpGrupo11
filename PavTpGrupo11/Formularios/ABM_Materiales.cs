using Microsoft.Win32;
using PavTpGrupo11.AccesoADatos;
using PavTpGrupo11.Entidades;
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
    public partial class ABM_Materiales : Form
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);
        ConexionSQL cn = new ConexionSQL();
        public ABM_Materiales()
        {
            InitializeComponent();
        }

        private void ABM_Materiales_Load(object sender, EventArgs e)
        {
            grillaMateriales.DataSource = cn.ConsultarMateriales();
            this.cargarCombos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool tieneCodigo = false, tieneCantidad = false, tieneCodMedida = false, tieneCodProv = false, tienePrecio = false;
            string cod="", cant="", precio = "";
            int codMedida = -1, codProv = -1;
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debe completar el campo codigo para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
            else
            {
                tieneCodigo=true;
                cod=txtCodigo.Text;
            }
            if (txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("Debe completar el campo cantidad para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
            }
            else
            {
                tieneCantidad=true;
                cant=txtCantidad.Text;
            }
            if(cmbCodUnidadMedida.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un codigo de unidad de medida para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCodUnidadMedida.Focus();
            }
            else
            {
                tieneCodMedida=true;
                codMedida = (int)cmbCodUnidadMedida.SelectedValue;
            }
            if(cmbCodProvedor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleecionar un codigo de proveedor para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCodProvedor.Focus();
            }
            else
            {
                tieneCodProv = true;
                codProv=(int)cmbCodProvedor.SelectedValue;
            }
            if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Debe completar el campo precio para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
            }
            else
            {
                tienePrecio = true;
                precio = txtPrecio.Text;
            }
            
            
            if(tieneCodigo && tieneCantidad && tieneCodMedida && tieneCodProv && tienePrecio)
            {
                if (!EstaEnGrilla(int.Parse(cod)))
                {
                    Material mate = new Material(int.Parse(cod), int.Parse(cant), codMedida, codProv, DateTime.Now, float.Parse(precio));
                    try
                    {
                        bool resultado = cn.InsertarMAterial(mate);
                        if (resultado)
                        {
                            MessageBox.Show("El material se agrego correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.LimpiarCampos();
                            grillaMateriales.DataSource = cn.ConsultarMateriales();
                            txtCodigo.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al agregar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrio un error al agregar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El Material con el codigo ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Focus();
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool tieneCodigo = false, tieneCantidad = false, tieneCodMedida = false, tieneCodProv = false, tienePrecio = false;
            string cod = "", cant = "", precio = "";
            int codMedida = -1, codProv = -1;
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debe completar el campo codigo para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
            else
            {
                tieneCodigo = true;
                cod = txtCodigo.Text;
            }
            if (txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("Debe completar el campo cantidad para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
            }
            else
            {
                tieneCantidad = true;
                cant = txtCantidad.Text;
            }
            if (cmbCodUnidadMedida.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un codigo de unidad de medida para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCodUnidadMedida.Focus();
            }
            else
            {
                tieneCodMedida = true;
                codMedida = (int)cmbCodUnidadMedida.SelectedValue;
            }
            if (cmbCodProvedor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleecionar un codigo de proveedor para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCodProvedor.Focus();
            }
            else
            {
                tieneCodProv = true;
                codProv = (int)cmbCodProvedor.SelectedValue;
            }
            if (txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("Debe completar el campo precio para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
            }
            else
            {
                tienePrecio = true;
                precio = txtPrecio.Text;
            }
            if (tieneCodigo && tieneCantidad && tieneCodMedida && tieneCodProv && tienePrecio)
            {
                if (EstaEnGrilla(int.Parse(cod)))
                {
                    Material mate = new Material(int.Parse(cod), int.Parse(cant), codMedida, codProv, DateTime.Now, float.Parse(precio));
                    try
                    {
                        bool resultado = cn.ModificarMAterial(mate);
                        if (resultado)
                        {
                            MessageBox.Show("El material se modifico correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.LimpiarCampos();
                            grillaMateriales.DataSource = cn.ConsultarMateriales();
                            txtCodigo.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al modificar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrio un error al modificar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("El Material que desea modificar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigo.Focus();
                }
            }




        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool tieneCodigo = false;
            string cod = "";
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debe completar el campo codigo para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
            else
            {
                tieneCodigo = true;
                cod = txtCodigo.Text;
            }
            if (tieneCodigo && EstaEnGrilla(int.Parse(cod)))
            {
                try
                {
                    bool resultado = cn.EliminarMaterial(int.Parse(cod));
                    if (resultado)
                    {
                        MessageBox.Show("El material se elimino correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.LimpiarCampos();
                        grillaMateriales.DataSource = cn.ConsultarMateriales();
                        txtCodigo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al eliminar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error al eliminar el material", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("El Material que desea eliminar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }
        private void cargarCombos()
        {
            cmbCodProvedor.DataSource = cn.ConsultarProvMateriales();
            cmbCodProvedor.DisplayMember = "Nombre";
            cmbCodProvedor.ValueMember = "Cod_Proveedor";
            cmbCodProvedor.SelectedIndex = -1;

            cmbCodUnidadMedida.DataSource = cn.ConsultarMedidaMateriales();
            cmbCodUnidadMedida.DisplayMember = "nombre";
            cmbCodUnidadMedida.ValueMember = "Cod_unidad_medida";
            cmbCodUnidadMedida.SelectedIndex = -1;
        }
        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            cmbCodUnidadMedida.SelectedIndex = -1;
            cmbCodProvedor.SelectedIndex = -1;
            txtPrecio.Text = "";
        }
        private bool EstaEnGrilla(int codigo)
        {
            bool resultado=false;
            for (int i = 0; i < grillaMateriales.Rows.Count; i++)
            {
                if (grillaMateriales.Rows[i].Cells["Codigo_Material"].Value.Equals(codigo.ToString()))
                {
                    resultado=true;
                    break;
                }
            }
            return resultado;
        }

        private void grillaMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grillaMateriales.Rows[indice];

            string codigo = filaSeleccionada.Cells["Codigo_Material"].Value.ToString();
            Material mate = cn.ObtenerMAterial(int.Parse(codigo));
            this.LimpiarCampos();
            this.CargarCampos(mate);
        }
        private void CargarCampos(Material mate)
        {
            txtCodigo.Text = mate.codigo_material.ToString();
            txtCantidad.Text = mate.cantidad.ToString();
            cmbCodProvedor.SelectedValue = mate.cod_proveedor;
            cmbCodUnidadMedida.SelectedValue = mate.cod_unidad_medida;
            txtPrecio.Text = mate.precio.ToString();

        }
    }
}
