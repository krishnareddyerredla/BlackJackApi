using BlackJackApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlackJackApi.Core.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public GameResult Result { get; set; }
        public GameStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public Dealer Dealer { get; set; }
        public Player Player { get; set; }
        public Deck Deck { get; set; }
    }
}
