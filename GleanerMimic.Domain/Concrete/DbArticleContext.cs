using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using GleanerMimic.Domain.Entities;

 

namespace GleanerMimic.Domain.Concrete
{
    //derive from the Entity framework database context class
    //allow access to underline database in an abstract and efficient way
    public class DbArticleContext : DbContext        
    {
        public DbSet<Article> article { get; set; } //create Article property to access the Article Table   
        public DbSet<articleType> articleType { get; set; }
        public DbSet<MyUser> myUser { get; set; } 
    }
}
