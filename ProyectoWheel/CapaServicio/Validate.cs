
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CapaDTO;

namespace CapaServicio
{
    public class Validate
    {

        public static ResponseTransaction ValidateRequest(RequestParameterConductor requestParameter)
    {
        if (requestParameter.Autentication == null)
        {
            return new ResponseTransaction()
            {
                Code = (int) WSException.EmptyAutenticationParameter,
                Description = "Debe ingresar los parámetros de autentificación"
            };
        }
        else if (requestParameter.FilterConductor.Nombres == null || requestParameter.FilterConductor.Nombres == string.Empty)
        {
            return new CapaDTO.ResponseTransaction()
            {
                Code = (int)WSException.EmptyAttribute,
                Description = "Debe ingresar el nombre de la persona"
            };
        }
        return new ResponseTransaction();

        }
    }
}