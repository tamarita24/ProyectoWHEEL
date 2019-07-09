using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaDTO;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceMantenedorPago
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorPago : System.Web.Services.WebService
    {

        [WebMethod(Description = "insertar un pago")]
        public void insertarPagoService(Pago pago)
        {
            try
            {
                NegocioPago auxNegocioPago = new NegocioPago();
                auxNegocioPago.insertarPago(pago);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Sistema");
            }

        }



        [WebMethod(Description = "eliminar los datos de un pago")]
        public void eliminiarPagoService(int id_pago)
        {
            try
            {
                NegocioPago auxNegocioPago = new NegocioPago();
                auxNegocioPago.eliminarPago(id_pago);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Sistema");
            }


        }




        [WebMethod(Description = "Actualiza los datos del pago")]
        public void actualizarPagoService(Pago pago)
        {
            try
            {
                NegocioPago auxNegocioPago = new NegocioPago();
                auxNegocioPago.insertarPago(pago);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Sistema");
            }


        }

        [WebMethod(Description = "buscar un pago")]
        public Pago buscarPagoService(DateTime fecha_pago)
        {

            NegocioPago auxNegocioPago = new NegocioPago();
            return auxNegocioPago.buscarPago(fecha_pago);

        }


        [WebMethod(Description = "Retorna un pago")]
        public DataSet retornaPagoService()
        {

            NegocioPago auxNegocioPago = new NegocioPago();
            return auxNegocioPago.retornaPago();

        }

       
    }
}
