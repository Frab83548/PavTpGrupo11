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
    public partial class ABM_Obra : Form
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);
        ConexionSQL cn = new ConexionSQL();
        public ABM_Obra()
        {
            InitializeComponent();
        }
        private void ABM_Obra_Load(object sender, EventArgs e)
        {
            grillaObra.DataSource = cn.ConsultarObrasDG();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //

        //
        private void btn_AgregarObra_Click(object sender, EventArgs e)
        {
            if (txt_CodObra.Text.Equals("") || txt_NombreObra.Text.Equals("") || txt_CalleObra.Text.Equals("") || txt_NroDeCalleObra.Text.Equals("") || txt_IdBarrioObra.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para dar el alta a la Obra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int resultado = cn.InsertarObra(txt_CodObra.Text, txt_NombreObra.Text, txt_CalleObra.Text, txt_NroDeCalleObra.Text, txt_IdBarrioObra.Text);
                    if(resultado > 0)
                    {
                        MessageBox.Show("Se ha dado de alta la Obra con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch(Exception)
                {
                    throw;
                }
                grillaObra.DataSource = cn.ConsultarObrasDG();
            }
            grillaObra.DataSource = cn.ConsultarObrasDG();

        }

       

        private void Btn_ModificarObra_Click(object sender, EventArgs e)
        {
            if(txt_CodObra.Text.Equals("") || txt_NombreObra.Text.Equals("") || txt_CalleObra.Text.Equals("") || txt_NroDeCalleObra.Text.Equals("") || txt_IdBarrioObra.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos correspondientes para Modificar la Obra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    int resultado = cn.ModificarObra(txt_CodObra.Text, txt_NombreObra.Text, txt_CalleObra.Text, txt_NroDeCalleObra.Text, txt_IdBarrioObra.Text);
                    if(resultado > 0)
                    {
                        MessageBox.Show("Se ha Modificado la Obra con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                grillaObra.DataSource = cn.ConsultarObrasDG();
            }
            grillaObra.DataSource = cn.ConsultarObrasDG();

        }

        private void btn_BorrarObra_Click(object sender, EventArgs e)
        {
            if (txt_CodObra.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar el codigo de la Obra que desee eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int resultado = cn.EliminarObra(txt_CodObra.Text);
                    if(resultado > 0)
                    {
                        MessageBox.Show("Se ha eliminado la Obra seleccionada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        MessageBox.Show("Esa Obra no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch
                {
                    throw;
                }
                grillaObra.DataSource = cn.ConsultarObrasDG();
            }
            grillaObra.DataSource = cn.ConsultarObrasDG();
        }

        private void Btn_LimpiarCamposObra_Click(object sender, EventArgs e)
        {
            txt_CodObra.Text = "";
            txt_CalleObra.Text = "";
            txt_IdBarrioObra.Text = "";
            txt_NombreObra.Text = "";
            txt_NroDeCalleObra.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
