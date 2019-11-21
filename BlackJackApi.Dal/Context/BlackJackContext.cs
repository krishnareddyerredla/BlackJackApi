using BlackJackApi.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BlackJackApi.Dal.Context
{
    public sealed class BlackJackContext : DbContext
    {
        public BlackJackContext(DbContextOptions<BlackJackContext> options) : base(options)
        {
           // Database.Migrate();
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Card> Cards { get; set; }

        //In EF Core, many-to-many relationships are not yet supported without an entity class to represent the join table.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure DeckCards
            modelBuilder.Entity<DeckCards>()
                .HasKey(dc => new { dc.DeckId, dc.CardId });

            modelBuilder.Entity<DeckCards>()
                .HasOne(d => d.Deck)
                .WithMany(dc => dc.DeckCards)
                .HasForeignKey(dc => dc.DeckId);

            modelBuilder.Entity<DeckCards>()
                .HasOne(c => c.Card)
                .WithMany(dc => dc.DeckCards)
                .HasForeignKey(dc => dc.CardId);

            //Configure DealerHandCards
            modelBuilder.Entity<DealerHandCards>()
               .HasKey(hc => new { hc.DealerId, hc.CardId });

            modelBuilder.Entity<DealerHandCards>()
                .HasOne(h => h.Dealer)
                .WithMany(hc => hc.Cards)
                .HasForeignKey(hc => hc.DealerId);

            modelBuilder.Entity<DealerHandCards>()
                  .HasOne(c => c.Card)
                .WithMany(hc => hc.DelaerHandCards)
                .HasForeignKey(hc => hc.CardId);

            //Configure PlayerHandCards
            modelBuilder.Entity<PlayerHandCards>()
               .HasKey(hc => new { hc.PlayerId, hc.CardId });

            modelBuilder.Entity<PlayerHandCards>()
                .HasOne(h => h.Player)
                .WithMany(hc => hc.Cards)
                .HasForeignKey(hc => hc.PlayerId);

            modelBuilder.Entity<PlayerHandCards>()
                  .HasOne(c => c.Card)
                .WithMany(hc => hc.PlayerHandCards)
                .HasForeignKey(hc => hc.CardId);

            // Debugger.Launch();

            //Seed Data
            modelBuilder.Seed();
        }
    }
}
