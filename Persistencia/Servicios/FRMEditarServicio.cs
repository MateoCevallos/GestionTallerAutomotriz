using System;
using System.Windows.Forms;
using GestionTallerAutomotriz.Aplicacion;
using GestionTallerAutomotriz.Datos;

namespace GestionTallerAutomotriz.Persistencia.Servicios
{
    public partial class FRMEditarServicio : Form
    {
        private readonly ServicioService _servicioService = new ServicioService();
        private readonly VehiculoService _vehiculoService = new VehiculoService();
        private ServicioDTO _servicio;

        public FRMEditarServicio(ServicioDTO servicio)
        {
            InitializeComponent();
            _servicio = servicio;
            this.Load += new EventHandler(FRMEditarServicio_Load);
        }

        private void FRMEditarServicio_Load(object sender, EventArgs e)
        {
            // Cargar los vehículos en el ComboBox
            var listaVehiculos = _vehiculoService.todos();
            cbVehiculoID.DataSource = listaVehiculos;
            cbVehiculoID.DisplayMember = "Placa"; // Mostrar la placa en la lista
            cbVehiculoID.ValueMember = "VehiculoID";

            // Rellenar los campos si se está editando
            if (_servicio != null)
            {
                dtpFecha.Value = _servicio.Fecha;
                cbTipoServicio.Text = _servicio.TipoServicio;
                txtCosto.Text = _servicio.Costo.ToString("0.00");
                txtObservacion.Text = _servicio.Observaciones;
                cbVehiculoID.SelectedValue = _servicio.VehiculoID;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            _servicio.Fecha = dtpFecha.Value;
            _servicio.TipoServicio = cbTipoServicio.Text.Trim();

            if (double.TryParse(txtCosto.Text.Trim(), out double costo))
                _servicio.Costo = costo;
            else
            {
                MessageBox.Show("Ingrese un costo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _servicio.Observaciones = txtObservacion.Text.Trim();

            if (cbVehiculoID.SelectedValue is int vehiculoId)
                _servicio.VehiculoID = vehiculoId;

            var resultado = _servicioService.actualizar(_servicio);

            if (resultado == "ok")
            {
                MessageBox.Show("Servicio actualizado con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar el servicio.");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
