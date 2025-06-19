using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using GestionTallerAutomotriz.Aplicacion;

namespace GestionTallerAutomotriz.Persistencia.Clientes
{
    public partial class FRMEditarCliente : Form
    {
        private Aplicacion.ClienteService _clienteService = new Aplicacion.ClienteService();
        private Datos.ClientesDTO _cliente;

        public FRMEditarCliente(Datos.ClientesDTO cliente)
        {
            InitializeComponent();
            _cliente = cliente;
        }

        private void FRMEditarCliente_Load(object sender, EventArgs e)
        {
            if (_cliente != null)
            {
                txtNombre.Text = _cliente.Nombre;
                txtCedula.Text = _cliente.Cedula;
                txtTelefono.Text = _cliente.Telefono;
                txtEmail.Text = _cliente.Email;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            _cliente.Nombre = txtNombre.Text.Trim();
            _cliente.Cedula = txtCedula.Text.Trim();
            _cliente.Telefono = txtTelefono.Text.Trim();
            _cliente.Email = txtEmail.Text.Trim();

            var resultado = _clienteService.actualizar(_cliente);

            if (resultado == "ok")
            {
                MessageBox.Show("Cliente actualizado con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar el cliente.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
