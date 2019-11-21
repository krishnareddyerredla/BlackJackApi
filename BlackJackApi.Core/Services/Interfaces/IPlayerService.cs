using BlackJackApi.Core.Entities;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<Player> GetById(int id);
        Task<Player> Add(Player _player);
        Task<bool> Update(Player _player);
    }
}
