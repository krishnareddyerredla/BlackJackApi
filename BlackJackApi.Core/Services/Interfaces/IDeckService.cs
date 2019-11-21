using BlackJackApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Services.Interfaces
{
    public interface IDeckService
    {
        Task<Deck> GetById(int id);
        Task<Deck> Add(Deck _deck);
        Task<bool> Update(Deck _deck);
    }
}
