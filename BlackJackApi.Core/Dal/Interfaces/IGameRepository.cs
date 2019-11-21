using BlackJackApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Dal.Interfaces
{
    public interface IGameRepository
    {
        Task<Game> GetById(int id);     
        Task<Game> Add(Game _game);
        Task<bool> Any(Expression<Func<Game, bool>> predicate);
        Task<bool> Update(Game _game);
    }
}
