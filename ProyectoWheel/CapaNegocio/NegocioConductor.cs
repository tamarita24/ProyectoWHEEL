using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaNegocio
{
    public class NegocioConductor
    {
        private ConexionSQL conec1;

        public ConexionSQL Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.Conec1 = new ConexionSQL();
            this.Conec1.NombreBaseDatos = "WHEEL";
            this.Conec1.NombreTabla = "Conductor";
            //this.Conec1.CadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=WHEEL;Integrated Security=True";
            this.Conec1.CadenaConexion = ConfigurationManager.AppSettings["BD"];
        }//Fin configurar Conexion

        

        public void insertarConductor(Conductor conductor)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO " + this.Conec1.NombreTabla
                                    + " (rut,nombres,apellido_paterno,apellido_materno,sexo,telefono) VALUES ('"
                                    + conductor.Rut + "','" + conductor.Nombres + "','" + conductor.Apellido_paterno + "','" + conductor.Apellido_materno + "','" + conductor.Sexo + "', '" + conductor.Telefono + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }//Fin agregar conductor

        public void eliminarConductor(String rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM " + this.Conec1.NombreTabla
                                    + " WHERE rut = '" + rut + "';";
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
        }//Fin actualizar conductor

        public Conductor buscarConductor(String rut)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla
                                    + " WHERE rut = '" + rut + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            Conductor auxConductor1 = new Conductor();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxConductor1.Rut = (String)dt.Rows[0]["rut"];
                auxConductor1.Nombres = (String)dt.Rows[0]["nombres"];

                auxConductor1.Apellido_paterno = (String)dt.Rows[0]["apellido_paterno"];
                auxConductor1.Apellido_materno = (String)dt.Rows[0]["apellido_materno"];
                auxConductor1.Sexo = (String)dt.Rows[0]["sexo"];
                auxConductor1.Telefono = (Int32)dt.Rows[0]["telefono"];
                
            }
            catch (Exception ex)
            {
                
                auxConductor1.Rut = "";
                auxConductor1.Nombres = "";
                auxConductor1.Apellido_paterno = "";
                auxConductor1.Apellido_materno = "";
                
                //auxConductor1.Sexo = "Femenino" ;
                auxConductor1.Telefono = 0;

            }
            return auxConductor1;
        }

        public DataSet retornaConductor()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla;

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            return this.Conec1.DbDataSet;
        }//Fin retorna conductor

        public Conductor insertarConductor(FilterConductor filterConductor)
        {
            throw new NotImplementedException();
        }
    }//fin
}
