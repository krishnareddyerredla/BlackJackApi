using BlackJackApi.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Dal.Interfaces
{
    public interface ICardRepository
    {       
        Task<IEnumerable<Card>> GetAll();      
    }
}
