using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ProgramCatalog.Infrastructure.Data.Model;

namespace ProgramCatalog.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : 
            base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
