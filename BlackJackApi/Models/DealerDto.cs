using BlackJackApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackApi.Models
{
    public class DealerDto
    {
        public List<CardDto> DealerHand { get; set; }

        public int Score { get; set; }
    }
}
