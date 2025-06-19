using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTallerAutomotriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var FRMListaClientes = new Persistencia.Clientes.FRMListaCliente();

            FRMListaClientes.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            var FRMListaVehiculos = new Persistencia.Vehiculos.FRMListaVehiculo();

            FRMListaVehiculos.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            var FRMListaServicios = new Persistencia.Servicios.FRMListaServicio();

            FRMListaServicios.Show();
        }
    }
}
