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
    [RoutePrefix("api/prop")]

    public class propController: ApiController
    {
        [Route("GetAll")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(propBLL.GetAll());
        }

        [Route("Add")]
        public IHttpActionResult Post(prop u)
        {
            return Ok(BLL.propBLL.Post(u));
        }

        [Route("DeleteProp/{id}")]
        public IHttpActionResult Delete(int id)
        {
            return Ok(BLL.propBLL.Delete(id));
        }

        [Route("UpdatePerson")]
        public IHttpActionResult Put(DAL1.prop u)
        {
            return Ok(BLL.propBLL.Put(u));
        }

        [Route("FindPerson/{pasword}/{userName}")]
        public IHttpActionResult Get(string pasword, string userName)
        {
            var x = BLL.PersonBLL.Get(pasword, userName);
            return Ok(x);
        }
    }
}