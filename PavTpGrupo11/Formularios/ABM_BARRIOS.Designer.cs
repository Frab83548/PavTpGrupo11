
namespace PavTpGrupo11.Formularios
{
    partial class ABM_BARRIOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnAgregarB = new System.Windows.Forms.Button();
            this.btnModificarBarrio = new System.Windows.Forms.Button();
            this.btnElimarB = new System.Windows.Forms.Button();
            this.TxtIDBarrio = new System.Windows.Forms.TextBox();
            this.txtNombreB = new System.Windows.Forms.TextBox();
            this.GrillaBarrio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBarrio)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PavTpGrupo11.Properties.Resources.barrio;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // BtnAgregarB
            // 
            this.BtnAgregarB.Location = new System.Drawing.Point(71, 325);
            this.BtnAgregarB.Name = "BtnAgregarB";
            this.BtnAgregarB.Size = new System.Drawing.Size(122, 31);
            this.BtnAgregarB.TabIndex = 1;
            this.BtnAgregarB.Text = "Agregar";
            this.BtnAgregarB.UseVisualStyleBackColor = true;
            this.BtnAgregarB.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnModificarBarrio
            // 
            this.btnModificarBarrio.Location = new System.Drawing.Point(238, 325);
            this.btnModificarBarrio.Name = "btnModificarBarrio";
            this.btnModificarBarrio.Size = new System.Drawing.Size(122, 31);
            this.btnModificarBarrio.TabIndex = 2;
            this.btnModificarBarrio.Text = "Modificar";
            this.btnModificarBarrio.UseVisualStyleBackColor = true;
            // 
            // btnElimarB
            // 
            this.btnElimarB.Location = new System.Drawing.Point(386, 312);
            this.btnElimarB.Name = "btnElimarB";
            this.btnElimarB.Size = new System.Drawing.Size(122, 31);
            this.btnElimarB.TabIndex = 3;
            this.btnElimarB.Text = "Eliminar";
            this.btnElimarB.UseVisualStyleBackColor = true;
            // 
            // TxtIDBarrio
            // 
            this.TxtIDBarrio.Location = new System.Drawing.Point(344, 74);
            this.TxtIDBarrio.Name = "TxtIDBarrio";
            this.TxtIDBarrio.Size = new System.Drawing.Size(164, 20);
            this.TxtIDBarrio.TabIndex = 4;
            // 
            // txtNombreB
            // 
            this.txtNombreB.Location = new System.Drawing.Point(344, 117);
            this.txtNombreB.Name = "txtNombreB";
            this.txtNombreB.Size = new System.Drawing.Size(164, 20);
            this.txtNombreB.TabIndex = 5;
            // 
            // GrillaBarrio
            // 
            this.GrillaBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaBarrio.Location = new System.Drawing.Point(78, 181);
            this.GrillaBarrio.Name = "GrillaBarrio";
            this.GrillaBarrio.Size = new System.Drawing.Size(282, 113);
            this.GrillaBarrio.TabIndex = 6;
            // 
            // ABM_BARRIOS
            // 
            this.ClientSize = new System.Drawing.Size(704, 406);
            this.Controls.Add(this.GrillaBarrio);
            this.Controls.Add(this.txtNombreB);
            this.Controls.Add(this.TxtIDBarrio);
            this.Controls.Add(this.btnElimarB);
            this.Controls.Add(this.btnModificarBarrio);
            this.Controls.Add(this.BtnAgregarB);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ABM_BARRIOS";
            this.Load += new System.EventHandler(this.ABM_BARRIOS_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBarrio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.MaskedTextBox txtNombreBarrio;
        private System.Windows.Forms.DataGridView grillaBarrios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarB;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnAgregarB;
        private System.Windows.Forms.Button btnModificarBarrio;
        private System.Windows.Forms.Button btnElimarB;
        private System.Windows.Forms.TextBox TxtIDBarrio;
        private System.Windows.Forms.TextBox txtNombreB;
        private System.Windows.Forms.DataGridView GrillaBarrio;
    }
}