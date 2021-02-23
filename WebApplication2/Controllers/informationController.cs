using DAL1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DTO;

namespace WebApplication2.Controllers
   
{
    [RoutePrefix("api/information")]
    public class informationController : ApiController
           {
             
        [Route("GetAll")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(BLL.informationBLL.GetAll());
        }

        [Route("Add")]
        public IHttpActionResult Post(information u)
        {
            return Ok(BLL.informationBLL.Post(u));
        }

        [Route("DeleteInformation/{id}")]
        public IHttpActionResult Delete(int id)
        {
            return Ok(BLL.informationBLL.Delete(id));
        }

        [Route("UpdateUseInformation")]
        public IHttpActionResult Put(information u)
        {
            return Ok(BLL.informationBLL.Put(u));
        }

        //[Route("FindUser/{pasword}/{userName}")]
        ////עדין לא מקושר לפונקציה 
        //public IHttpActionResult Get(string pasword, string userName)
        //{
        //    var x = BLL.informationBLL.GetAll(pasword, userName);
        //    return Ok(x);
        //}
    }
}

