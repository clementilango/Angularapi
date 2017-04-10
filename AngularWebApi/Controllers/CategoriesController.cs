using AngularWebApi;
using ForumWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ForumWebApi.Controllers
{
    //[Authorize]
    public class CategoriesController : ApiController
    {

        FORUMEntities1 db = new FORUMEntities1();
        // GET api/values
        public List<Models.Category> Get()
        {
            var categories = new List<Models.Category>();
            using (var context = new FORUMEntities1())
            {
                if (context.Categories.Count() > 0)
                {
                    var xx = (from em in context.Categories
                              select new { em.CategoryId, em.CategoryName, em.Description }).ToList();
                    foreach (var category in xx)
                    {
                        var cat = new Models.Category();
                        cat.CategoryId = category.CategoryId;
                        cat.CategoryName = category.CategoryName;
                        cat.Description = category.Description;
                        categories.Add(cat);
                    }
                }
            }               
            return categories;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post(Models.Category category)
        {
            using (FORUMEntities1 context = new FORUMEntities1())
            {
                var cat = new AngularWebApi.Category();
                cat.CategoryId = category.CategoryId;
                cat.CategoryName = category.CategoryName;
                cat.Description = category.Description;
                context.Categories.Add(cat);
                context.SaveChanges();
            }
            return "Category added successfully";
        }    

        
    }
}
