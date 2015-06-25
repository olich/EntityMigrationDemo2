﻿using System.Data.Entity; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.Data.Entity.Infrastructure; 
 
namespace Migration2 
{ 
    public class BlogContext : DbContext 
    { 
        public DbSet<Blog> Blogs { get; set; } 
    } 
 
    public class Blog 
    { 
        public int BlogId { get; set; } 
        public string Name { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        public string Content { get; set; }

        // need blogId and Blog to make the relation (foreign key)
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public string Abstract { get; set; }
    }
}