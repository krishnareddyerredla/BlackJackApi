using BlackJackApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackApi.Core.Services.Interfaces
{
    public interface IDealerService
    {
        Task<Dealer> GetById(int id);
        Task<Dealer> Create(Dealer _dealer);      
        Task<bool> Update(Dealer _dealer);
    }
}
