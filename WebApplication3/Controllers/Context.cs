using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication3.VetObjects;

namespace HttpRequestsSample.Models
{
    public class VisitContext : DbContext
    {
        public VisitContext(DbContextOptions<VisitContext> options)
        : base(options) { }

        public DbSet<Visit> Visits { get; set; }

        
    }

}

