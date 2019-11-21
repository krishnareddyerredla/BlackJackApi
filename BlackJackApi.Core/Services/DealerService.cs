using BlackJackApi.Core.Dal.Interfaces;
using BlackJackApi.Core.Entities;
using BlackJackApi.Core.Services.Interfaces;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Services
{
    public class DealerService : IDealerService
    {
        private readonly IDealerRepository _dealerRepo;

        public DealerService(IDealerRepository dealerRepository)
        {
            _dealerRepo = dealerRepository;
        }

        public Task<Dealer> Create(Dealer _dealer)
        {
            throw new System.NotImplementedException();
        }

        public Task<Dealer> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Dealer _dealer)
        {
            throw new System.NotImplementedException();
        }
    }
}
