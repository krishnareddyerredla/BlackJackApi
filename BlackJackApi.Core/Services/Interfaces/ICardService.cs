using BlackJackApi.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Services.Interfaces
{
    public interface ICardService
    {
        Task<IEnumerable<Card>> GetAll();
    }
}
