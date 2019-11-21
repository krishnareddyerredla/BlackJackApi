using BlackJackApi.Core.Dal.Interfaces;
using BlackJackApi.Core.Entities;
using BlackJackApi.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepo;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepo = gameRepository;
        }

        public Task<Game> Create(Game game)
        {
            game.CreatedAt = DateTime.UtcNow;
            game.Result = Enums.GameResult.Unknown;

            return _gameRepo.Add(game);
        }

        public Task<Game> GetById(int id)
        {
            return _gameRepo.GetById(id);
        }

        public Task<bool> Update(Game _game)
        {
            return _gameRepo.Update(_game);
        }
    }
}
