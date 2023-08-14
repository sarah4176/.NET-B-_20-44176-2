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
    public class PaymentController : ApiController
    {
      
            [HttpGet]
            [Route("all")]
            public HttpResponseMessage Get()
            {
                try
                {
                    var data = PaymentService.Get();
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
                    var data = PaymentService.Get(id);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception e)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
                }
            }
            
            [HttpPost]
            [Route("create")]
            public HttpResponseMessage Create(PaymentDTO obj)
            {
                try
                {
                    var data = PaymentService.Add(obj);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
                }
            }
            [HttpPut]
            [Route("update")]
            public HttpResponseMessage Update(PaymentDTO obj)
            {
                try
                {
                    var data = PaymentService.Update(obj);
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
                    var data = PaymentService.Delete(id);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
                }

            }
        }
    }
