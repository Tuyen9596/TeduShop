using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeduShop.Model;
using TeduShop.Service;
using TeduShop.Web.Infrastruture.Core;

namespace TeduShop.Web.API
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        
        public PostCategoryController(IErrorService errorService,IPostCategoryService postCategoryService)
            :base(errorService)
        {
            this._postCategoryService = postCategoryService;
        }
        public HttpResponseMessage Create(HttpRequestMessage msge,PostCategorie postcategory)
        {
            return CreateHttpResponse(msge,()=> {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    msge.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                } else
                {
                   var category= _postCategoryService.Add(postcategory);
                    _postCategoryService.Save();
                    reponse = msge.CreateResponse(HttpStatusCode.Created, category);
                }
                return reponse;
            });
        }
        public HttpResponseMessage Update(HttpRequestMessage msge, PostCategorie postcategory)
        {
            return CreateHttpResponse(msge, () =>
            {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    msge.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                  _postCategoryService.Add(postcategory);
                    _postCategoryService.Save();
                    reponse = msge.CreateResponse(HttpStatusCode.OK);
                }
                return reponse;
            });
        }
        public HttpResponseMessage Post(HttpRequestMessage msge, PostCategorie postcategory)
        {
            return CreateHttpResponse(msge, () =>
            {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    msge.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var category = _postCategoryService.Add(postcategory);
                    _postCategoryService.Save();
                    reponse = msge.CreateResponse(HttpStatusCode.Created, category);
                }
                return reponse;
            });
        }
        public HttpResponseMessage Put(HttpRequestMessage msge, PostCategorie postcategory)
        {
            return CreateHttpResponse(msge, () =>
            {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    msge.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var category = _postCategoryService.Add(postcategory);
                    _postCategoryService.Save();
                    reponse = msge.CreateResponse(HttpStatusCode.Created, category);
                }
                return reponse;
            });
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage msge)
        {
            return CreateHttpResponse(msge, () =>
            {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    msge.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var listCategory=_postCategoryService.GetAll();
                    reponse = msge.CreateResponse(HttpStatusCode.OK, listCategory);
                }
                return reponse;
            });
        }
        public HttpResponseMessage Delete(HttpRequestMessage msge, int id)
        {
            return CreateHttpResponse(msge, () =>
            {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    msge.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.Save();
                    reponse = msge.CreateResponse(HttpStatusCode.OK);
                }
                return reponse;
            });
        }
    }
}