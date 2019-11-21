using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlackJackApi.Core.Entities
{
    public class Dealer
    {
        [Key]
        public int Id { get; set; }
        public List<DealerHandCards> Cards { get; set; }
        public int DeckId { get; set; }
        public Deck Deck { get; set; }
    }
}