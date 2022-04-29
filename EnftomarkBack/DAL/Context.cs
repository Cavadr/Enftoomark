using EnftomarkBack.Models;
using Microsoft.EntityFrameworkCore;
using Mvc_BackendProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnftomarkBack.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Additions> Additionss { get; set; }
    }
}
