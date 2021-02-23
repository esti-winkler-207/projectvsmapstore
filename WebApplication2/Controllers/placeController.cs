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
    [RoutePrefix("api/place")]
    public class placeController : ApiController
    {
        
        [Route("GetAll")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(PlaceBLL.GetAll());
        }


        [Route("Add")]
        public IHttpActionResult Post(Place u)
        {
            return Ok(BLL.PlaceBLL.Post(u));
        }

        [Route("DeletePlace/{id}")]
        public IHttpActionResult Delete(int id)
        {
            return Ok(BLL.PlaceBLL.Delete(id));
        }

        [Route("UpdatePlace")]
        public IHttpActionResult Put(Place u)
        {
            return Ok(BLL.PlaceBLL.Put(u));
        }

        [Route("FindPlace/{id}/{name}")]
        public IHttpActionResult Get(int id, string name)
        {
            var x = BLL.PlaceBLL.Get(id, name);
            return Ok(x);
        }
    }
}
