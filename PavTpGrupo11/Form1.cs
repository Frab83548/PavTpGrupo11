using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PavTpGrupo11.Formularios;

namespace PavTpGrupo11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tipoDeRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedorerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registrarEmpleadoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABM_EMPLEADOS ventana = new frmABM_EMPLEADOS();
            ventana.Show();

        }

        private void registrarBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_BARRIOS ventana = new ABM_BARRIOS();
            ventana.Show();
        }

        private void aBMProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Proveedores ventana = new ABM_Proveedores();
            ventana.Show();
        }

        private void aBMObrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Obra ventana  = new ABM_Obra();
            ventana.Show();

        }
    }
}
