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
    public class NegocioPago
    {
        private ConexionSQL conec1;

        public ConexionSQL Conec1 { get => conec1; set => conec1 = value; }

        public void configurarConexion()
        {
            this.Conec1 = new ConexionSQL();
            this.Conec1.NombreBaseDatos = "WHEEL";
            this.Conec1.NombreTabla = "Pago";
            //this.Conec1.CadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=WHEEL;Integrated Security=True";
            this.Conec1.CadenaConexion = ConfigurationManager.AppSettings["BD"];
        }//Fin configurar Conexion



        public void insertarPago(Pago pago)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "INSERT INTO " + this.Conec1.NombreTabla
                                    + " (id_pago,fecha_pago,total_pago,id_tipopago) VALUES ('"
                                    + pago.Id_pago + "','" + pago.Fecha_pago + "','" + pago.Total_pago + "','" + pago.Id_tipopago + "');";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();

        }//Fin agregar conductor

        public void eliminarPago(int id_pago)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "DELETE FROM " + this.Conec1.NombreTabla
                                    + " WHERE id_pago = '" + id_pago + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();
        }

        public void actualizarPago(Pago pago)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "UPDATE " + this.Conec1.NombreTabla
                                    + " SET"
                                    + " fecha_pago = '" + pago.Fecha_pago
                                    + "' ,total_pago = '" + pago.Total_pago
                                    + "' ,id_tipopago = '" + pago.Id_tipopago
                                    + "' WHERE id_pago = '" + pago.Id_pago + "';";
            this.Conec1.EsSelect = false;
            this.Conec1.conectar();
        }//Fin actualizar conductor

        public Pago buscarPago(DateTime fecha_pago)
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla
                                    + " WHERE fecha_pago = '" + fecha_pago + "';";
            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            Pago auxPago = new Pago();
            DataTable dt = new DataTable();
            dt = this.Conec1.DbDataSet.Tables[this.Conec1.NombreTabla];

            try
            {
                auxPago.Id_pago = (Int32)dt.Rows[0]["id_pago"];
                auxPago.Fecha_pago = (DateTime)dt.Rows[0]["fecha_pago"];

                auxPago.Total_pago = (Int32)dt.Rows[0]["total_pago"];
                auxPago.Id_tipopago = (Int32)dt.Rows[0]["id_tipopago"];
               
            }
            catch (Exception ex)
            {

                auxPago.Id_pago = 0;
                //auxPago.Fecha_pago = "";
                auxPago.Total_pago = 0;
                auxPago.Id_tipopago = 0;

              

            }
            return auxPago;
        }

        public DataSet retornaPago()
        {
            this.configurarConexion();
            this.Conec1.CadenaSQL = "SELECT * FROM " + this.Conec1.NombreTabla;

            this.Conec1.EsSelect = true;
            this.Conec1.conectar();
            return this.Conec1.DbDataSet;
        }//Fin retorna pago
    }
}
