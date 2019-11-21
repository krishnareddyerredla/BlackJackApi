using BlackJackApi.Core.Entities;
using BlackJackApi.Core.Enums;
using BlackJackApi.Core.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlackJackApi.Dal.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {          
            modelBuilder.Entity<Card>().HasData(GetNewDeckOfCards());         
        }
        public static List<Card> GetNewDeckOfCards()
        {
            var cards = new List<Card>();

            int cardIndex = 1;
            //CardSuits: 1 to 4
            for (int s = 1; s <= 4; s++)
            {
                //Card Face Values: 1,2...10,J,Q,K different values 
                for (int v = 1; v <= 13; v++)
                {
                    cards.Add(new Card()
                    {
                        Id = cardIndex,
                        Suit = (Suit)s,
                        Value = (CardValue)v
                    });
                    cardIndex++;
                }
            }

            return cards;
        }
    }
}
