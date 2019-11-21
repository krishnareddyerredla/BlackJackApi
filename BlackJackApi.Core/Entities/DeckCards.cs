namespace BlackJackApi.Core.Entities
{
    //In EF Core, many-to-many relationships are not yet supported without an entity class to represent the join table.
    public class DeckCards
    {       
        public int DeckId { get; set; }
        public Deck Deck { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        //To find if the card is drawn or not
        public bool IsDrawn { get; set; }
        //To draw cards in the order they were shuffled in the begining of the game
        public int Order { get; set; }
    }
}
