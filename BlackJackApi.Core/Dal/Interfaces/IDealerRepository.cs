using BlackJackApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Dal.Interfaces
{
    public interface IDealerRepository
    {
        Task<Dealer> GetById(int id);        
        Task<Dealer> Add(Dealer _dealer);
        Task<bool> Any(Expression<Func<Dealer, bool>> predicate);
        Task<bool> Update(Dealer _dealer);
    }
}
