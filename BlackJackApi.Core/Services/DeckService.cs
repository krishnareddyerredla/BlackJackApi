using BlackJackApi.Core.Dal.Interfaces;
using BlackJackApi.Core.Entities;
using BlackJackApi.Core.Services.Interfaces;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Services
{
    public class DeckService : IDeckService
    {
        private readonly IDeckRepository _deckRepo;

        public DeckService(IDeckRepository deckRepository)
        {
            _deckRepo = deckRepository;
        }

        public Task<Deck> Add(Deck _deck)
        {
            throw new System.NotImplementedException();
        }

        public Task<Deck> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Deck _deck)
        {
            throw new System.NotImplementedException();
        }
    }
}
