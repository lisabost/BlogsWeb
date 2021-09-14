using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Blogs.Models
{
    public class Post
    {
        //primary key
        public int PostId { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }

        //foreign key
        public int BlogId { get; set; }
        //navigation property
        public Blog Blog { get; set; }
    }
}