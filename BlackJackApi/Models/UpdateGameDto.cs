using BlackJackApi.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackJackApi.Models
{
    public class UpdateGameDto
    {
        public GameResult Result { get; set; }
        public GameStatus Status { get; set; }
    }
}
