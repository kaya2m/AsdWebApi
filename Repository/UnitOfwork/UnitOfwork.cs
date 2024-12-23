using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Repository.UnitOfwork
{
    public class UnitOfwork : IUnitOfWork   
    {
        private readonly DbContext _dbContext;

        public UnitOfwork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
