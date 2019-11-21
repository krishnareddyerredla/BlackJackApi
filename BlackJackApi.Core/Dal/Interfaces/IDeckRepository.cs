using BlackJackApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Dal.Interfaces
{
    public interface IDeckRepository
    {
        Task<Deck> GetById(int id);      
        Task<Deck> Add(Deck _deck);
        Task<bool> Any(Expression<Func<Deck, bool>> predicate);
        Task<bool> Update(Deck _deck);
    }
}
