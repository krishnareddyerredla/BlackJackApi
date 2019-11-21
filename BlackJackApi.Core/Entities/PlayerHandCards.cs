namespace BlackJackApi.Core.Entities
{
    //In EF Core, many-to-many relationships are not yet supported without an entity class to represent the join table.
    public class PlayerHandCards
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}
