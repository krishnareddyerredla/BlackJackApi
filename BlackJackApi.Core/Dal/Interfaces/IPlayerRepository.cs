using BlackJackApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Dal.Interfaces
{
    public interface IPlayerRepository
    {
        Task<Player> GetById(int id);       
        Task<Player> Add(Player _player);
        Task<bool> Any(Expression<Func<Player, bool>> predicate);
        Task<bool> Update(Player _player);
    }
}
