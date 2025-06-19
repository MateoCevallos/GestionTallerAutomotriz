using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionTallerAutomotriz.Persistencia.Clientes;

namespace GestionTallerAutomotriz.Persistencia.Clientes
{
    public partial class FRMListaCliente : Form
    {
        private Label label1;
        private Button btnSalir;
        private Button btnEliminarCliente;
        private Button btnEditarCliente;
        private Button btnNuevoCliente;
        private ListBox lstClientes;
        private readonly Aplicacion.ClienteService _clienteService = new Aplicacion.ClienteService();
        public FRMListaCliente()
        {
            InitializeComponent();
            this.Activated += new EventHandler(FRMListaClientes_Activated);
        }

        public void cargaLista() {
            lstClientes.DataSource = _clienteService.todos().ToList();
            lstClientes.DisplayMember = "Nombre";
            lstClientes.ValueMember = "ClienteID";
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            var fRMNuevoCliente = new FRMNuevoCliente();
            fRMNuevoCliente.ShowDialog();
        }

        private void FRMListaClientes_Activated(object sender, EventArgs e)
        {
            this.cargaLista();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(220, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gestion de Clientes";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSalir.Location = new System.Drawing.Point(421, 394);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 75);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEliminarCliente.Location = new System.Drawing.Point(301, 394);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(114, 75);
            this.btnEliminarCliente.TabIndex = 9;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click_1);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEditarCliente.Location = new System.Drawing.Point(181, 394);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(114, 75);
            this.btnEditarCliente.TabIndex = 8;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNuevoCliente.Location = new System.Drawing.Point(61, 394);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(114, 75);
            this.btnNuevoCliente.TabIndex = 7;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click_1);
            // 
            // lstClientes
            // 
            this.lstClientes.BackColor = System.Drawing.Color.Gainsboro;
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(61, 65);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(474, 316);
            this.lstClientes.TabIndex = 6;
            // 
            // FRMListaCliente
            // 
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(605, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.lstClientes);
            this.Name = "FRMListaCliente";
            this.Load += new System.EventHandler(this.FRMListaClientes_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnNuevoCliente_Click_1(object sender, EventArgs e)
        {
            var fRMNuevoCliente = new FRMNuevoCliente();
            fRMNuevoCliente.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clienteSeleccionado = (Datos.ClientesDTO)lstClientes.SelectedItem;

            var fRMEditarCliente = new FRMEditarCliente(clienteSeleccionado);
            fRMEditarCliente.ShowDialog();
            cargaLista(); // Recarga la lista cuando cierras el formulario
            
           
        }

        private void FRMListaClientes_Load_1(object sender, EventArgs e)
        {
            this.cargaLista();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarCliente_Click_1(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clienteSeleccionado = (Datos.ClientesDTO)lstClientes.SelectedItem;

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar a {clienteSeleccionado.Nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                var resultado = _clienteService.eliminar(clienteSeleccionado.ClienteID);

                if (resultado == "ok")
                {
                    MessageBox.Show("Cliente eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargaLista();
                }
                else if (resultado == "tiene_vehiculos")
                {
                    MessageBox.Show(
                        "No se puede eliminar este cliente porque tiene vehículos registrados.\n" +
                        "Elimina primero los vehículos asociados antes de eliminar al cliente.",
                        "Restricción de integridad",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
