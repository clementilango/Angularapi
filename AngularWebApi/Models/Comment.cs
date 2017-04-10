using System;

namespace ForumWebApi.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int TopicId { get; set; }
        public string Text { get; set; }
        public string CommentedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}