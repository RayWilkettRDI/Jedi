using Jedi.Models.Entities.Specs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.Data
{
    public class JediContext : DbContext
    {
        public JediContext(DbContextOptions<JediContext> options) : base(options)
        {

        }

        public DbSet<TradeSpec> TradeSpecs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TradeSpec>()
                .HasKey(t => t.SpecID)
                .HasName("SpecID");

            modelBuilder.Entity<CrossReference>()
                .HasOne(c => c.TradeSpec)
                .WithMany(t => t.CrossReferences);

            modelBuilder.Entity<CrossReference>()
                .HasKey(c => c.PKID)
                .HasName("PKID");
        }
    }
}
