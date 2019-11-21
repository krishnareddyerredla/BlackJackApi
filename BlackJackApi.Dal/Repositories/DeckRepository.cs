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
    public class DeckRepository : IDeckRepository
    {
        private readonly BlackJackContext _dbContext;

        public DeckRepository(BlackJackContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Deck> GetById(int id)
        {
            return await _dbContext.Decks.FindAsync(id);
        }       

        public async Task<Deck> Add(Deck _deck)
        {
            _dbContext.Decks.Add(_deck);
            await _dbContext.SaveChangesAsync();

            return _deck;
        }

        public async Task<bool> Any(Expression<Func<Deck, bool>> predicate)
        {
            return await _dbContext.Decks.AnyAsync(predicate);
        }

        public async Task<bool> Update(Deck _deck)
        {
            _dbContext.Entry(_deck).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync() >= 0;
        }
    }
}
