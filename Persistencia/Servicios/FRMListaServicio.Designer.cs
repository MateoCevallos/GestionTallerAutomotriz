namespace GestionTallerAutomotriz.Persistencia.Servicios
{
    partial class FRMListaServicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.btnEditarServicio = new System.Windows.Forms.Button();
            this.btnNuevoServicio = new System.Windows.Forms.Button();
            this.lstServicios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(228, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gestion de Servicios";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSalir.Location = new System.Drawing.Point(426, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 75);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEliminarServicio.Location = new System.Drawing.Point(306, 397);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(114, 75);
            this.btnEliminarServicio.TabIndex = 15;
            this.btnEliminarServicio.Text = "Eliminar";
            this.btnEliminarServicio.UseVisualStyleBackColor = false;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // btnEditarServicio
            // 
            this.btnEditarServicio.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEditarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditarServicio.Location = new System.Drawing.Point(186, 397);
            this.btnEditarServicio.Name = "btnEditarServicio";
            this.btnEditarServicio.Size = new System.Drawing.Size(114, 75);
            this.btnEditarServicio.TabIndex = 14;
            this.btnEditarServicio.Text = "Editar";
            this.btnEditarServicio.UseVisualStyleBackColor = false;
            this.btnEditarServicio.Click += new System.EventHandler(this.btnEditarServicio_Click);
            // 
            // btnNuevoServicio
            // 
            this.btnNuevoServicio.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnNuevoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNuevoServicio.Location = new System.Drawing.Point(66, 397);
            this.btnNuevoServicio.Name = "btnNuevoServicio";
            this.btnNuevoServicio.Size = new System.Drawing.Size(114, 75);
            this.btnNuevoServicio.TabIndex = 13;
            this.btnNuevoServicio.Text = "Nuevo";
            this.btnNuevoServicio.UseVisualStyleBackColor = false;
            this.btnNuevoServicio.Click += new System.EventHandler(this.btnNuevoServicio_Click);
            // 
            // lstServicios
            // 
            this.lstServicios.BackColor = System.Drawing.Color.Gainsboro;
            this.lstServicios.FormattingEnabled = true;
            this.lstServicios.Location = new System.Drawing.Point(66, 68);
            this.lstServicios.Name = "lstServicios";
            this.lstServicios.Size = new System.Drawing.Size(474, 316);
            this.lstServicios.TabIndex = 12;
            // 
            // FRMListaServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(605, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarServicio);
            this.Controls.Add(this.btnEditarServicio);
            this.Controls.Add(this.btnNuevoServicio);
            this.Controls.Add(this.lstServicios);
            this.Name = "FRMListaServicio";
            this.Text = "FRMListaServicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.Button btnEditarServicio;
        private System.Windows.Forms.Button btnNuevoServicio;
        private System.Windows.Forms.ListBox lstServicios;
    }
}