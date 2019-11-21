using BlackJackApi.Core.Dal.Interfaces;
using BlackJackApi.Core.Entities;
using BlackJackApi.Dal.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlackJackApi.Dal.Repositories
{
    public class DealerRepository : IDealerRepository
    {
        private readonly BlackJackContext _dbContext;

        public DealerRepository(BlackJackContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Dealer> GetById(int id)
        {
            return await _dbContext.Dealers.FindAsync(id);
        }     

        public async Task<Dealer> Add(Dealer _dealer)
        {
            _dbContext.Dealers.Add(_dealer);
            await _dbContext.SaveChangesAsync();

            return _dealer;
        }

        public async Task<bool> Any(Expression<Func<Dealer, bool>> predicate)
        {
            return await _dbContext.Dealers.AnyAsync(predicate);
        }

        public async Task<bool> Update(Dealer _dealer)
        {
            _dbContext.Entry(_dealer).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync() >= 0;
        }
    }
}
