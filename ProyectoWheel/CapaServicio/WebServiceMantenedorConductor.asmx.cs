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

        
        [WebMethod(Description = "insertar un conductor")]
        public ResponseTransaction insertarConductorService(Conductor conductor)
        {
            try
            {
                NegocioConductor auxNegocioConductor = new NegocioConductor();
                auxNegocioConductor.insertarConductor(conductor);
                return new ResponseTransaction()
                {
                    Code = (int)WSException.Success,
                    Description = "Transacción exitosa"
                };
            }
            catch (Exception ex)
            {
                return new ResponseTransaction()
                {
                    Code = (int)WSException.GeneralError,
                    Description = string.Format("{0}-{1}", "Excepción General", ex.Message)
                };
            }
            
        }

        
        
        [WebMethod(Description = "eliminar los datos del conductor")]
        public ResponseTransaction eliminiarConductorService(string rut)
        {
            try
            {
                NegocioConductor auxNegocioConductor = new NegocioConductor();
                auxNegocioConductor.eliminarConductor(rut);
                return new ResponseTransaction()
                {
                    Code = (int)WSException.Success,
                    Description = "Transacción exitosa"
                };
            }
            catch (Exception ex)
            {
                return new ResponseTransaction()
                {
                    Code = (int)WSException.GeneralError,
                    Description = string.Format("{0}-{1}", "Excepción General", ex.Message)
                };
            }


        }

      
       
        
        [WebMethod(Description = "Actualiza los datos del conductor")]
        public ResponseTransaction actualizarConductorService(Conductor conductor)
        {
            try
            {
                NegocioConductor auxNegocioConductor = new NegocioConductor();
                auxNegocioConductor.actualizarConductor(conductor);
                return new ResponseTransaction()
                {
                    Code = (int)WSException.Success,
                    Description = "Transacción exitosa"
                };
            }
            catch (Exception ex)
            {
                return new ResponseTransaction()
                {
                    Code = (int)WSException.GeneralError,
                    Description = string.Format("{0}-{1}", "Excepción General", ex.Message)
                };
            }


        }

        [WebMethod(Description = "buscar un conductor")]
        public Conductor buscarConductorService(String rut)
        {
            
            NegocioConductor auxNegocioConductor = new NegocioConductor();
            return auxNegocioConductor.buscarConductor(rut);

        }

        
        [WebMethod(Description = "Retorna un conductor")]
        public DataSet retornaConductorService()
        {
            
                NegocioConductor auxNegocioConductor = new NegocioConductor();
                return auxNegocioConductor.retornaConductor();
              
        }


        
        /*
        [WebMethod(Description = "inserta los datos de un conductor")]
        public ResponseParameterConductor insertarConductor(RequestParameterConductor requestParameterConductor)
        {
            ResponseParameterConductor responseParameterConductor = new ResponseParameterConductor();
            responseParameterConductor.ResponseTransaction = Validate.ValidateRequest(requestParameterConductor);
            if (responseParameterConductor.ResponseTransaction.Code !=0)
            {

                return responseParameterConductor;
            }
            else
            {
                try
                {
                    NegocioConductor auxNegocio = new NegocioConductor();

                    //responseParameterConductor.Conductors = auxNegocio.insertarConductor(requestParameterConductor.FilterConductor);
                    List<CapaDTO.Conductor> conductors = auxNegocio.insertarConductor(requestParameterConductor.FilterConductor);
                    responseParameterConductor.ResponseTransaction = conductors;
                    
                    responseParameterConductor.ResponseTransaction = new ResponseTransaction()
                    {
                        Code = (int)WSException.Success,
                        Description = "Transacción exitosa"
                    };
                    return responseParameterConductor;

                }
                catch (Exception ex)
                {
                    responseParameterConductor.ResponseTransaction = new ResponseTransaction()
                    {
                        Code = (int)WSException.GeneralError,
                        Description = string.Format("{0}-{1}", "Excepción General", ex.Message)
                    };
                    return responseParameterConductor;
                }
            }

        }*/

    }
}
