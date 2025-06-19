using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTallerAutomotriz.Persistencia.Vehiculos
{
    public partial class FRMNuevoVehiculo : Form
    {
        public FRMNuevoVehiculo()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAnio.Text.Trim(), out int anio))
            {
                MessageBox.Show("Ingrese un año válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbClienteID.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var vehiculo = new Datos.VehiculosDTO
            {
                Placa = txtPlaca.Text.Trim(),
                Marca = txtMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Anio = anio,
                ClienteID = (int)cbClienteID.SelectedValue
            };

            var _vehiculoService = new Aplicacion.VehiculoService();
            if (_vehiculoService.insertar(vehiculo) == "ok")
            {
                MessageBox.Show("Vehículo guardado con éxito.");
                txtPlaca.Text = "";
                txtMarca.Text = "";
                txtModelo.Text = "";
                txtAnio.Text = "";
                cbClienteID.SelectedIndex = -1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar el vehículo.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMNuevoVehiculo_Load(object sender, EventArgs e)
        {
            var clienteService = new Aplicacion.ClienteService();
            var listaClientes = clienteService.todos();

            cbClienteID.DataSource = listaClientes;
            cbClienteID.DisplayMember = "Nombre";      // o puedes usar Cedula, etc.
            cbClienteID.ValueMember = "ClienteID";
            cbClienteID.SelectedIndex = -1; // Ninguno seleccionado por defecto
        }
    }
}
