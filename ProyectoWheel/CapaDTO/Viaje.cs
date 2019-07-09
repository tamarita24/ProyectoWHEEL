using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Viaje
    {
        private int id_viaje;
        private DateTime fecha_viaje;
        private int distancia;
        private int tarifa_viaje;
        private string nombre_servicio;
        private string rut;
        private string lugar_destino;
        private string lugar_origen;
        private int id_pago;

        public int Id_viaje { get => id_viaje; set => id_viaje = value; }
        public DateTime Fecha_viaje { get => fecha_viaje; set => fecha_viaje = value; }
        public int Distancia { get => distancia; set => distancia = value; }
        public int Tarifa_viaje { get => tarifa_viaje; set => tarifa_viaje = value; }
        public string Nombre_servicio { get => nombre_servicio; set => nombre_servicio = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Lugar_destino { get => lugar_destino; set => lugar_destino = value; }
        public string Lugar_origen { get => lugar_origen; set => lugar_origen = value; }
        public int Id_pago { get => id_pago; set => id_pago = value; }
    }
}
