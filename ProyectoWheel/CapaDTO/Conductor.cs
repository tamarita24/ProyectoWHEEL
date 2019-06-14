using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Conductor
    {
        private String rut;
        private String nombres;
        private String apellido_paterno;
        private String apellido_materno;
        private String sexo;
        private int telefono;
        

        public string Rut { get => rut; set => rut = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        
    }
}
