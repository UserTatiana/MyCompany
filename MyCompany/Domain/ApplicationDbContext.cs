using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain
{
    public class ApplicationDbContext : IdentityDbContext
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {                      
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<LegalEntities> LegalEntitieses { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<RelationshipType> RelationshipTypes { get; set; }

    }
}
