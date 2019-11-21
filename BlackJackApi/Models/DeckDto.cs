using BlackJackApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackApi.Models
{
    public class DeckDto
    {
        public int CardsRemaining { get; set; }
        public List<CardDto> Cards { get; set; }
    }
}
