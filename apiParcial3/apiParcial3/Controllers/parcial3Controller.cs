using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using apiParcial3.Models;
using apiParcial3.Clases;

namespace apiParcial3.Controllers
{
    [EnableCors(origins: "http://localhost:62824", headers:"*",methods:"*")]
    public class parcial3Controller : ApiController
    {
        
        // POST api/values
        public clsModP3 Post([FromBody] clsModP3 objmodP3)
        {
            clsOpeP3 opeP3 = new clsOpeP3();
            opeP3.objModP3 = objmodP3;
            opeP3.HallarPago();
            return opeP3.objModP3;

        }

        
    }
}
