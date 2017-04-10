using ForumWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ForumWebApi.Controllers
{
    public class CommentController : ApiController
    {
        public List<Comment> Get()
        {
            var Comments = new List<Comment>();
            return Comments;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post(Comment Comments)
        {
            return "Comments added successfully";
        }

        // PUT api/values/5
        public void Put(Comment Comments)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
