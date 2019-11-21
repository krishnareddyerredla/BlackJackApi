using BlackJackApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Services.Interfaces
{
    public interface IGameService
    {
        Task<Game> GetById(int id);
        Task<Game> Create(Game game);        
        Task<bool> Update(Game _game);
    }
}
