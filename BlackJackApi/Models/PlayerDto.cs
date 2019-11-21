using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackApi.Models
{
    public class PlayerDto
    {
        public string PlayerName { get; set; }
        public List<CardDto> PlayerHand { get; set; }
        public int Score { get; set; }
    }
}
