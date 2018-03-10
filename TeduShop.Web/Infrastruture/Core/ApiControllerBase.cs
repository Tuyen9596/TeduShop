using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model;
namespace TeduShop.Web.Infrastruture.Core
{
    public class ApiControllerBase : ApiController
    {
        TeduShop.Model.Error er = new Error();
        private void LogError(Exception ex)
        {
           
            try {
                Error er = new Error();
                er.CreateDate = DateTime.Now;
                er.Message = ex.Message;
                er.StackTrace = ex.StackTrace;
            }
            catch { }

        }
    }
}
