using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForumWebApi.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public int CategoryId { get; set; }
        public int TitleName { get; set; }
        public int Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}