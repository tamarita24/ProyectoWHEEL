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
    public partial class MantenedorConductorCrear : Form
    {
        public MantenedorConductorCrear()
        {
            InitializeComponent();
        }
        
        public void limpiar()
        {
            this.txtRut.Clear();
            this.txtNombre.Clear();
            this.txtApPaterno.Clear();
            this.txtApMaterno.Clear();
            this.rbFemenino.Checked = false;
            this.rbMasculino.Checked = false;
            this.txtTelefono.Clear();
            this.txtRut.Focus();

        }

        private void MantenedorConductor_Load(object sender, EventArgs e)
        {
            this.desHabilitar();
            this.btnGuardar.Text = "Nuevo";
        }

        public void habilitar()
        {
            this.txtRut.Enabled = true;
            this.txtNombre.Enabled = true;
            this.txtApPaterno.Enabled = true;
            this.txtApMaterno.Enabled = true;
            this.rbFemenino.Enabled = true;
            this.rbMasculino.Enabled = true;
            this.txtTelefono.Enabled = true;
           

        }

        public void desHabilitar()
        {
            this.txtRut.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtApPaterno.Enabled = false;
            this.txtApMaterno.Enabled = false;
            this.rbFemenino.Enabled = false;
            this.rbMasculino.Enabled = false;
            this.txtTelefono.Enabled = false;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (this.btnGuardar.Text.Equals("Nuevo"))
            {
                this.habilitar();
                this.limpiar();
                this.btnGuardar.Text = "Guardar";
                
                
                this.btnSalir.Text = "Cancelar";


            }
            else
            {
                try
                {

                    ServiceConductor.WebServiceMantenedorConductorSoapClient auxServiceConductor = new ServiceConductor.WebServiceMantenedorConductorSoapClient();
                    ServiceConductor.Conductor auxConductor = new ServiceConductor.Conductor();
                    /*
                    if(String.IsNullOrEmpty(txtRut.Text) || String.IsNullOrEmpty(txtNombre.Text)|| String.IsNullOrEmpty(txtApMaterno.Text)|| String.IsNullOrEmpty(txtApPaterno.Text) || String.IsNullOrEmpty(txtTelefono.Text) ||  this.rbFemenino.Checked == false || rbMasculino.Checked == false)
                    {
                        MessageBox.Show("Debe completar la información");
                        
                    }
                    else
                    {*/
                       
                        auxConductor.Rut = this.txtRut.Text;
                        auxConductor.Nombres = this.txtNombre.Text;
                        auxConductor.Apellido_paterno = this.txtApPaterno.Text;
                        auxConductor.Apellido_materno = this.txtApMaterno.Text;
                        auxConductor.Telefono = Convert.ToInt32(this.txtTelefono.Text);

                        if (this.rbFemenino.Checked == true)
                        {
                            auxConductor.Sexo = this.rbFemenino.Text;
                        }
                        else if (this.rbMasculino.Checked == true)
                        {
                            auxConductor.Sexo = this.rbMasculino.Text;
                        }

                        if (String.IsNullOrEmpty(auxServiceConductor.buscarConductorService(auxConductor.Rut).Rut))
                        {
                            auxServiceConductor.insertarConductorService(auxConductor);
                            MessageBox.Show("Datos Guardados ", "Sistema");
                            this.limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Conductor ya existe ", "Sistema");
                        }

                        this.desHabilitar();
                        this.limpiar();
                        this.btnGuardar.Text = "Nuevo";
                        this.btnBuscar.Enabled = true;
                        
                        this.btnSalir.Text = "Salir";

                       /*
                    }*/

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al guardar " + ex.Message, "Sistema");
                }
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

        /*
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        */

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ServiceConductor.WebServiceMantenedorConductorSoapClient auxServiceConductor = new ServiceConductor.WebServiceMantenedorConductorSoapClient();
            ServiceConductor.Conductor auxConductor = new ServiceConductor.Conductor();
            

            if (String.IsNullOrEmpty(txtRut.Text))
            {
                MessageBox.Show("Debe ingresar un rut");
            }
            else 
            {
                auxConductor = auxServiceConductor.buscarConductorService(txtRut.Text);
                this.txtRut.Text = auxConductor.Rut;
                this.txtNombre.Text = auxConductor.Nombres;
                this.txtApPaterno.Text = auxConductor.Apellido_paterno;
                this.txtApMaterno.Text = auxConductor.Apellido_paterno;
                this.rbFemenino.Text = auxConductor.Sexo;
                this.rbMasculino.Text = auxConductor.Sexo;
                this.txtTelefono.Text = Convert.ToString(auxConductor.Telefono);
                this.btnGuardar.Enabled = false;

            }
            
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ServiceConductor.WebServiceMantenedorConductorSoapClient auxServiceConductor = new ServiceConductor.WebServiceMantenedorConductorSoapClient();
            ServiceConductor.Conductor auxConductor = new ServiceConductor.Conductor();

            auxConductor.Rut = this.txtRut.Text;
            auxConductor.Nombres = this.txtNombre.Text;
            auxConductor.Apellido_paterno = this.txtApPaterno.Text;
            auxConductor.Apellido_materno = this.txtApMaterno.Text;

            auxConductor.Telefono = Convert.ToInt32(this.txtTelefono.Text);

            if (this.rbFemenino.Checked == true)
            {
                auxConductor.Sexo = this.rbFemenino.Text;
            }
            else if (this.rbMasculino.Checked == true)
            {
                auxConductor.Sexo = this.rbMasculino.Text;
            }

            auxServiceConductor.actualizarConductorService(auxConductor);
            MessageBox.Show("Datos Guardados ", "Sistema");
            this.limpiar();

            
            this.desHabilitar();
            this.limpiar();
            this.btnGuardar.Text = "Nuevo";
            this.btnBuscar.Enabled = true;
            this.btnGuardar.Enabled = true;

            this.btnSalir.Text = "Salir";
            
        }
    }
}
