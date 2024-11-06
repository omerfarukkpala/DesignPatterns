using Microsoft.EntityFrameworkCore;
using RepositoryEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Product> Products { get; set; }
    }
}
