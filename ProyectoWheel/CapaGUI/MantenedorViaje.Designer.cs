namespace CapaGUI
{
    partial class MantenedorViaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblTarifaViaje = new System.Windows.Forms.Label();
            this.lblLugarDestino = new System.Windows.Forms.Label();
            this.lblNombreServicio = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbxNombreServicio = new System.Windows.Forms.ComboBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtTarifaViaje = new System.Windows.Forms.TextBox();
            this.txtLugarDestino = new System.Windows.Forms.TextBox();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.lblIdTipoPago = new System.Windows.Forms.Label();
            this.cbxTipoPago = new System.Windows.Forms.ComboBox();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.lblNombreConductor = new System.Windows.Forms.Label();
            this.txtNombreConductor = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdViaje = new System.Windows.Forms.TextBox();
            this.dataGridViewViajePago = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLugarOrigen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViajePago)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(24, 89);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(51, 13);
            this.lblDistancia.TabIndex = 1;
            this.lblDistancia.Text = "Distancia";
            // 
            // lblTarifaViaje
            // 
            this.lblTarifaViaje.AutoSize = true;
            this.lblTarifaViaje.Location = new System.Drawing.Point(24, 115);
            this.lblTarifaViaje.Name = "lblTarifaViaje";
            this.lblTarifaViaje.Size = new System.Drawing.Size(60, 13);
            this.lblTarifaViaje.TabIndex = 2;
            this.lblTarifaViaje.Text = "Tarifa Viaje";
            // 
            // lblLugarDestino
            // 
            this.lblLugarDestino.AutoSize = true;
            this.lblLugarDestino.Location = new System.Drawing.Point(24, 167);
            this.lblLugarDestino.Name = "lblLugarDestino";
            this.lblLugarDestino.Size = new System.Drawing.Size(88, 13);
            this.lblLugarDestino.TabIndex = 3;
            this.lblLugarDestino.Text = "Lugar de Destino";
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.Location = new System.Drawing.Point(19, 53);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(85, 13);
            this.lblNombreServicio.TabIndex = 4;
            this.lblNombreServicio.Text = "Nombre Servicio";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(26, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(116, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(213, 19);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(306, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbxNombreServicio
            // 
            this.cbxNombreServicio.FormattingEnabled = true;
            this.cbxNombreServicio.Location = new System.Drawing.Point(110, 50);
            this.cbxNombreServicio.Name = "cbxNombreServicio";
            this.cbxNombreServicio.Size = new System.Drawing.Size(121, 21);
            this.cbxNombreServicio.TabIndex = 9;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(120, 86);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 12;
            // 
            // txtTarifaViaje
            // 
            this.txtTarifaViaje.Location = new System.Drawing.Point(120, 112);
            this.txtTarifaViaje.Name = "txtTarifaViaje";
            this.txtTarifaViaje.Size = new System.Drawing.Size(100, 20);
            this.txtTarifaViaje.TabIndex = 13;
            // 
            // txtLugarDestino
            // 
            this.txtLugarDestino.Location = new System.Drawing.Point(118, 164);
            this.txtLugarDestino.Name = "txtLugarDestino";
            this.txtLugarDestino.Size = new System.Drawing.Size(189, 20);
            this.txtLugarDestino.TabIndex = 14;
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Location = new System.Drawing.Point(45, 110);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(59, 13);
            this.lblTotalPago.TabIndex = 15;
            this.lblTotalPago.Text = "Total Pago";
            // 
            // lblIdTipoPago
            // 
            this.lblIdTipoPago.AutoSize = true;
            this.lblIdTipoPago.Location = new System.Drawing.Point(48, 80);
            this.lblIdTipoPago.Name = "lblIdTipoPago";
            this.lblIdTipoPago.Size = new System.Drawing.Size(56, 13);
            this.lblIdTipoPago.TabIndex = 16;
            this.lblIdTipoPago.Text = "Tipo Pago";
            // 
            // cbxTipoPago
            // 
            this.cbxTipoPago.FormattingEnabled = true;
            this.cbxTipoPago.Location = new System.Drawing.Point(109, 80);
            this.cbxTipoPago.Name = "cbxTipoPago";
            this.cbxTipoPago.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoPago.TabIndex = 17;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Location = new System.Drawing.Point(110, 107);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(121, 20);
            this.txtTotalPago.TabIndex = 18;
            // 
            // lblNombreConductor
            // 
            this.lblNombreConductor.AutoSize = true;
            this.lblNombreConductor.Location = new System.Drawing.Point(24, 65);
            this.lblNombreConductor.Name = "lblNombreConductor";
            this.lblNombreConductor.Size = new System.Drawing.Size(96, 13);
            this.lblNombreConductor.TabIndex = 19;
            this.lblNombreConductor.Text = "Nombre Conductor";
            // 
            // txtNombreConductor
            // 
            this.txtNombreConductor.Location = new System.Drawing.Point(120, 62);
            this.txtNombreConductor.Name = "txtNombreConductor";
            this.txtNombreConductor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreConductor.TabIndex = 20;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(396, 19);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 21;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID Viaje";
            // 
            // txtIdViaje
            // 
            this.txtIdViaje.Location = new System.Drawing.Point(120, 35);
            this.txtIdViaje.Name = "txtIdViaje";
            this.txtIdViaje.Size = new System.Drawing.Size(100, 20);
            this.txtIdViaje.TabIndex = 23;
            // 
            // dataGridViewViajePago
            // 
            this.dataGridViewViajePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViajePago.Location = new System.Drawing.Point(22, 269);
            this.dataGridViewViajePago.Name = "dataGridViewViajePago";
            this.dataGridViewViajePago.Size = new System.Drawing.Size(625, 150);
            this.dataGridViewViajePago.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(234, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombreServicio);
            this.groupBox1.Controls.Add(this.cbxNombreServicio);
            this.groupBox1.Controls.Add(this.lblTotalPago);
            this.groupBox1.Controls.Add(this.lblIdTipoPago);
            this.groupBox1.Controls.Add(this.cbxTipoPago);
            this.groupBox1.Controls.Add(this.txtTotalPago);
            this.groupBox1.Location = new System.Drawing.Point(372, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 215);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtLugarOrigen);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblDistancia);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.lblTarifaViaje);
            this.groupBox2.Controls.Add(this.lblLugarDestino);
            this.groupBox2.Controls.Add(this.txtIdViaje);
            this.groupBox2.Controls.Add(this.txtDistancia);
            this.groupBox2.Controls.Add(this.txtNombreConductor);
            this.groupBox2.Controls.Add(this.txtTarifaViaje);
            this.groupBox2.Controls.Add(this.lblNombreConductor);
            this.groupBox2.Controls.Add(this.txtLugarDestino);
            this.groupBox2.Location = new System.Drawing.Point(22, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 215);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Viaje";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Controls.Add(this.BtnLimpiar);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnListar);
            this.groupBox3.Location = new System.Drawing.Point(41, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 73);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conductorToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conductorToolStripMenuItem
            // 
            this.conductorToolStripMenuItem.Name = "conductorToolStripMenuItem";
            this.conductorToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.conductorToolStripMenuItem.Text = "Conductor";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.ayudaToolStripMenuItem.Text = "Salir";
            // 
            // txtLugarOrigen
            // 
            this.txtLugarOrigen.Location = new System.Drawing.Point(120, 138);
            this.txtLugarOrigen.Name = "txtLugarOrigen";
            this.txtLugarOrigen.Size = new System.Drawing.Size(189, 20);
            this.txtLugarOrigen.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Lugar de Origen";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(487, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MantenedorViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 535);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewViajePago);
            this.Name = "MantenedorViaje";
            this.Text = "Mantenedor Viaje";
            this.Load += new System.EventHandler(this.MantenedorViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViajePago)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblTarifaViaje;
        private System.Windows.Forms.Label lblLugarDestino;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbxNombreServicio;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtTarifaViaje;
        private System.Windows.Forms.TextBox txtLugarDestino;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label lblIdTipoPago;
        private System.Windows.Forms.ComboBox cbxTipoPago;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.Label lblNombreConductor;
        private System.Windows.Forms.TextBox txtNombreConductor;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdViaje;
        private System.Windows.Forms.DataGridView dataGridViewViajePago;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conductorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLugarOrigen;
        private System.Windows.Forms.Button btnSalir;
    }
}