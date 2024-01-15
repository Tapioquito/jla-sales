using JLASales.Business.Interfaces;
using JLASales.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLASales.Data.UoW
{
    public class UnitofWork : IUnitOfWork
    {
        private readonly JLASalesDBContext _dbContext;

        public UnitofWork(JLASalesDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Commit()
        {
            return await _dbContext.SaveChangesAsync() > 0;
            // como é um bool, deve retornar uma condição booleana.
        }
    }
}
