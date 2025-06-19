using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestionTallerAutomotriz.Persistencia.Servicios
{
    public partial class FRMListaServicio : Form
    {
        private readonly Aplicacion.ServicioService _servicioService = new Aplicacion.ServicioService();

        public FRMListaServicio()
        {
            InitializeComponent();
            this.Activated += new EventHandler(FRMListaServicio_Activated);
        }

        public void cargaLista()
        {
            lstServicios.DataSource = _servicioService.todos().ToList();
            lstServicios.DisplayMember = "TipoServicio";   // Puedes mostrar Fecha o combinar
            lstServicios.ValueMember = "ServicioID";
        }

        private void FRMListaServicio_Activated(object sender, EventArgs e)
        {
            cargaLista(); // Recarga al volver al formulario
        }

        private void FRMListaServicio_Load(object sender, EventArgs e)
        {
            cargaLista();
        }

        private void btnEditarServicio_Click(object sender, EventArgs e)
        {
            if (lstServicios.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un servicio para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var servicioSeleccionado = (Datos.ServicioDTO)lstServicios.SelectedItem;

            var frmEditarServicio = new FRMEditarServicio(servicioSeleccionado);
            frmEditarServicio.ShowDialog();

            cargaLista();
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            if (lstServicios.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un servicio para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var servicioSeleccionado = (Datos.ServicioDTO)lstServicios.SelectedItem;

            var confirmacion = MessageBox.Show(
                $"¿Deseas eliminar el servicio del {servicioSeleccionado.Fecha.ToShortDateString()}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                var resultado = _servicioService.eliminar(servicioSeleccionado.ServicioID);

                if (resultado == "ok")
                {
                    MessageBox.Show("Servicio eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargaLista();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            var frmNuevo = new FRMNuevoServicio();
            frmNuevo.ShowDialog();
            cargaLista(); // Refrescar después de agregar
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
