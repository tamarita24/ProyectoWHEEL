using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Windows.Forms;
using CapaDTO;
using CapaNegocio;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceMantenedorViaje
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorViaje : System.Web.Services.WebService
    {

        [WebMethod(Description = "insertar un viaje")]
        public void insertarViajeService(Viaje viaje)
        {
            try
            {

                NegocioViaje auxNegocioViaje = new NegocioViaje();
                auxNegocioViaje.insertarViaje(viaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Sistema");
            }

        }



        [WebMethod(Description = "eliminar los datos viaje")]
        public void eliminiarViajeService(int id_viaje)
        {
            try
            {

                NegocioViaje auxNegocioViaje = new NegocioViaje();
                auxNegocioViaje.eliminarViaje(id_viaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Sistema");
            }


        }




        [WebMethod(Description = "Actualiza los datos viaje")]
        public void actualizarViajeService(Viaje viaje)
        {
            try
            {
                NegocioViaje auxNegocioViaje = new NegocioViaje();
                auxNegocioViaje.actualizarViaje(viaje);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Sistema");
            }


        }

        [WebMethod(Description = "buscar un viaje")]
        public Viaje buscarViajeService(int id_viaje)
        {

            NegocioViaje auxNegocioViaje = new NegocioViaje();
            return auxNegocioViaje.buscarViaje(id_viaje);

        }


        [WebMethod(Description = "Retorna un viaje")]
        public DataSet retornaViajerService()
        {

            NegocioViaje auxNegocioViaje = new NegocioViaje();
            return auxNegocioViaje.retornaViajePago();

        }

        
    }
}
