using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionTallerAutomotriz.Aplicacion;
using GestionTallerAutomotriz.Datos;

namespace GestionTallerAutomotriz.Persistencia.Vehiculos
{
    public partial class FRMEditarVehiculo : Form
    {
        private readonly VehiculoService _vehiculoService = new VehiculoService();
        private VehiculosDTO _vehiculo;

        public FRMEditarVehiculo(Datos.VehiculosDTO vehiculo)
        {
            InitializeComponent();
            _vehiculo = vehiculo;
            this.Load += new EventHandler(FRMEditarVehiculo_Load);
        }

        private void FRMEditarVehiculo_Load(object sender, EventArgs e)
        {
            // Cargar lista de clientes
            var clienteService = new ClienteService();
            var listaClientes = clienteService.todos();
            cbClienteID.DataSource = listaClientes;
            cbClienteID.DisplayMember = "Nombre";
            cbClienteID.ValueMember = "ClienteID";

            // Cargar datos del vehículo en el formulario
            if (_vehiculo != null)
            {
                txtPlaca.Text = _vehiculo.Placa;
                txtMarca.Text = _vehiculo.Marca;
                txtModelo.Text = _vehiculo.Modelo;
                txtAnio.Text = _vehiculo.Anio.ToString();
                cbClienteID.SelectedValue = _vehiculo.ClienteID;
            }
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

            // Actualizar los datos del objeto existente
            _vehiculo.Placa = txtPlaca.Text.Trim();
            _vehiculo.Marca = txtMarca.Text.Trim();
            _vehiculo.Modelo = txtModelo.Text.Trim();
            _vehiculo.Anio = anio;
            _vehiculo.ClienteID = (int)cbClienteID.SelectedValue;

            var resultado = _vehiculoService.actualizar(_vehiculo);

            if (resultado == "ok")
            {
                MessageBox.Show("Vehículo actualizado con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al actualizar el vehículo.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
