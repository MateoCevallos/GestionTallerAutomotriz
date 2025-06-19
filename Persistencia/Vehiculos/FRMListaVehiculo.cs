using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionTallerAutomotriz.Persistencia.Vehiculos;

namespace GestionTallerAutomotriz.Persistencia.Vehiculos
{
    public partial class FRMListaVehiculo : Form
    {
        private readonly Aplicacion.VehiculoService _vehiculoService = new Aplicacion.VehiculoService();

        public FRMListaVehiculo()
        {
            InitializeComponent();
            this.Activated += new EventHandler(FRMListaVehiculo_Activated);
        }

        public void cargaLista()
        {
            lstVehiculos.DataSource = _vehiculoService.todos().ToList();
            lstVehiculos.DisplayMember = "Placa";      // o Marca, según lo que prefieras mostrar
            lstVehiculos.ValueMember = "VehiculoID";
        }

        private void FRMListaVehiculo_Activated(object sender, EventArgs e)
        {
            cargaLista(); // Se actualiza automáticamente al volver al formulario
        }

        private void btnEditarVehiculo_Click(object sender, EventArgs e)
        {
            if (lstVehiculos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un vehículo para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var vehiculoSeleccionado = (Datos.VehiculosDTO)lstVehiculos.SelectedItem;

            var fRMEditarVehiculo = new FRMEditarVehiculo(vehiculoSeleccionado);
            fRMEditarVehiculo.ShowDialog();

            cargaLista(); // Recarga la lista después de editar
        }
        private void FRMListaVehiculo_Load(object sender, EventArgs e)
        {
            this.cargaLista();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEliminarVehiculo_Click_1(object sender, EventArgs e)
        {
            if (lstVehiculos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un vehículo para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var vehiculoSeleccionado = (Datos.VehiculosDTO)lstVehiculos.SelectedItem;

            var confirmacion = MessageBox.Show(
                $"¿Estás seguro de que deseas eliminar el vehículo con placa {vehiculoSeleccionado.Placa}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                var resultado = _vehiculoService.eliminar(vehiculoSeleccionado.VehiculoID);

                if (resultado == "ok")
                {
                    MessageBox.Show("Vehículo eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargaLista();
                }
                else if (resultado == "tiene_servicios")
                {
                    MessageBox.Show("Este vehículo no puede eliminarse porque tiene servicios registrados.\n" +
                                    "Elimina primero los servicios antes de eliminar este vehículo.",
                                    "Restricción de integridad",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al eliminar el vehículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoVehiculo_Click_1(object sender, EventArgs e)
        {
            var fRMNuevoVehiculo = new FRMNuevoVehiculo();
            fRMNuevoVehiculo.ShowDialog();
        }
    }
}
