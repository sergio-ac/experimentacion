using System;
using System.Collections.Generic;
using System.Text;
using ArathsBaby.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using plataforma_web.Models;

namespace plataforma_web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet <User> User {get;set;}
        public DbSet <Product> Product {get;set;}
    }
}
