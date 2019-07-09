using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class MantenedorViaje : Form
    {
        public MantenedorViaje()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            this.txtIdViaje.Clear();
            this.txtNombreConductor.Clear();
            this.txtDistancia.Clear();
            this.txtTarifaViaje.Clear();
            this.txtLugarOrigen.Clear();
            this.txtLugarDestino.Clear();
            this.txtTotalPago.Clear();
           // this.cbxNombreServicio.clear();
            //this.cbxTipoPago.clear();
            this.txtIdViaje.Focus();

        }

        public void habilitar()
        {
            this.txtIdViaje.Enabled = true;
            this.txtNombreConductor.Enabled = true;
            this.txtDistancia.Enabled = true;
            this.txtTarifaViaje.Enabled = true;
            this.txtLugarOrigen.Enabled = true;
            this.txtLugarDestino.Enabled = true;
            this.txtTotalPago.Enabled = true;
            this.cbxNombreServicio.Enabled = true;
            this.cbxTipoPago.Enabled = true;

        }

        public void desHabilitar()
        {
            
            //this.txtIdViaje.Enabled = false;
            this.txtNombreConductor.Enabled = false;
            this.txtDistancia.Enabled = false;
            this.txtTarifaViaje.Enabled = false;
            this.txtLugarOrigen.Enabled = false;
            this.txtLugarDestino.Enabled = false;
            this.txtTotalPago.Enabled = false;
            this.cbxNombreServicio.Enabled = false;
            this.cbxTipoPago.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ServiceViaje.WebServiceMantenedorViajeSoapClient auxServiceViaje = new ServiceViaje.WebServiceMantenedorViajeSoapClient();

            this.dataGridViewViajePago.DataSource = auxServiceViaje.retornaViajerService();
            this.dataGridViewViajePago.DataMember = "Viaje";
        }

        private void MantenedorViaje_Load(object sender, EventArgs e)
        {
            //this.desHabilitar();
            //this.btnGuardar.Text = "Nuevo";
            //this.btnEditar.Enabled = true;
            //this.btnEliminar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ServiceViaje.WebServiceMantenedorViajeSoapClient auxServiceViaje = new ServiceViaje.WebServiceMantenedorViajeSoapClient();
            ServiceViaje.Viaje auxViaje = new ServiceViaje.Viaje();

            ServicePago.WebServiceMantenedorPagoSoapClient auxServicePago = new ServicePago.WebServiceMantenedorPagoSoapClient();
            ServicePago.Pago auxPago = new ServicePago.Pago();

            if (auxServiceViaje.buscarViajeService(Convert.ToInt16(this.txtIdViaje)).Id_viaje.Equals(0))
            {
                /*auxViaje.Rut = this.txtRut.Text;
                auxViaje.Nombres = this.txtNombre.Text;
                auxViaje.Apellido_paterno = this.txtApPaterno.Text;
                auxViaje.Apellido_materno = this.txtApMaterno.Text;
                auxViaje.Telefono = Convert.ToInt32(this.txtTelefono.Text);

                if (this.rbFemenino.Checked == true)
                {
                    auxConductor.Sexo = this.rbFemenino.Text;
                }
                else if (this.rbMasculino.Checked == true)
                {
                    auxConductor.Sexo = this.rbMasculino.Text;
                }

                auxServiceConductor.insertarConductorService(auxConductor);
                MessageBox.Show("Datos Guardados ", "Sistema");
                this.limpiar();
                this.desHabilitar();
                */
            }
            else
            {
                MessageBox.Show("Viaje ya existe ", "Sistema");
            }

            /*
            this.limpiar();
            this.btnGuardar.Text = "Nuevo";
            this.btnBuscar.Enabled = true;

            this.btnSalir.Text = "Salir";
            */
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            this.btnGuardar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.btnSalir.Text.Equals("Salir"))
            {
                this.Dispose();
                System.GC.Collect();
            }
            else
            {

                this.desHabilitar();
                this.limpiar();
                this.btnGuardar.Text = "Nuevo";



                this.btnSalir.Text = "Salir";
            }
        }
    }
}
