using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace P1.Controllers
{
    [RoutePrefix("api/client")]
    public class ClientController : ApiController
    {
 

            [HttpGet]
            [Route("all")]
        public HttpResponseMessage Get()
            {
                try
                {
                    var data = ClientService.Get();
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }
            }

            [HttpGet]
        [Route("get/{id}")]
        public HttpResponseMessage Get(int id)
            {
                try
                {
                    var data = ClientService.Get(id);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }
            }
            [HttpGet]
            [Route("api/client/{id}/payment")]
            public HttpResponseMessage GetWithPaymentDetails(int id)
            {
                try
                {
                    var data = ClientService.GetWithPaymentDetails(id);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }

            }
    
                [HttpPost]
                [Route("create")]
                public HttpResponseMessage  Create(ClientDTO obj)
                {
                    try
                    {
                        var data = ClientService.Add(obj);
                        return Request.CreateResponse(HttpStatusCode.OK, data);
                    }
                    catch (Exception ex)
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
                    }
                }
                [HttpPut]
                [Route("update")]
                public HttpResponseMessage Update(ClientDTO obj)
                {
                    try
                    {
                        var data = ClientService.Update(obj);
                        return Request.CreateResponse(HttpStatusCode.OK, data);
                    }
                    catch (Exception ex)
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
                    }
                }
                [HttpDelete]
                [Route("delete/{id}")]
                public HttpResponseMessage Delete(int id)
                {
                    try
                    {
                        var data = ClientService.Delete(id);
                        return Request.CreateResponse(HttpStatusCode.OK, data);
                    }
                    catch (Exception ex)
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
                    }

                }
    }
}
