using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class NegocioConductor
    {
        private ConexionSQL conec1;

        public ConexionSQL Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.Conec1 = new ConexionSQL();
            this.Conec1.NombreBaseDatos = "Conductor";
            this.Conec1.NombreTabla = "Cliente";
            this.Conec1.CadenaConexion = "Data Source=TAMY-PC\\SQLEXPRESS;Initial Catalog=Prueba;Integrated Security=True";

        }

        public void insertarConductor(Conductor conductor)
        {
            this.configurarConexion();
            this.Conec1.CadenaConexion = "INSERT INTO " + this.Conec1.NombreTabla
                                    + " (rut,nombres,apellido_paterno,apellido_materno,sexo,telefono) VALUES ('"
                                    + conductor.Rut + "','" + conductor.Nombres + "','" + conductor.Apellido_materno + "','" + conductor.Sexo + "',' + conductor.Telefono + ');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }
        
        public void eliminarConductor(string rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM " + this.Conec1.NombreTabla
                                    + " where rut = " + rut + "';";
        }

        public void actualizarConductor(Conductor conductor)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE " + this.Conec1.NombreTabla
                                    + " SET"
                                    + " nombres = '" + conductor.Nombres  
                                    + "' apellido_paterno = '" + conductor.Apellido_paterno 
                                    + "' apellido_materno = '" + conductor.Apellido_materno 
                                    + "' sexo = '" + conductor.Sexo 
                                    + "' telefono = '" + conductor.Telefono 
                                    + "' WHERE rut = '" + conductor.Rut + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();
        }

        public Conductor buscarConductor(String rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla
                                    + " WHERE rut = '" + rut + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            Conductor auxConductor = new Conductor();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxConductor.Rut = (String)dt.Rows[0]["rut"];
                auxConductor.Nombres = (String)dt.Rows[0]["nombres"];
                auxConductor.Apellido_paterno = (String)dt.Rows[0]["apellido_paterno"];
                auxConductor.Apellido_materno = (String)dt.Rows[0]["apellido_materno"];
                auxConductor.Sexo = (String)dt.Rows[0]["sexo"];
                auxConductor.Telefono = (Int32)dt.Rows[0]["telefono"];
            }
            catch (Exception ex)
            {
                auxConductor.Rut = "";
                auxConductor.Nombres = "";
                auxConductor.Apellido_materno = "";
                auxConductor.Apellido_paterno = "";
                auxConductor.Sexo = "";
                auxConductor.Telefono = 0;

            }
            return auxConductor;

        }

        public DataSet retornaConductor()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla;

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            return this.Conec1.DbDataSet;
        }


    }
}
