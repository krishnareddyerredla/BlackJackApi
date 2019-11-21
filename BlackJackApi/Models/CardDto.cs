using BlackJackApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackApi.Models
{
    public class CardDto
    {
        public Suit Suit { get; set; }
        public CardValue Value { get; set; }
    }
}
