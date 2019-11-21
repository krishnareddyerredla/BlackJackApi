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
    public class PlayerRepository : IPlayerRepository
    {
        private readonly BlackJackContext _dbContext;

        public PlayerRepository(BlackJackContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Player> GetById(int id)
        {
            return await _dbContext.Players.FindAsync(id);
        }       

        public async Task<Player> Add(Player _player)
        {
            _dbContext.Players.Add(_player);
            await _dbContext.SaveChangesAsync();

            return _player;
        }

        public async Task<bool> Any(Expression<Func<Player, bool>> predicate)
        {
            return await _dbContext.Players.AnyAsync(predicate);
        }

        public async Task<bool> Update(Player _player)
        {
            _dbContext.Entry(_player).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync() >= 0;
        }
    }
}
