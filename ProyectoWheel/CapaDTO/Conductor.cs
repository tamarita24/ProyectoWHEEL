using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Conductor : IPersistentBase
    {
       
        public override bool IsEqual(IPersistentBase p)
        {
            throw new NotImplementedException();
        }

        private string rut;

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string apellido_paterno;

        public string Apellido_paterno
        {
            get { return apellido_paterno; }
            set { apellido_paterno = value; }
        }

        private string apellido_materno;

        public string Apellido_materno
        {
            get { return apellido_materno; }
            set { apellido_materno = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        /*
        protected string rut;
        protected string nombres;
        protected string apellido_paterno;
        protected string apellido_materno;
        protected string sexo;
        protected int telefono;
        */
    }


    public class FilterConductor : IPersistentBase
    {


        public override bool IsEqual(IPersistentBase p)
        {
            throw new NotImplementedException();
        }

        public string rut
        {
            get { return rut; }
            set { rut = value; }
        }

        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string apellido_paterno;

        public string Apellido_paterno
        {
            get { return apellido_paterno; }
            set { apellido_paterno = value; }
        }

        private string apellido_materno;

        public string Apellido_materno
        {
            get { return apellido_materno; }
            set { apellido_materno = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        /*
        protected string rut;
        protected string nombres;
        protected string apellido_paterno;
        protected string apellido_materno;
        protected string sexo;
        protected int telefono;
        */
    }

}
