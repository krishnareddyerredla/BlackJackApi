using BlackJackApi.Core.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlackJackApi.Core.Entities
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public Suit Suit { get; set; }
        public CardValue Value { get; set; }
        public List<DeckCards> DeckCards { get; set; }
        public List<DealerHandCards> DelaerHandCards { get; set; }
        public List<PlayerHandCards> PlayerHandCards { get; set; }
    }
}
