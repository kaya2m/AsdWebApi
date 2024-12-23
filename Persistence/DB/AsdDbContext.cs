using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
