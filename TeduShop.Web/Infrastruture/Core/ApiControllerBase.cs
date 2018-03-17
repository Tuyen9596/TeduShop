using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model;
using TeduShop.Service;

namespace TeduShop.Web.Infrastruture.Core
{
    public class ApiControllerBase : ApiController
    {
        public IErrorService _errorService;

        public ApiControllerBase(IErrorService errorService)
        {
            this._errorService = errorService;
        }

        public HttpResponseMessage CreateHttpResponse(HttpRequestMessage requestMessage, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage reponse = null;
            try
            {
                reponse = function.Invoke();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors.");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine($"-Property :\"{ve.PropertyName}\", Error :\"{ve.ErrorMessage}\"");
                    }
                }
                LogError(ex);
                reponse = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.InnerException.Message);
            }
            catch (DbUpdateException dbex)
            {
                LogError(dbex);
                reponse = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dbex.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                reponse = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return reponse;
        }

        public void LogError(Exception ex)
        {
            try
            {
                Error er = new Error();
                er.CreateDate = DateTime.Now;
                er.Message = ex.Message;
                er.StackTrace = ex.StackTrace;
                _errorService.Create(er);
                _errorService.Save();
            }
            catch { }
        }
    }
}