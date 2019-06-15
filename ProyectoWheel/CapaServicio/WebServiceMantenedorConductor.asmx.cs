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
        public ResponseTransaction insertarConductor(Conductor conductor)
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
            catch(Exception ex)
            {
                return new ResponseTransaction()
                {
                    Code = (int)WSException.EmptyAttribute,
                    Description = ex.Message
                };
            }
            

        }

    
        /*
        [WebMethod(Description = "eliminar los datos del conductor")]
        public void eliminiarConductor(Conductor conductor)
        {
            NegocioConductor auxNegocioConductor = new NegocioConductor();
            auxNegocioConductor.insertarConductor(conductor);
        }
        */
        /*
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
                    
                    //responseParameterConductor.Conductors = auxNegocio.insertarConductor(conductor);
                    List<Conductor> conductors = auxNegocio.insertarConductor(responseParameterConductor);
                    if (responseParameterConductor.Conductors. == null)
                    {
                        responseParameterConductor.ResponseTransaction = new ResponseTransaction()
                        {
                            Code = (int)WSException.Success,
                            Description = "Transacción exitosa"
                        };
                        return responseParameterConductor;
                    }
                    else
                    {
                        responseParameterConductor.ResponseTransaction = new ResponseTransaction()
                        {
                            Code = (int)WSException.Success,
                            Description = "Conductor ya Existe"
                        };
                    }
                }
                catch (Exception ex)
                {
                    responseParameterConductor.ResponseTransaction = new ResponseTransaction()
                    {
                        Code = (int)WSException.EmptyAttribute,
                        Description = ex.Message
                    };
                    return responseParameterConductor; 
                }
            }
            
        }*/

    }
}
