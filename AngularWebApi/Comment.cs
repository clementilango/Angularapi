//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularWebApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int TopicId { get; set; }
        public string Text { get; set; }
        public string CommentedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        public virtual Topic Topic { get; set; }
    }
}
