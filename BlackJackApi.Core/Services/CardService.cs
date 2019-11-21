using BlackJackApi.Core.Dal.Interfaces;
using BlackJackApi.Core.Entities;
using BlackJackApi.Core.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepo;

        public CardService(ICardRepository cardRepository)
        {
            _cardRepo = cardRepository;
        }

        public Task<IEnumerable<Card>> GetAll()
        {
            return _cardRepo.GetAll();
        }
    }
}
