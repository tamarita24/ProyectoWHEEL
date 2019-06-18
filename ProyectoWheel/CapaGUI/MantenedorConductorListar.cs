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
    public partial class MantenedorConductorListar : Form
    {
        public MantenedorConductorListar()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ServiceConductor.WebServiceMantenedorConductorSoapClient auxServiceConductor = new ServiceConductor.WebServiceMantenedorConductorSoapClient();
            
            this.dgvListarConductor.DataSource = auxServiceConductor.retornaConductorService();
            this.dgvListarConductor.DataMember = "Conductor";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
