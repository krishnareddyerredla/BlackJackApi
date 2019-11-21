using BlackJackApi.Core.Dal.Interfaces;
using BlackJackApi.Core.Entities;
using BlackJackApi.Dal.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApi.Dal.Repositories
{
    public class GameRepository: IGameRepository
    {
        private readonly BlackJackContext _dbContext;

        public GameRepository(BlackJackContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Game> GetById(int id)
        {
            return await _dbContext.Games.FindAsync(id);
        }       

        public async Task<Game> Add(Game _game)
        {
            _dbContext.Games.Add(_game);
            await _dbContext.SaveChangesAsync();

            return _game;
        }

        public async Task<bool> Any(Expression<Func<Game, bool>> predicate)
        {
            return await _dbContext.Games.AnyAsync(predicate);
        }

        public async Task<bool> Update(Game _game)
        {
            _dbContext.Entry(_game).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync() >= 0;
        }
    }
}
