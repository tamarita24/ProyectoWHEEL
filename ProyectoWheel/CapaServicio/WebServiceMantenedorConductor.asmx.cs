using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaDTO;
using CapaNegocio;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebServiceMantenedorConductor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMantenedorConductor : System.Web.Services.WebService
    {
        /*
        [WebMethod(Description = "inserta los datos de un conductor")]
        public void insertarConductor(Conductor conductor)
        {
            NegocioConductor auxNegocioConductor = new NegocioConductor();
             auxNegocioConductor.insertarConductor(conductor);
        }

        [WebMethod(Description = "eliminar los datos del conductor")]
        public void eliminiarConductor(Conducto conductor)
        {
            NegocioConductor auxNegocioConductor = new NegocioConductor();
            auxNegocioConductor.insertarConductor(conductor);
        }

        [WebMethod(Description = "Actualiza los datos del conductor")]
        public void actualizarConductor(Conducto conductor)
        {
            NegocioConductor auxNegocioConductor = new NegocioConductor();
            auxNegocioConductor.insertarConductor(conductor);
        }

        [WebMethod(Description = "busca un conductor")]
        public Conducto buscarConductor(String rut)
        {
            NegocioConductor auxNegocioConductor = new NegocioConductor();
            return auxNegocioConductor.buscarConductor(rut);
        }

        [WebMethod(Description = "Retorna un conductor")]
        public DataSet retornaConductor()
        {
            NegocioConductor auxNegocioConductor = new NegocioConductor();
            return auxNegocioConductor.retornaConductor();
        }*/
    }
}
