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
            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
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
            //this.txtRut.Enabled = false;
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

                    
                    if(String.IsNullOrEmpty(txtRut.Text) && String.IsNullOrEmpty(txtNombre.Text) && String.IsNullOrEmpty(txtApMaterno.Text)&& String.IsNullOrEmpty(txtApPaterno.Text) && String.IsNullOrEmpty(txtTelefono.Text) &&  this.rbFemenino.Checked == false && rbMasculino.Checked == false)
                    {
                        MessageBox.Show("Debe completar la información");
                        
                    }
                    else
                    {
                        ServiceConductor.WebServiceMantenedorConductorSoapClient auxServiceConductor = new ServiceConductor.WebServiceMantenedorConductorSoapClient();
                        ServiceConductor.Conductor auxConductor = new ServiceConductor.Conductor();
                        

                        if (String.IsNullOrEmpty(auxServiceConductor.buscarConductorService(auxConductor.Rut).Rut))
                        {
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

                            auxServiceConductor.insertarConductorService(auxConductor);
                            MessageBox.Show("Datos Guardados ", "Sistema");
                            this.limpiar();
                            this.desHabilitar();
                        }
                        else
                        {
                            MessageBox.Show("Conductor ya existe ", "Sistema");
                        }

                        
                        this.limpiar();
                        this.btnGuardar.Text = "Nuevo";
                        this.btnBuscar.Enabled = true;
                        
                        this.btnSalir.Text = "Salir";

                       
                    }

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
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ServiceConductor.WebServiceMantenedorConductorSoapClient auxServiceConductor = new ServiceConductor.WebServiceMantenedorConductorSoapClient();
            ServiceConductor.Conductor auxConductor = new ServiceConductor.Conductor();
            

            if (String.IsNullOrEmpty(txtRut.Text))
            {
                MessageBox.Show("Debe ingresar un Rut");
            }
            else 
            {
                if (String.IsNullOrEmpty(auxServiceConductor.buscarConductorService(this.txtRut.Text).Rut))
                {
                    MessageBox.Show("El Rut ingresado no existe");
                }
                else
                {
                    auxConductor = auxServiceConductor.buscarConductorService(txtRut.Text);
                    this.txtRut.Text = auxConductor.Rut;
                    this.txtNombre.Text = auxConductor.Nombres;
                    this.txtApPaterno.Text = auxConductor.Apellido_paterno;
                    this.txtApMaterno.Text = auxConductor.Apellido_paterno;

                    if (this.rbFemenino.Text == auxConductor.Sexo)
                    {
                        this.rbFemenino.Checked = true;
                    }
                    else
                    {
                        this.rbMasculino.Checked = true;
                    }

                    this.txtTelefono.Text = Convert.ToString(auxConductor.Telefono);
                    this.btnGuardar.Enabled = false;
                    this.btnEditar.Enabled = true;
                    this.btnEliminar.Enabled = true;
                    this.habilitar();
                }
                
            }
            
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (this.txtRut.Text == "")
                {
                    MessageBox.Show("Debe ingresar un Rut");
                }
                else
                {
                    

                    if (MessageBox.Show("Estas Seguro de actualizar ", "sistema", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ServiceConductor.WebServiceMantenedorConductorSoapClient auxServiceConductor = new ServiceConductor.WebServiceMantenedorConductorSoapClient();
                        ServiceConductor.Conductor auxConductor2 = new ServiceConductor.Conductor();

                        auxConductor2.Rut = this.txtRut.Text;
                        auxConductor2.Nombres = this.txtNombre.Text;
                        auxConductor2.Apellido_paterno = this.txtApPaterno.Text;
                        auxConductor2.Apellido_materno = this.txtApMaterno.Text;
                        if (this.rbFemenino.Checked == true)
                        {
                            auxConductor2.Sexo = this.rbFemenino.Text;
                        }
                        else if (this.rbMasculino.Checked == true)
                        {
                            auxConductor2.Sexo = this.rbMasculino.Text;
                        }

                        auxConductor2.Telefono = Convert.ToInt32(this.txtTelefono.Text);

                        auxServiceConductor.actualizarConductorService(auxConductor2);
                        MessageBox.Show("Datos Actualizados Exitosamente ", "Sistema");
                        
                        this.btnGuardar.Enabled = true;
                        this.btnEditar.Enabled = false;
                        this.btnEliminar.Enabled = false;
                        this.desHabilitar();
                        this.limpiar();
                        this.btnGuardar.Text = "Nuevo";
                        this.btnBuscar.Enabled = true;
                        

                        this.btnSalir.Text = "Salir";
                        
                        txtRut.Focus();


                        
                        
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                        
            try
            {
                if (this.txtRut.Text == "")
                {
                    MessageBox.Show("Ingrese un Rut");
                }
                else
                {
                    ServiceConductor.WebServiceMantenedorConductorSoapClient auxServiceConductor = new ServiceConductor.WebServiceMantenedorConductorSoapClient();
                    

                    if (auxServiceConductor.buscarConductorService((this.txtRut.Text)).Rut.Equals(0))
                    {
                        MessageBox.Show("El Rut no existe");
                        this.limpiar();
                    }
                    else
                    {
                        if (MessageBox.Show("Estas Seguro de Eliminar ", "sistema", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            auxServiceConductor.eliminiarConductorService(this.txtRut.Text);
                            MessageBox.Show("Conductor fue eliminada exitosamente", "Sistema");
                           
                            this.btnGuardar.Enabled = true;
                            this.btnEditar.Enabled = false;
                            this.btnEliminar.Enabled = false;
                            this.desHabilitar();
                            this.limpiar();
                            this.btnGuardar.Text = "Nuevo";
                            this.btnBuscar.Enabled = true;


                            this.btnSalir.Text = "Salir";

                            txtRut.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MantenedorConductorListar pListado = new MantenedorConductorListar();
            pListado.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
            this.btnGuardar.Enabled = true;
        }
    }
}
