using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Pago
    {
        private int id_pago;
        private DateTime fecha_pago;
        private int total_pago;
        private string nombre_tipopago;

        public int Id_pago { get => id_pago; set => id_pago = value; }
        public DateTime Fecha_pago { get => fecha_pago; set => fecha_pago = value; }
        public int Total_pago { get => total_pago; set => total_pago = value; }
        public string Nombre_tipopago { get => Nombre_tipopago; set => Nombre_tipopago = value; }
    }
}
