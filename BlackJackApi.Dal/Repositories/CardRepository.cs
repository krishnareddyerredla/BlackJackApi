using BlackJackApi.Core.Dal.Interfaces;
using BlackJackApi.Core.Entities;
using BlackJackApi.Dal.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlackJackApi.Dal.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly BlackJackContext _dbContext;

        public CardRepository(BlackJackContext dbContext)
        {
            _dbContext = dbContext;
        }        

        public async Task<IEnumerable<Card>> GetAll()
        {
            return await _dbContext.Cards.ToListAsync();
        }       
    }
}
