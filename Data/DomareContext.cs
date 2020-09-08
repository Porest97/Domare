using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domare.Models.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Domare.Data
{
    public class DomareContext : IdentityDbContext
    {
        public DomareContext (DbContextOptions<DomareContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }

    }
}
