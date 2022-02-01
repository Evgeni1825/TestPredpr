using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Predpr;

namespace WebApp.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Factory> Factories { get; set; }
       

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Factory>()
                                .HasOne(f => f.nsi00219)
                                .WithOne(nsi00219 => nsi00219.Factory)
                                .HasForeignKey<Nsi00219>(n => n.FactoryForeignKey);

            modelBuilder.Entity<Factory>()
                    .HasOne(f => f.nsi00208)
                    .WithOne(nsi00208 => nsi00208.Factory)
                    .HasForeignKey<Nsi00208>(n => n.FactoryForeignKey);

            modelBuilder.Entity<Factory>()
                    .HasOne(f => f.nsi00212CRT)
                    .WithOne(nsi00212CRT => nsi00212CRT.Factory)
                    .HasForeignKey<Nsi00212CRT>(n => n.FactoryForeignKey);

            modelBuilder.Entity<Factory>()
                   .HasOne(f => f.nsi00228)
                   .WithOne(nsi00228 => nsi00228.Factory)
                   .HasForeignKey<Nsi00228>(n => n.FactoryForeignKey);

            modelBuilder.Entity<Factory>()
                   .HasOne(f => f.nsi00212LKV)
                   .WithOne(nsi00212LKV => nsi00212LKV.Factory)
                   .HasForeignKey<Nsi00212LKV>(n => n.FactoryForeignKey);

            modelBuilder.Entity<Factory>()
                    .HasOne(f => f.nsi00212)
                    .WithOne(nsi00212 => nsi00212.Factory)
                    .HasForeignKey<Nsi00212>(n => n.FactoryForeignKey);

            modelBuilder.Entity<Factory>()
                    .HasOne(f => f.nsi00211)
                    .WithOne(nsi00211 => nsi00211.Factory)
                    .HasForeignKey<Nsi00211>(n => n.FactoryForeignKey);
        }
    }
}
