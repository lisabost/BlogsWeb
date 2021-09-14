using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Blogs.Models
{
    public class Blog
    {
        //primary key
        public int BlogId { get; set; }

        public string Name { get; set; }

        //navigation property
        public ICollection<Post> Posts { get; set; }
    }
}