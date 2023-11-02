using egitim.Entity;
using EgitimWeb.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace egitim.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Egitim> egitims { get; set; }
        public DbSet<Soru> Sorus { get; set; }
        public DbSet<Konu> Konular { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Test> Testler { get; set; }
        public DbSet<TestDetay> testDetaylar { get; set; }
    }
}
