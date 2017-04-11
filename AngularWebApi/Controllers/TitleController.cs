using AngularWebApi;
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
        private FORUMEntities3 db = new FORUMEntities3();
        // GET api/Title/5
        public List<Models.Topic> Get(int CategoryId)
        {
            var topics = new List<Models.Topic>();
            using (var context = new FORUMEntities3())
            {
                if (context.Topics.Count() > 0)
                {
                    var xx = (from em in context.Topics
                              where em.CategoryId == CategoryId
                              select new { em.TopicId, em.Title, em.Description,em.Comments,em.Created }).ToList();
                    foreach (var Topic in xx)
                    {
                        var topic = new Models.Topic();
                        topic.CategoryId = CategoryId;
                        topic.TopicId = Topic.TopicId;
                        topic.TitleName=Topic.Title;
                        topic.Description = Topic.Description;
                        topic.CommentCount = Topic.Comments.Count();
                        topic.CreatedDate = Topic.Created;
                        topics.Add(topic);
                    }
                }
            }
            return topics;
        }

        // POST api/values
        public string Post(Models.Topic topic)
        {
            using (FORUMEntities3 context = new FORUMEntities3())
            {
                var _topic = new AngularWebApi.Topic();
                _topic.CategoryId = topic.CategoryId;
                _topic.Title = topic.TitleName;
                _topic.Description = topic.Description;
                _topic.Created = DateTime.Now;
                context.Topics.Add(_topic);
                context.SaveChanges();
            }
            return "Title added successfully";
        }

        // PUT api/values/5
        public string Put(Models.Topic topic)
        {
            using (FORUMEntities3 context = new FORUMEntities3())
            {
                var _topic = context.Topics.Single(t=>t.TopicId==topic.TopicId);
                _topic.Title = topic.TitleName;
                _topic.Description = topic.Description;
                context.SaveChanges();
            }
            return "Title added successfully";
        }

        // DELETE api/values/5
        public void Delete(int TopicId)
        {

        }
    }
}
