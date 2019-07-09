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
            this.cbxRutConductor.Text = String.Empty;
            this.txtNombreServicio.Text = String.Empty;
            //this..Text = String.Empty;
            this.txtDistancia.Clear();
            this.txtTarifaViaje.Clear();
            this.txtLugarOrigen.Clear();
            this.txtLugarDestino.Clear();
            this.txtTotalPago.Clear();
            this.txtIdViaje.Focus();

        }

        public void habilitar()
        {
            this.txtIdViaje.Enabled = true;
            this.cbxRutConductor.Enabled = true;
            this.txtDistancia.Enabled = true;
            this.txtTarifaViaje.Enabled = true;
            this.txtLugarOrigen.Enabled = true;
            this.txtLugarDestino.Enabled = true;
            this.txtTotalPago.Enabled = true;
            this.txtNombreServicio.Enabled = true;
            //this.cbxIdTipoPago.Enabled = true;

        }

        public void desHabilitar()
        {
            
            //this.txtIdViaje.Enabled = false;
            this.cbxRutConductor.Enabled = false;
            this.txtDistancia.Enabled = false;
            this.txtTarifaViaje.Enabled = false;
            this.txtLugarOrigen.Enabled = false;
            this.txtLugarDestino.Enabled = false;
            this.txtTotalPago.Enabled = false;
            this.txtNombreServicio.Enabled = false;
           // this.cbxIdTipoPago.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ServiceViaje.WebServiceMantenedorViajeSoapClient auxServiceViaje = new ServiceViaje.WebServiceMantenedorViajeSoapClient();

            this.dataGridViewViajePago.DataSource = auxServiceViaje.retornaViajerService();
            this.dataGridViewViajePago.DataMember = "Viaje";
        }

        private void MantenedorViaje_Load(object sender, EventArgs e)
        {
            ServiceConductor.WebServiceMantenedorConductorSoapClient auxServiceConductor = new ServiceConductor.WebServiceMantenedorConductorSoapClient();
            this.cbxRutConductor.DisplayMember = "nombres";
            this.cbxRutConductor.ValueMember = "rut";
            this.cbxRutConductor.DataSource = auxServiceConductor.MostrarNomConductorService();

          

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

            /*
            if (auxServiceViaje.buscarViajeService(Convert.ToInt16(this.txtIdViaje)).Id_viaje.Equals(0))
            {*/
                auxViaje.Id_viaje = Convert.ToInt32(this.txtIdViaje.Text);
                //auxViaje.Fecha_viaje = DateTime.Now.Date.ToUniversalTime();
                auxViaje.Fecha_viaje = DateTime.Now;
                auxViaje.Rut = Convert.ToString(this.cbxRutConductor.SelectedValue);
                auxViaje.Distancia = Convert.ToInt32(this.txtDistancia.Text);
                auxViaje.Tarifa_viaje = Convert.ToInt32(this.txtTarifaViaje.Text);
                auxViaje.Lugar_origen = this.txtLugarOrigen.Text;
                auxViaje.Lugar_destino = this.txtLugarDestino.Text;
                auxViaje.Nombre_servicio = this.txtNombreServicio.Text;

                //int valor = +1;
                auxPago.Id_pago = auxPago.Id_pago + 1;
                //auxPago.Id_pago = 
                auxPago.Fecha_pago = DateTime.Now;

                //int total = Convert.ToInt32(this.txtDistancia.Text) * Convert.ToInt32(this.txtTarifaViaje.Text);
                //this.txtTotalPago.Text = Convert.ToString(total);
                auxPago.Total_pago = Convert.ToInt32(this.txtTotalPago.Text);
                auxPago.Nombre_tipopago = this.txtNombreServicio.Text;

                auxServiceViaje.insertarViajeService(auxViaje);
                auxServicePago.insertarPagoService(auxPago);
                MessageBox.Show("Datos Guardados ", "Sistema");
                this.limpiar();
                this.desHabilitar();
             /*   
            }
            else
            {
                MessageBox.Show("Viaje ya existe ", "Sistema");
            }*/

            /*
            this.limpiar();
            this.btnGuardar.Text = "Nuevo";
            this.btnBuscar.Enabled = true;

            this.btnSalir.Text = "Salir";
            */
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas Seguro de actualizar ", "sistema", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ServiceViaje.WebServiceMantenedorViajeSoapClient auxServiceViaje = new ServiceViaje.WebServiceMantenedorViajeSoapClient();
                ServiceViaje.Viaje auxViaje = new ServiceViaje.Viaje();

                ServicePago.WebServiceMantenedorPagoSoapClient auxServicePago = new ServicePago.WebServiceMantenedorPagoSoapClient();
                ServicePago.Pago auxPago = new ServicePago.Pago();

                auxViaje.Id_viaje = Convert.ToInt32(this.txtIdViaje.Text);
                //auxViaje.Fecha_viaje = DateTime.Now.Date.ToUniversalTime();
                auxViaje.Fecha_viaje = DateTime.Now;
                auxViaje.Rut = Convert.ToString(this.cbxRutConductor.SelectedValue);
                auxViaje.Distancia = Convert.ToInt32(this.txtDistancia.Text);
                auxViaje.Tarifa_viaje = Convert.ToInt32(this.txtTarifaViaje.Text);
                auxViaje.Lugar_origen = this.txtLugarOrigen.Text;
                auxViaje.Lugar_destino = this.txtLugarDestino.Text;
                auxViaje.Nombre_servicio = this.txtNombreServicio.Text;

                //int valor = +1;
                auxPago.Id_pago = auxPago.Id_pago + 1;
                //auxPago.Id_pago = 
                auxPago.Fecha_pago = DateTime.Now;
                auxPago.Total_pago = Convert.ToInt32(this.txtTotalPago.Text);
                auxPago.Nombre_tipopago = this.txtNombreServicio.Text;

                auxServiceViaje.actualizarViajeService(auxViaje);
                auxServicePago.actualizarPagoService(auxPago);
                MessageBox.Show("Datos Actualizados Exitosamente ", "Sistema");

                /*
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.desHabilitar();
                this.limpiar();
                this.btnGuardar.Text = "Nuevo";
                this.btnBuscar.Enabled = true;


                this.btnSalir.Text = "Salir";

                txtRut.Focus();
                */


            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Estas Seguro de Eliminar ", "sistema", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ServiceViaje.WebServiceMantenedorViajeSoapClient auxServiceViaje = new ServiceViaje.WebServiceMantenedorViajeSoapClient();
                ServiceViaje.Viaje auxViaje = new ServiceViaje.Viaje();

                ServicePago.WebServiceMantenedorPagoSoapClient auxServicePago = new ServicePago.WebServiceMantenedorPagoSoapClient();
                ServicePago.Pago auxPago = new ServicePago.Pago();

                auxServiceViaje.eliminiarViajeService(Convert.ToInt32(this.txtIdViaje.Text));
                auxServicePago.eliminiarPagoService(auxViaje.Id_pago);
                MessageBox.Show("El viaje fue eliminado exitosamente", "Sistema");

                /*
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.desHabilitar();
                this.limpiar();
                this.btnGuardar.Text = "Nuevo";
                this.btnBuscar.Enabled = true;


                this.btnSalir.Text = "Salir";

                txtRut.Focus();
                */
            }
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

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ServiceViaje.WebServiceMantenedorViajeSoapClient auxServiceViaje = new ServiceViaje.WebServiceMantenedorViajeSoapClient();
            ServiceViaje.Viaje auxViaje = new ServiceViaje.Viaje();

            ServicePago.WebServiceMantenedorPagoSoapClient auxServicePago = new ServicePago.WebServiceMantenedorPagoSoapClient();
            ServicePago.Pago auxPago = new ServicePago.Pago();

            auxViaje = auxServiceViaje.buscarViajeService(Convert.ToInt32(this.txtIdViaje.Text));
            this.txtIdViaje.Text = Convert.ToString(auxViaje.Id_viaje);
            this.cbxRutConductor.Text = auxViaje.Rut;
            this.txtDistancia.Text = Convert.ToString(auxViaje.Distancia);
            this.txtTarifaViaje.Text = Convert.ToString(auxViaje.Tarifa_viaje);
            this.txtLugarOrigen.Text = auxViaje.Lugar_origen;
            this.txtLugarDestino.Text = auxViaje.Lugar_destino;
            this.txtNombreServicio.Text = auxViaje.Nombre_servicio;

            this.txtNombreServicio.Text = auxPago.Nombre_tipopago;
            this.txtTotalPago.Text = Convert.ToString(auxPago.Total_pago);

            
        }

        private void conductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorConductorCrear pConductor = new MantenedorConductorCrear();
            pConductor.ShowDialog();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(this.txtDistancia.Text) * Convert.ToInt32(this.txtTarifaViaje.Text);
            this.txtTotalPago.Text = Convert.ToString(total);
        }
    }
}
