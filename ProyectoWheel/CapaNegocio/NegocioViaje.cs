using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioViaje
    {
        private ConexionSQL conec1;

        public ConexionSQL Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.Conec1 = new ConexionSQL();
            this.Conec1.NombreBaseDatos = "WHEEL";
            this.Conec1.NombreTabla = "Viaje";
            //this.Conec1.CadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=WHEEL;Integrated Security=True";
            this.Conec1.CadenaConexion = ConfigurationManager.AppSettings["BD"];
        }//Fin configurar Conexion



        public void insertarViaje(Viaje viaje)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO " + this.Conec1.NombreTabla
                                    + " (id_viaje,fecha_viaje,distancia,tarifa_viaje,nombre_servicio,rut,lugar_destino,lugar_origen,id_pago) VALUES ('"
                                    + viaje.Id_viaje + "','" + viaje.Fecha_viaje + "','" + viaje.Distancia + "','" + viaje.Tarifa_viaje + "','" + viaje.Nombre_servicio + "', '" + viaje.Rut + "', '" + viaje.Lugar_destino + "', '" + viaje.Lugar_origen + "', '" + viaje.Id_pago + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }//Fin agregar conductor

        public void eliminarViaje(int id_viaje)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM " + this.Conec1.NombreTabla
                                    + " WHERE id_viaje = '" + id_viaje + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();
        }

        public void actualizarViaje(Viaje viaje)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE " + this.Conec1.NombreTabla
                                    + " SET"
                                    + " fecha_viaje = '" + viaje.Fecha_viaje
                                    + "' ,distancia = '" + viaje.Distancia
                                    + "' ,tarifa_viaje = '" + viaje.Tarifa_viaje
                                    + "' ,nombre_servicio = '" + viaje.Nombre_servicio
                                    + "' ,rut = '" + viaje.Rut
                                    + "' ,lugar_destino = '" + viaje.Lugar_destino
                                    + "' ,lugar_origen = '" + viaje.Lugar_origen
                                    + "' ,id_pago = '" + viaje.Id_pago
                                    + "' WHERE id_viaje = '" + viaje.Id_viaje + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();
        }//Fin actualizar conductor

        public Viaje buscarViaje(int id_viaje)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla
                                    + " WHERE id_viaje = '" + id_viaje + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            Viaje auxViaje = new Viaje();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxViaje.Id_viaje = (Int32)dt.Rows[0]["id_viaje"];
                auxViaje.Fecha_viaje = (DateTime)dt.Rows[0]["fecha_viaje"];

                auxViaje.Distancia = (Int32)dt.Rows[0]["distancia"];
                auxViaje.Tarifa_viaje = (Int32)dt.Rows[0]["tarifa_viaje"];
                auxViaje.Nombre_servicio = (string)dt.Rows[0]["id_servicio"];
                auxViaje.Rut = (String)dt.Rows[0]["rut"];
                auxViaje.Lugar_destino = (String)dt.Rows[0]["lugar_destino"];
                auxViaje.Lugar_origen = (String)dt.Rows[0]["lugar_origen"];
                auxViaje.Id_pago = (Int32)dt.Rows[0]["id_pago"];

            }
            catch (Exception ex)
            {

                auxViaje.Id_viaje = 0;
               // auxViaje.Fecha_viaje = ;
                auxViaje.Distancia = 0;
                auxViaje.Tarifa_viaje = 0;

                auxViaje.Nombre_servicio = "";
                auxViaje.Rut = "";
                auxViaje.Lugar_destino = "";
                auxViaje.Lugar_origen = "";
                auxViaje.Id_pago = 0;

            }
            return auxViaje;
        }

        public DataSet retornaViajePago()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT C.*, P.* FROM Viaje C FULL OUTER JOIN PAGO P ON C.Id_pago = p.Id_pago";

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            return this.Conec1.DbDataSet;
        }//Fin retorna viaje
    }
}
