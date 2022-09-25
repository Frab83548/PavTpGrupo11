
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
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtNombreBarrio = new System.Windows.Forms.MaskedTextBox();
            this.grillaBarrios = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificarB = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(221, 66);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(198, 20);
            this.txtBarrio.TabIndex = 0;
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Location = new System.Drawing.Point(221, 112);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(198, 20);
            this.txtNombreBarrio.TabIndex = 1;
            // 
            // grillaBarrios
            // 
            this.grillaBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaBarrios.Location = new System.Drawing.Point(69, 171);
            this.grillaBarrios.Name = "grillaBarrios";
            this.grillaBarrios.Size = new System.Drawing.Size(560, 160);
            this.grillaBarrios.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo Barrio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // btnModificarB
            // 
            this.btnModificarB.Location = new System.Drawing.Point(221, 370);
            this.btnModificarB.Name = "btnModificarB";
            this.btnModificarB.Size = new System.Drawing.Size(159, 48);
            this.btnModificarB.TabIndex = 6;
            this.btnModificarB.Text = "Modificar";
            this.btnModificarB.UseVisualStyleBackColor = true;
            this.btnModificarB.Click += new System.EventHandler(this.btnModificarB_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(404, 370);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(159, 48);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // ABM_BARRIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificarB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grillaBarrios);
            this.Controls.Add(this.txtNombreBarrio);
            this.Controls.Add(this.txtBarrio);
            this.Name = "ABM_BARRIOS";
            this.Text = "ABM_BARRIOS";
            this.Load += new System.EventHandler(this.ABM_BARRIOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaBarrios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.MaskedTextBox txtNombreBarrio;
        private System.Windows.Forms.DataGridView grillaBarrios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarB;
        private System.Windows.Forms.Button btnBorrar;
    }
}