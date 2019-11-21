using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlackJackApi.Core.Entities
{
    public class Deck
    {
        [Key]
        public int Id { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<DeckCards> DeckCards { get; set; }
    }
}
