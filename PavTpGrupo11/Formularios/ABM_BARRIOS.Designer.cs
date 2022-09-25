
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
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ABM_BARRIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}