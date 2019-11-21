namespace BlackJackApi.Core.Entities
{
    //In EF Core, many-to-many relationships are not yet supported without an entity class to represent the join table.
    public class DealerHandCards
    {       
        public int DealerId { get; set; }
        public Dealer Dealer { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }       
    }
}
