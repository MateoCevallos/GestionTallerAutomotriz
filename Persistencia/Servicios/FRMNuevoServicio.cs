using System;
using System.Windows.Forms;
using GestionTallerAutomotriz.Aplicacion;
using GestionTallerAutomotriz.Datos;

namespace GestionTallerAutomotriz.Persistencia.Servicios
{
    public partial class FRMNuevoServicio : Form
    {
        private readonly VehiculoService _vehiculoService = new VehiculoService();
        private readonly ServicioService _servicioService = new ServicioService();

        public FRMNuevoServicio()
        {
            InitializeComponent();
            this.Load += FRMNuevoServicio_Load;
        }

        private void FRMNuevoServicio_Load(object sender, EventArgs e)
        {
            // Cargar tipos de servicio
            cbTipoServicio.Items.AddRange(new string[]
            {
                "Cambio de aceite",
                "Alineación y balanceo",
                "Cambio de frenos",
                "Revisión general",
                "Diagnóstico computarizado",
                "Cambio de llantas",
                "Revisión de suspensión",
                "Cambio de batería",
                "Reparación de motor"
            });

            cbTipoServicio.SelectedIndex = 0; // Selecciona el primero por defecto
            // Cargar los vehículos en el combo box
            var listaVehiculos = _vehiculoService.todos();
            cbVehiculoID.DataSource = listaVehiculos;
            cbVehiculoID.DisplayMember = "Placa";      // Muestra la placa del vehículo
            cbVehiculoID.ValueMember = "VehiculoID";   // Usa el ID como valor
        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            // Validar el costo antes de convertir
            if (!double.TryParse(txtCosto.Text.Trim(), out double costo))
            {
                MessageBox.Show("Ingrese un valor numérico válido para el costo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear nuevo servicio
            var nuevoServicio = new ServicioDTO
            {
                Fecha = dtpFecha.Value,
                TipoServicio = cbTipoServicio.Text.Trim(),
                Costo = costo,
                Observaciones = txtObservacion.Text.Trim(),
                VehiculoID = (int)cbVehiculoID.SelectedValue
            };

            var resultado = _servicioService.insertar(nuevoServicio);

            if (resultado == "ok")
            {
                MessageBox.Show("Servicio guardado con éxito.");
                dtpFecha.Value = DateTime.Now;
                cbTipoServicio.SelectedIndex = -1;
                txtCosto.Text = "";
                txtObservacion.Text = "";
                cbVehiculoID.SelectedIndex = -1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar el servicio.");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
