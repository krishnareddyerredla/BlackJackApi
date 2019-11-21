using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlackJackApi.Core.Entities
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public List<PlayerHandCards> Cards { get; set; }
    }
}