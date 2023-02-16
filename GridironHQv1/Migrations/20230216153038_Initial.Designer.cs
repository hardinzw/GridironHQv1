﻿// <auto-generated />
using System;
using GridironHQv1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GridironHQv1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230216153038_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.14");

            modelBuilder.Entity("GridironHQv1.Entities.Stadium", b =>
                {
                    b.Property<int>("StadiumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("GeoLat")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("GeoLong")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlayingSurface")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("StadiumID");

                    b.ToTable("Stadiums");
                });

            modelBuilder.Entity("GridironHQv1.Entities.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("AverageDraftPosition")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("AverageDraftPosition2QB")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("AverageDraftPositionDynasty")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("AverageDraftPositionPPR")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ByeWeek")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Conference")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefensiveCoordinator")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefensiveScheme")
                        .HasColumnType("TEXT");

                    b.Property<string>("Division")
                        .HasColumnType("TEXT");

                    b.Property<string>("DraftKingsName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DraftKingsPlayerID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FanDuelName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FanDuelPlayerID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FantasyDraftName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FantasyDraftPlayerID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("GlobalTeamID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HeadCoach")
                        .HasColumnType("TEXT");

                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("OffensiveCoordinator")
                        .HasColumnType("TEXT");

                    b.Property<string>("OffensiveScheme")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PlayerID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PrimaryColor")
                        .HasColumnType("TEXT");

                    b.Property<string>("QuaternaryColor")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecondaryColor")
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecialTeamsCoach")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StadiumID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TertiaryColor")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UpcomingDraftKingsSalary")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UpcomingFanDuelSalary")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UpcomingOpponent")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UpcomingOpponentPositionRank")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UpcomingOpponentRank")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UpcomingSalary")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UpcomingYahooSalary")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WikipediaLogoUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("WikipediaWordMarkUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("YahooName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("YahooPlayerID")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeamID");

                    b.HasIndex("StadiumID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("GridironHQv1.Entities.Team", b =>
                {
                    b.HasOne("GridironHQv1.Entities.Stadium", "StadiumDetails")
                        .WithMany()
                        .HasForeignKey("StadiumID");

                    b.Navigation("StadiumDetails");
                });
#pragma warning restore 612, 618
        }
    }
}