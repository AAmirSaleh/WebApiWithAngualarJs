﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIWithAngularJs.Models;

namespace WebAPIWithAngularJs.Controllers
{
    public class SubscribersController : ApiController
    {
        // GET: api/Subscribers
        private SibeeshPassionEntities myEntities = new SibeeshPassionEntities();
        public IEnumerable<tbl_Subscribers> Get()
        {
            return myEntities.tbl_Subscribers.AsEnumerable();
        }

        // GET: api/Subscribers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Subscribers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Subscribers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Subscribers/5
        public void Delete(int id)
        {
        }
    }
}

