using ForumWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ForumWebApi.Controllers
{
    public class TitleController : ApiController
    {
        public List<Topic> Get()
        {
            var Title = new List<Topic>();
            return Title;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post(Topic title)
        {
            return "Title added successfully";
        }

        // PUT api/values/5
        public void Put(Topic title)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
