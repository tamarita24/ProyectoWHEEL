using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public enum WSException
    {
        Success = 0,
        EmptyAttribute = 1,
        DataConecctionError = 2,
        GeneralError = 3,
        EmptyAutenticationParameter = 4
    }
}
