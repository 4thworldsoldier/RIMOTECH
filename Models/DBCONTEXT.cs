using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RIMOTECH.Models
{
    public class DBCONTEXT : DbContext
    {
        public DBCONTEXT(DbContextOptions options) : base(options) { }
        public DbSet<Moviestore> Moviestores
        {
            get;
            set;
        }
        public DbSet<Customer> Customer
        {
            get;
            set;
        }
        public DbSet<Country> Countries
        {
            get;
            set;
        }
    }
}
