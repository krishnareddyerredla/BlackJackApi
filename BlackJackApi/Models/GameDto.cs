using BlackJackApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackApi.Models
{
    public class GameDto
    {      
        public int GameId { get; set; }
        public int DeckId { get; set; }
        public GameStatus Status { get; set; }
        public DealerDto Dealer { get; set; }
        public PlayerDto Player { get; set; }
        public int RemainingCardsInDeck { get; set; }
    }
}
