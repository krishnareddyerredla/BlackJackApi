using BlackJackApi.Core.Dal.Interfaces;
using BlackJackApi.Core.Entities;
using BlackJackApi.Core.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepo;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepo = playerRepository;
        }

        public Task<Player> Add(Player _player)
        {
            throw new NotImplementedException();
        }

        public Task<Player> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Player _player)
        {
            throw new NotImplementedException();
        }
    }
}
