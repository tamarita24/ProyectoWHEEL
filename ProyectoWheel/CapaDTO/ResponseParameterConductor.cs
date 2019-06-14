using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class ResponseParameterConductor
    {
        public List<Conductor> Conductors { get; set; }
        public ResponseTransaction ResponseTransaction { get; set; }
    }
}
