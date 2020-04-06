﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PopPopTradingCardsDataAccess;

namespace PopPopTradingCardsDataAccess.Migrations
{
    [DbContext(typeof(PopPopTradingCardsDbContext))]
    [Migration("20200406021615_Seed3")]
    partial class Seed3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PopPopTradingCardsDataAccess.Entities.BaseballCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Team")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("BaseballCard");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "/C:/Users/ZFisher-LegionY530/Desktop/PopPopTradingCards/PopPopTradingCards/PopPopTradingCards/Images/Mickey_Mantle1952.jpg",
                            Location = "Red box in Attic",
                            PlayerName = "Micky Mantle",
                            Team = "New York Yankees",
                            UserId = -1,
                            Year = 1952
                        },
                        new
                        {
                            Id = 2,
                            Image = "/C:/Users/ZFisher-LegionY530/Desktop/PopPopTradingCards/PopPopTradingCards/PopPopTradingCards/Images/Mickey_Mantle1952.jpg",
                            Location = "Red box in Attic",
                            PlayerName = "Micky Mantle",
                            Team = "New York Yankees",
                            UserId = 2,
                            Year = 1952
                        },
                        new
                        {
                            Id = 3,
                            Image = "/C:/Users/ZFisher-LegionY530/Desktop/PopPopTradingCards/PopPopTradingCards/PopPopTradingCards/Images/Mickey_Mantle1952.jpg",
                            Location = "Red box in Attic",
                            PlayerName = "Micky Mantle",
                            Team = "New York Yankees",
                            UserId = 3,
                            Year = 1952
                        });
                });

            modelBuilder.Entity("PopPopTradingCardsDataAccess.Entities.MagicCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Booster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CMC")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rarity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MagicCard");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Booster = "Zendikar",
                            CMC = 5,
                            Color = "Black",
                            Image = "/C:/Users/ZFisher-LegionY530/Desktop/PopPopTradingCards/PopPopTradingCards/PopPopTradingCards/Images/Ob_Nixilis_the_Fallen.jpg",
                            Location = "",
                            Name = "Ob Bixilis, the Fallen",
                            Rarity = "Ultra Rare",
                            Type = "Legendary Creature - Demon",
                            UserId = -1
                        },
                        new
                        {
                            Id = 5,
                            Booster = "Zendikar",
                            CMC = 5,
                            Color = "Black",
                            Image = "/C:/Users/ZFisher-LegionY530/Desktop/PopPopTradingCards/PopPopTradingCards/PopPopTradingCards/Images/Ob_Nixilis_the_Fallen.jpg",
                            Location = "",
                            Name = "Ob Bixilis, the Fallen",
                            Rarity = "Ultra Rare",
                            Type = "Legendary Creature - Demon",
                            UserId = 1
                        },
                        new
                        {
                            Id = 1,
                            Booster = "Zendikar",
                            CMC = 3,
                            Color = "Black",
                            Image = "/C:/Users/ZFisher-LegionY530/Desktop/PopPopTradingCards/PopPopTradingCards/PopPopTradingCards/Images/Vampire_Knighthawk_Zendikar.jfif",
                            Location = "Basement, red binder",
                            Name = "Vampire Nighthawk",
                            Rarity = "Uncommon",
                            Type = "Creature - Vampire Shaman",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Booster = "Zendikar",
                            CMC = 3,
                            Color = "Black",
                            Image = "/C:/Users/ZFisher-LegionY530/Desktop/PopPopTradingCards/PopPopTradingCards/PopPopTradingCards/Images/Vampire_Knighthawk_Zendikar.jfif",
                            Location = "",
                            Name = "Vampire Nighthawk",
                            Rarity = "Uncommon",
                            Type = "Creature - Vampire Shaman",
                            UserId = -1
                        },
                        new
                        {
                            Id = 3,
                            Booster = "Zendikar",
                            CMC = 3,
                            Color = "Black",
                            Image = "/C:/Users/ZFisher-LegionY530/Desktop/PopPopTradingCards/PopPopTradingCards/PopPopTradingCards/Images/Vampire_Knighthawk_Zendikar.jfif",
                            Location = "Basement, red binder",
                            Name = "Vampire Nighthawk",
                            Rarity = "Uncommon",
                            Type = "Creature - Vampire Shaman",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("PopPopTradingCardsDataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User","TradingCardTracker");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Password = "CardList",
                            Username = "CardList"
                        },
                        new
                        {
                            Id = 1,
                            Password = "Magic",
                            Username = "Magic"
                        },
                        new
                        {
                            Id = 2,
                            Password = "Baseball",
                            Username = "Baseball"
                        },
                        new
                        {
                            Id = 3,
                            Password = "???b??^????jYh?)?x^?K?? ???? ",
                            Username = "Both"
                        },
                        new
                        {
                            Id = 4,
                            Password = "Cardless",
                            Username = "Cardless"
                        });
                });

            modelBuilder.Entity("PopPopTradingCardsDataAccess.Entities.BaseballCard", b =>
                {
                    b.HasOne("PopPopTradingCardsDataAccess.Entities.User", "User")
                        .WithMany("BaseballCards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PopPopTradingCardsDataAccess.Entities.MagicCard", b =>
                {
                    b.HasOne("PopPopTradingCardsDataAccess.Entities.User", "User")
                        .WithMany("MagicCards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
