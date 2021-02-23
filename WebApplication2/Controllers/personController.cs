 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BLL;
using DAL1;
namespace WebApplication2.Controllers
{
    [RoutePrefix("api/person")]
    public class personController : ApiController
    {
    
            
            [Route("GetAll")]
            [HttpGet]
            public IHttpActionResult Get()
            {
                return Ok(BLL.PersonBLL.GetAll());
            }

            [Route("Add")]
            public IHttpActionResult Post(Person u)
            {
                return Ok(BLL.PersonBLL.Post(u));
            }

            [Route("DeletePerson/{id}")]
            public IHttpActionResult Delete(int id)
            {
                return Ok(BLL.PersonBLL.Delete(id));
            }

            [Route("UpdatePerson")]
            public IHttpActionResult Put(Person u)
            {
                return Ok(BLL.PersonBLL.Put(u));
            }

            [Route("FindPerson/{pasword}/{userName}")]
            public IHttpActionResult Get(string pasword, string userName)
            {
                var x = BLL.PersonBLL.Get(pasword, userName);
            
                return Ok(x);
            }
        }
    }

