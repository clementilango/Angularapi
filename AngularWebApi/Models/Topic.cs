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
        public string TitleName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CommentCount { get; set; }
    }
}