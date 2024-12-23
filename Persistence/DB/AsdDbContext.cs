using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Global.Kullanici;
using Domain.Entities.Global.Modul;
using Microsoft.EntityFrameworkCore;

namespace Persistence.DB
{
    public class AsdDbContext : DbContext
    {
        public AsdDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AsdDbContext()
        {
        }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<Gruplar> Gruplar { get; set; }
        public DbSet<Birimler> Birimler { get; set; }
        public DbSet<Gorevler> Gorevler { get; set; }
        public DbSet<Moduller> Moduller { get; set; }
        public DbSet<Menuler> Menuler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #region ENTITY CONFIG
            //modelBuilder.Entity<fonksiyonun veya prosedürün adı>().HasNoKey();
            


            #endregion ENTITY CONFIG

            #region TRIGGERS
            //modelBuilder.Entity<tbl>().ToTable(tb => tb.HasTrigger("dbdeki trriger adı"));
            #endregion TRIGGERS

            base.OnModelCreating(modelBuilder);
        }
    }
}
