﻿// <auto-generated />
using System;
using BlackJackApi.Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlackJackApi.Dal.Migrations
{
    [DbContext(typeof(BlackJackContext))]
    [Migration("20191121134337_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlackJackApi.Core.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Suit")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Suit = 1,
                            Value = 1
                        },
                        new
                        {
                            Id = 2,
                            Suit = 1,
                            Value = 2
                        },
                        new
                        {
                            Id = 3,
                            Suit = 1,
                            Value = 3
                        },
                        new
                        {
                            Id = 4,
                            Suit = 1,
                            Value = 4
                        },
                        new
                        {
                            Id = 5,
                            Suit = 1,
                            Value = 5
                        },
                        new
                        {
                            Id = 6,
                            Suit = 1,
                            Value = 6
                        },
                        new
                        {
                            Id = 7,
                            Suit = 1,
                            Value = 7
                        },
                        new
                        {
                            Id = 8,
                            Suit = 1,
                            Value = 8
                        },
                        new
                        {
                            Id = 9,
                            Suit = 1,
                            Value = 9
                        },
                        new
                        {
                            Id = 10,
                            Suit = 1,
                            Value = 10
                        },
                        new
                        {
                            Id = 11,
                            Suit = 1,
                            Value = 11
                        },
                        new
                        {
                            Id = 12,
                            Suit = 1,
                            Value = 12
                        },
                        new
                        {
                            Id = 13,
                            Suit = 1,
                            Value = 13
                        },
                        new
                        {
                            Id = 14,
                            Suit = 2,
                            Value = 1
                        },
                        new
                        {
                            Id = 15,
                            Suit = 2,
                            Value = 2
                        },
                        new
                        {
                            Id = 16,
                            Suit = 2,
                            Value = 3
                        },
                        new
                        {
                            Id = 17,
                            Suit = 2,
                            Value = 4
                        },
                        new
                        {
                            Id = 18,
                            Suit = 2,
                            Value = 5
                        },
                        new
                        {
                            Id = 19,
                            Suit = 2,
                            Value = 6
                        },
                        new
                        {
                            Id = 20,
                            Suit = 2,
                            Value = 7
                        },
                        new
                        {
                            Id = 21,
                            Suit = 2,
                            Value = 8
                        },
                        new
                        {
                            Id = 22,
                            Suit = 2,
                            Value = 9
                        },
                        new
                        {
                            Id = 23,
                            Suit = 2,
                            Value = 10
                        },
                        new
                        {
                            Id = 24,
                            Suit = 2,
                            Value = 11
                        },
                        new
                        {
                            Id = 25,
                            Suit = 2,
                            Value = 12
                        },
                        new
                        {
                            Id = 26,
                            Suit = 2,
                            Value = 13
                        },
                        new
                        {
                            Id = 27,
                            Suit = 3,
                            Value = 1
                        },
                        new
                        {
                            Id = 28,
                            Suit = 3,
                            Value = 2
                        },
                        new
                        {
                            Id = 29,
                            Suit = 3,
                            Value = 3
                        },
                        new
                        {
                            Id = 30,
                            Suit = 3,
                            Value = 4
                        },
                        new
                        {
                            Id = 31,
                            Suit = 3,
                            Value = 5
                        },
                        new
                        {
                            Id = 32,
                            Suit = 3,
                            Value = 6
                        },
                        new
                        {
                            Id = 33,
                            Suit = 3,
                            Value = 7
                        },
                        new
                        {
                            Id = 34,
                            Suit = 3,
                            Value = 8
                        },
                        new
                        {
                            Id = 35,
                            Suit = 3,
                            Value = 9
                        },
                        new
                        {
                            Id = 36,
                            Suit = 3,
                            Value = 10
                        },
                        new
                        {
                            Id = 37,
                            Suit = 3,
                            Value = 11
                        },
                        new
                        {
                            Id = 38,
                            Suit = 3,
                            Value = 12
                        },
                        new
                        {
                            Id = 39,
                            Suit = 3,
                            Value = 13
                        },
                        new
                        {
                            Id = 40,
                            Suit = 4,
                            Value = 1
                        },
                        new
                        {
                            Id = 41,
                            Suit = 4,
                            Value = 2
                        },
                        new
                        {
                            Id = 42,
                            Suit = 4,
                            Value = 3
                        },
                        new
                        {
                            Id = 43,
                            Suit = 4,
                            Value = 4
                        },
                        new
                        {
                            Id = 44,
                            Suit = 4,
                            Value = 5
                        },
                        new
                        {
                            Id = 45,
                            Suit = 4,
                            Value = 6
                        },
                        new
                        {
                            Id = 46,
                            Suit = 4,
                            Value = 7
                        },
                        new
                        {
                            Id = 47,
                            Suit = 4,
                            Value = 8
                        },
                        new
                        {
                            Id = 48,
                            Suit = 4,
                            Value = 9
                        },
                        new
                        {
                            Id = 49,
                            Suit = 4,
                            Value = 10
                        },
                        new
                        {
                            Id = 50,
                            Suit = 4,
                            Value = 11
                        },
                        new
                        {
                            Id = 51,
                            Suit = 4,
                            Value = 12
                        },
                        new
                        {
                            Id = 52,
                            Suit = 4,
                            Value = 13
                        });
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.Dealer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeckId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeckId");

                    b.ToTable("Dealers");
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.DealerHandCards", b =>
                {
                    b.Property<int>("DealerId")
                        .HasColumnType("int");

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.HasKey("DealerId", "CardId");

                    b.HasIndex("CardId");

                    b.ToTable("DealerHandCards");
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.Deck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId")
                        .IsUnique();

                    b.ToTable("Decks");
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.DeckCards", b =>
                {
                    b.Property<int>("DeckId")
                        .HasColumnType("int");

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDrawn")
                        .HasColumnType("bit");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("DeckId", "CardId");

                    b.HasIndex("CardId");

                    b.ToTable("DeckCards");
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DealerId")
                        .HasColumnType("int");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DealerId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.PlayerHandCards", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "CardId");

                    b.HasIndex("CardId");

                    b.ToTable("PlayerHandCards");
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.Dealer", b =>
                {
                    b.HasOne("BlackJackApi.Core.Entities.Deck", "Deck")
                        .WithMany()
                        .HasForeignKey("DeckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.DealerHandCards", b =>
                {
                    b.HasOne("BlackJackApi.Core.Entities.Card", "Card")
                        .WithMany("DelaerHandCards")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlackJackApi.Core.Entities.Dealer", "Dealer")
                        .WithMany("Cards")
                        .HasForeignKey("DealerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.Deck", b =>
                {
                    b.HasOne("BlackJackApi.Core.Entities.Game", "Game")
                        .WithOne("Deck")
                        .HasForeignKey("BlackJackApi.Core.Entities.Deck", "GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.DeckCards", b =>
                {
                    b.HasOne("BlackJackApi.Core.Entities.Card", "Card")
                        .WithMany("DeckCards")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlackJackApi.Core.Entities.Deck", "Deck")
                        .WithMany("DeckCards")
                        .HasForeignKey("DeckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.Game", b =>
                {
                    b.HasOne("BlackJackApi.Core.Entities.Dealer", "Dealer")
                        .WithMany()
                        .HasForeignKey("DealerId");
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.Player", b =>
                {
                    b.HasOne("BlackJackApi.Core.Entities.Game", "Game")
                        .WithOne("Player")
                        .HasForeignKey("BlackJackApi.Core.Entities.Player", "GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlackJackApi.Core.Entities.PlayerHandCards", b =>
                {
                    b.HasOne("BlackJackApi.Core.Entities.Card", "Card")
                        .WithMany("PlayerHandCards")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlackJackApi.Core.Entities.Player", "Player")
                        .WithMany("Cards")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}