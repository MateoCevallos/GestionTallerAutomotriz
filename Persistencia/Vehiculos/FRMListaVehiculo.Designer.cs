namespace GestionTallerAutomotriz.Persistencia.Vehiculos
{
    partial class FRMListaVehiculo
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
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.btnEditarVehiculo = new System.Windows.Forms.Button();
            this.btnNuevoVehiculo = new System.Windows.Forms.Button();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(219, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gestion de Vehículos";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSalir.Location = new System.Drawing.Point(425, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 75);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEliminarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(305, 399);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(114, 75);
            this.btnEliminarVehiculo.TabIndex = 15;
            this.btnEliminarVehiculo.Text = "Eliminar";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = false;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click_1);
            // 
            // btnEditarVehiculo
            // 
            this.btnEditarVehiculo.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEditarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditarVehiculo.Location = new System.Drawing.Point(185, 399);
            this.btnEditarVehiculo.Name = "btnEditarVehiculo";
            this.btnEditarVehiculo.Size = new System.Drawing.Size(114, 75);
            this.btnEditarVehiculo.TabIndex = 14;
            this.btnEditarVehiculo.Text = "Editar";
            this.btnEditarVehiculo.UseVisualStyleBackColor = false;
            this.btnEditarVehiculo.Click += new System.EventHandler(this.btnEditarVehiculo_Click);
            // 
            // btnNuevoVehiculo
            // 
            this.btnNuevoVehiculo.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnNuevoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNuevoVehiculo.Location = new System.Drawing.Point(65, 399);
            this.btnNuevoVehiculo.Name = "btnNuevoVehiculo";
            this.btnNuevoVehiculo.Size = new System.Drawing.Size(114, 75);
            this.btnNuevoVehiculo.TabIndex = 13;
            this.btnNuevoVehiculo.Text = "Nuevo";
            this.btnNuevoVehiculo.UseVisualStyleBackColor = false;
            this.btnNuevoVehiculo.Click += new System.EventHandler(this.btnNuevoVehiculo_Click_1);
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.BackColor = System.Drawing.Color.Gainsboro;
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.Location = new System.Drawing.Point(65, 70);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(474, 316);
            this.lstVehiculos.TabIndex = 12;
            // 
            // FRMListaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(605, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarVehiculo);
            this.Controls.Add(this.btnEditarVehiculo);
            this.Controls.Add(this.btnNuevoVehiculo);
            this.Controls.Add(this.lstVehiculos);
            this.Name = "FRMListaVehiculo";
            this.Text = "FRMListaVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnEditarVehiculo;
        private System.Windows.Forms.Button btnNuevoVehiculo;
        private System.Windows.Forms.ListBox lstVehiculos;
    }
}