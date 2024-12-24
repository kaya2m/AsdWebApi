using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Domain;
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

        #region TABLE
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<Departmanlar> Departmanlar { get; set; }
        public DbSet<Gorevler> Gorevler { get; set; }
        public DbSet<Moduller> Moduller { get; set; }
        public DbSet<Menuler> Menuler { get; set; }
        #endregion

        #region FUNCTION
        #endregion

        #region STORE PROCEDURE
        #endregion

        #region VIEW
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #region ENTITY CONFIG
            //modelBuilder.Entity<fonksiyonun veya prosedürün adı>().HasNoKey();



            #endregion ENTITY CONFIG

            #region TRIGGERS
            //modelBuilder.Entity<tbl>().ToTable(tb => tb.HasTrigger("dbdeki trriger adı"));
            #endregion TRIGGERS

            #region RELATIONSHIP
            modelBuilder.Entity<Kullanicilar>()
                 .HasOne(k => k.Departmanlar)
                 .WithMany(d => d.Kullanicilar)
                 .HasForeignKey(k => k.DepartmanId)
                 .OnDelete(DeleteBehavior.Restrict); 

            // Kullanicilar -> Gorevler ilişkisi
            modelBuilder.Entity<Kullanicilar>()
                .HasOne(k => k.Gorevler)
                .WithMany(g => g.Kullanicilar)
                .HasForeignKey(k => k.GorevId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                if (data.State == EntityState.Added)
                {
                    data.Entity.CreateDate = DateTime.Now;
                    data.Entity.isActive = true;
                    data.Entity.CreatedUser = "admin";
                }
                if (data.State == EntityState.Modified)
                {
                    data.Entity.UpdateDate = DateTime.Now;
                    data.Entity.UpdatedUser = "admin";
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
